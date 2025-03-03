import 'package:desktop_app/components/shared/SnackbarHelper.dart';
import 'package:desktop_app/models/comment.dart';
import 'package:desktop_app/services/CommentService.dart';
import 'package:desktop_app/services/config.dart';
import 'package:flutter/material.dart';
import 'package:intl/intl.dart';

class CommentList extends StatefulWidget {
  const CommentList({Key? key}) : super(key: key);

  @override
  State<CommentList> createState() => _CommentListState();
}

class _CommentListState extends State<CommentList> {
  final TextEditingController _searchController = TextEditingController();
  final TextEditingController _automobileIdController = TextEditingController();

  List<Comment> _comments = [];
  int _count = 0;
  int _currentPage = 0;
  int _tablePage = 0;
  bool _isLoading = false;
  final int _pageSize = 25;

  @override
  void initState() {
    super.initState();
    _fetchComments();
  }

  Future<void> _fetchComments({int? userId, int? automobileId}) async {
    if (_isLoading) return;

    setState(() {
      _isLoading = true;
      if (userId != null || automobileId != null) {
        _comments = [];
        _currentPage = 0;
        _tablePage = 0;
      }
    });

    try {
      final data = await CommentService().fetchAllComments(
        page: _currentPage,
        pageSize: _pageSize,
        userId: userId,
        automobileId: automobileId,
      );

      setState(() {
        _count = data['totalCount'] ?? 0;
        _comments.addAll(data['comments']);
        _currentPage++;
      });
    } catch (e) {
      SnackbarHelper.showSnackbar(context, 'Error: $e');
    } finally {
      setState(() {
        _isLoading = false;
      });
    }
  }

  Future<void> _deleteComment(int commentId) async {
    final confirm = await showDialog<bool>(
      context: context,
      builder: (context) => AlertDialog(
        title: const Text('Potvrda'),
        content:
            const Text('Da li ste sigurni da želite obrisati ovaj komentar?'),
        actions: [
          TextButton(
            onPressed: () => Navigator.of(context).pop(false),
            child: const Text('Ne'),
          ),
          TextButton(
            onPressed: () => Navigator.of(context).pop(true),
            child: const Text('Da'),
          ),
        ],
      ),
    );

    if (confirm != true) return;

    try {
      await CommentService().deleteComment(commentId: commentId);

      setState(() {
        _comments.removeWhere((comment) => comment.commentId == commentId);
        _count--;
      });

      SnackbarHelper.showSnackbar(context, 'Komentar obrisan uspešno',
          backgroundColor: Colors.green);
      _fetchComments(
        userId: int.tryParse(_searchController.text),
        automobileId: int.tryParse(_automobileIdController.text),
      );
    } catch (e) {
      SnackbarHelper.showSnackbar(context, 'Error: $e');
    }
  }

  List<dynamic> get _currentComments {
    final startIndex = _tablePage * _pageSize;
    int endIndex = startIndex + _pageSize;
    if (endIndex > _comments.length) {
      endIndex = _comments.length;
    }
    if (startIndex >= _comments.length) {
      return [];
    }
    return _comments.sublist(startIndex, endIndex);
  }

  bool get canGoNext {
    final nextPageIndex = (_tablePage + 1) * _pageSize;
    return nextPageIndex < _count;
  }

  bool get canGoPrev => _tablePage > 0;

  void _nextPage() {
    setState(() {
      final nextPage = _tablePage + 1;
      final nextStartIndex = nextPage * _pageSize;

      if (nextStartIndex >= _comments.length && _comments.length < _count) {
        _fetchComments(
          userId: int.tryParse(_searchController.text),
          automobileId: int.tryParse(_automobileIdController.text),
        );
      }

      _tablePage = nextPage;
    });
  }

  void _prevPage() {
    if (_tablePage > 0) {
      setState(() {
        _tablePage--;
      });
    }
  }

  void _onSearch() {
    _fetchComments(
      userId: int.tryParse(_searchController.text),
      automobileId: int.tryParse(_automobileIdController.text),
    );
  }

