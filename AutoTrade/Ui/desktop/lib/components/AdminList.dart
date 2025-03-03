import 'package:desktop_app/components/shared/SnackbarHelper.dart';
import 'package:desktop_app/services/AuthService.dart';
import 'package:desktop_app/services/UserService.dart';
import 'package:flutter/material.dart';
import 'package:intl/intl.dart';
import 'package:desktop_app/services/config.dart';

class AdminList extends StatefulWidget {
  const AdminList({Key? key}) : super(key: key);

  @override
  State<AdminList> createState() => _AdminListState();
}

class _AdminListState extends State<AdminList> {
  final TextEditingController _searchController = TextEditingController();

  List<dynamic> _admins = [];
  int? _loggedInUserId;
  int _count = 0;

  int _currentPage = 0;

  int _tablePage = 0;

  bool _isLoading = false;
  final int _pageSize = 25;

  @override
  void initState() {
    super.initState();
    _fetchAdmins();
    _fetchLoggedInUserId();
  }

  Future<void> _fetchLoggedInUserId() async {
    final userId = await AuthService.getUserId();
    setState(() {
      _loggedInUserId = userId;
    });
  }

  Future<void> _fetchAdmins({String? query}) async {
    if (_isLoading) return;

    setState(() {
      _isLoading = true;
      if (query != null) {
        _admins = [];
        _currentPage = 0;
        _tablePage = 0;
      }
    });

    try {
      final data = await UserService.getAllAdmins(
        page: _currentPage,
        pageSize: _pageSize,
        query: query,
        isAdmin: true,
      );

      setState(() {
        _count = data['count'];
        _admins.addAll(data['data']);

        _currentPage++;
      });
    } catch (e) {
      ScaffoldMessenger.of(context).showSnackBar(
        SnackBar(content: Text('Error: $e')),
      );
    } finally {
      setState(() {
        _isLoading = false;
      });
    }
  }

  Future<void> _deleteAdmin(int adminId) async {
    final confirm = await showDialog<bool>(
      context: context,
      builder: (context) => AlertDialog(
        title: const Text('Potvrda'),
        content:
            const Text('Da li ste sigurni da želite obrisati ovog admina?'),
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
      await UserService.deleteAdmin(adminId);

      setState(() {
        _admins.removeWhere((admin) => admin['id'] == adminId);
        _count--;
      });

      SnackbarHelper.showSnackbar(context, 'Admin obrisan uspešno',
          backgroundColor: Colors.green);

      _fetchAdmins(query: _searchController.text);
    } catch (e) {
      ScaffoldMessenger.of(context).showSnackBar(
        SnackBar(content: Text('Error: $e')),
      );
    }
  }

  List<dynamic> get _currentAdmins {
    final startIndex = _tablePage * _pageSize;
    int endIndex = startIndex + _pageSize;
    if (endIndex > _admins.length) {
      endIndex = _admins.length;
    }
    if (startIndex >= _admins.length) {
      return [];
    }
    return _admins.sublist(startIndex, endIndex);
  }

  void _onSearch() {
    _fetchAdmins(query: _searchController.text);
  }

  bool get canGoNext {
    final nextPage = _tablePage + 1;
    final nextStartIndex = nextPage * _pageSize;

    if (nextStartIndex >= _count) {
      return false;
    }
    return true;
  }

  bool get canGoPrev => _tablePage > 0;

  void _nextPage() {
    setState(() {
      final nextPage = _tablePage + 1;
      final nextStartIndex = nextPage * _pageSize;
      if (nextStartIndex >= _admins.length && _admins.length < _count) {
        _fetchAdmins();
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
        title: const Text('Pregled Admina'),
      ),
      body: SingleChildScrollView(
        scrollDirection: Axis.vertical,
        child: Column(
          crossAxisAlignment: CrossAxisAlignment.start,
          children: [
            Padding(
              padding: const EdgeInsets.all(8.0),
              child: Wrap(
                alignment: WrapAlignment.center,
                crossAxisAlignment: WrapCrossAlignment.center,
                spacing: 16.0,
                runSpacing: 8.0,
                children: [
                  SizedBox(
                    width: 400,
                    child: TextField(
                      controller: _searchController,
                      decoration: InputDecoration(
                        labelText: 'Pretraga',
                        border: const OutlineInputBorder(),
                        isDense: true,
                        suffixIcon: _searchController.text.isNotEmpty
                            ? IconButton(
                                icon: const Icon(Icons.clear),
                                onPressed: () {
                                  _searchController.clear();
                                  _fetchAdmins(query: '');
                                },
                              )
                            : null,
                      ),
                      onSubmitted: (_) =>
                          _fetchAdmins(query: _searchController.text),
                    ),
                  ),
                  ElevatedButton(
                    onPressed: () =>
                        _fetchAdmins(query: _searchController.text),
                    child: const Text('Traži'),
                  ),
                  Text(
                    'Ukupan broj Admina: $_count',
                    style: const TextStyle(
                        fontSize: 16, fontWeight: FontWeight.bold),
                  ),
                ],
              ),
            ),
            SingleChildScrollView(
              scrollDirection: Axis.horizontal,
              child: ConstrainedBox(
                constraints: BoxConstraints(
                  minWidth: MediaQuery.of(context).size.width,
                ),
                child: DataTable(
                  dividerThickness: 1,
                  headingRowColor:
                      MaterialStateProperty.all(Colors.blueGrey[50]),
                  columns: const [
                    DataColumn(label: Text('ID')),
                    DataColumn(label: Text('Ime')),
                    DataColumn(label: Text('Prezime')),
                    DataColumn(label: Text('Username')),
                    DataColumn(label: Text('Email')),
                    DataColumn(label: Text('Telefon')),
                    DataColumn(label: Text('Adresa')),
                    DataColumn(label: Text('Grad')),
                    DataColumn(label: Text('Kanton')),
                    DataColumn(label: Text('Datum Rođenja')),
                    DataColumn(label: Text('Slika')),
                    DataColumn(label: Text('Akcija')),
                  ],
                  rows: _currentAdmins
                      .map((user) => DataRow(cells: [
                            DataCell(Text(user['id'].toString())),
                            DataCell(Text(user['firstName'] ?? '-')),
                            DataCell(Text(user['lastName'] ?? '-')),
                            DataCell(Text(user['userName'] ?? '-')),
                            DataCell(Text(user['email'] ?? '-')),
                            DataCell(Text(user['phoneNumber'] ?? '-')),
                            DataCell(Text(user['adress'] ?? '-')),
                            DataCell(Text(user['city']['title'] ?? '-')),
                            DataCell(
                                Text(user['city']['canton']['title'] ?? '-')),
                            DataCell(
                              Text(
                                user['dateOfBirth'] != null
                                    ? DateFormat('dd.MM.yyyy').format(
                                        DateTime.parse(user['dateOfBirth']),
                                      )
                                    : '-',
                              ),
                            ),
                            DataCell(
                              user['profilePicture'] != null
                                  ? Image.network(
                                      '$baseUrl${user['profilePicture']}',
                                      width: 50,
                                      height: 50,
                                      errorBuilder:
                                          (context, error, stackTrace) {
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
                              _loggedInUserId != null &&
                                      user['id'] == _loggedInUserId
                                  ? const SizedBox()
                                  : IconButton(
                                      icon: const Icon(Icons.delete,
                                          color: Colors.red),
                                      onPressed: () => _deleteAdmin(user['id']),
                                    ),
                            ),
                          ]))
                      .toList(),
                ),
              ),
            ),
            const SizedBox(height: 8),
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
      ),
    );
  }
}