  @override
  Widget build(BuildContext context) {
    int startDisplay;
    int endDisplay;

    if (_count == 0) {
      startDisplay = 0;
      endDisplay = 0;
    } else {
      startDisplay = _tablePage * _pageSize + 1;
      endDisplay = startDisplay + _pageSize - 1;
      if (endDisplay > _count) {
        endDisplay = _count;
      }
    }

    return Scaffold(
      appBar: AppBar(
        title: const Text('Pregled komentara'),
      ),
      body: Column(
        crossAxisAlignment: CrossAxisAlignment.start,
        children: [
          Padding(
            padding: const EdgeInsets.all(8.0),
            child: Wrap(
              alignment: WrapAlignment.start,
              crossAxisAlignment: WrapCrossAlignment.center,
              spacing: 16.0,
              runSpacing: 8.0,
              children: [
                SizedBox(
                  width: 200,
                  child: TextField(
                    controller: _searchController,
                    decoration: InputDecoration(
                      labelText: 'Pretraga po User ID',
                      border: const OutlineInputBorder(),
                      suffixIcon: _searchController.text.isNotEmpty
                          ? IconButton(
                              icon: const Icon(Icons.clear),
                              onPressed: () {
                                setState(() {
                                  _searchController.clear();
                                  _currentPage = 0;
                                  _tablePage = 0;
                                  _fetchComments();
                                });
                              },
                            )
                          : null,
                    ),
                    onChanged: (value) => setState(() {}),
                    onSubmitted: (_) => _onSearch(),
                  ),
                ),
                SizedBox(
                  width: 200,
                  child: TextField(
                    controller: _automobileIdController,
                    decoration: InputDecoration(
                      labelText: 'Pretraga po Auto ID',
                      border: const OutlineInputBorder(),
                      suffixIcon: _automobileIdController.text.isNotEmpty
                          ? IconButton(
                              icon: const Icon(Icons.clear),
                              onPressed: () {
                                setState(() {
                                  _automobileIdController.clear();
                                  _currentPage = 0;
                                  _tablePage = 0;
                                  _fetchComments();
                                });
                              },
                            )
                          : null,
                    ),
                    onChanged: (value) => setState(() {}),
                    onSubmitted: (_) => _onSearch(),
                  ),
                ),
                ElevatedButton(
                  onPressed: _onSearch,
                  child: const Text('Traži'),
                ),
                Text(
                  'Ukupan broj komentara: $_count',
                  style: const TextStyle(
                    fontSize: 16,
                    fontWeight: FontWeight.bold,
                  ),
                ),
              ],
            ),
          ),
          Expanded(
            child: SingleChildScrollView(
              scrollDirection: Axis.vertical,
              child: SingleChildScrollView(
                scrollDirection: Axis.horizontal,
                child: ConstrainedBox(
                  constraints: BoxConstraints(
                      minWidth: MediaQuery.of(context).size.width),
                  child: DataTable(
                    columns: const [
                      DataColumn(label: Text('ID')),
                      DataColumn(label: Text('Komentar')),
                      DataColumn(label: Text('Datum')),
                      DataColumn(label: Text('Korisnik username')),
                      DataColumn(label: Text('Profilna')),
                      DataColumn(label: Text('Akcija')),
                    ],
                    rows: _currentComments.map((comment) {
                      return DataRow(
                        cells: [
                          DataCell(Text(comment.commentId.toString())),
                          DataCell(Text(comment.content)),
                          DataCell(
                            Text(DateFormat('dd.MM.yyyy HH:mm')
                                .format(comment.createdAt)),
                          ),
                          DataCell(Text(comment.user.userName)),
                          DataCell(
                            comment.user.profilePicture != null
                                ? Image.network(
                                    '$baseUrl${comment.user.profilePicture}',
                                    width: 50,
                                    height: 50,
                                    errorBuilder: (context, error, stackTrace) {
                                      return Image.asset(
                                        'assets/fallback.jpg',
                                        width: 50,
                                        height: 50,
                                        fit: BoxFit.cover,
                                      );
                                    },
                                  )
                                : Image.asset(
                                    'assets/fallback.jpg',
                                    width: 50,
                                    height: 50,
                                    fit: BoxFit.cover,
                                  ),
                          ),
                          DataCell(
                            IconButton(
                              icon: const Icon(Icons.delete, color: Colors.red),
                              onPressed: () =>
                                  _deleteComment(comment.commentId),
                            ),
                          ),
                        ],
                      );
                    }).toList(),
                  ),
                ),
              ),
            ),
          ),
          Column(
            mainAxisAlignment: MainAxisAlignment.center,
            crossAxisAlignment: CrossAxisAlignment.center,
            children: [
              Row(
                mainAxisAlignment: MainAxisAlignment.center,
                children: [
                  ElevatedButton(
                    onPressed: canGoPrev ? _prevPage : null,
                    child: const Icon(Icons.arrow_back),
                  ),
                  const SizedBox(width: 16),
                  ElevatedButton(
                    onPressed: canGoNext ? _nextPage : null,
                    child: const Icon(Icons.arrow_forward),
                  ),
                ],
              ),
              const SizedBox(height: 8),
              Text(
                'Prikaz: $startDisplay - $endDisplay (od $_count)',
                style: const TextStyle(fontSize: 15),
              ),
              if (_isLoading) ...[
                const SizedBox(height: 8),
                const CircularProgressIndicator(),
              ],
            ],
          )
        ],
      ),
    );
  }
}
