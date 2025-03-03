import 'package:desktop_app/components/shared/SnackbarHelper.dart';
import 'package:desktop_app/services/UserService.dart';
import 'package:desktop_app/services/config.dart';
import 'package:flutter/material.dart';
import 'package:intl/intl.dart';

class UsersList extends StatefulWidget {
  const UsersList({Key? key}) : super(key: key);

  @override
  State<UsersList> createState() => _UsersListState();
}

class _UsersListState extends State<UsersList> {
  final TextEditingController _searchController = TextEditingController();

  List<dynamic> _users = [];
  int _count = 0;

  int _currentPage = 0;

  int _tablePage = 0;

  bool _isLoading = false;
  final int _pageSize = 25;

  @override
  void initState() {
    super.initState();
    _fetchUsers();
  }

  Future<void> _fetchUsers({String? query}) async {
    if (_isLoading) return;

    setState(() {
      _isLoading = true;
      if (query != null) {
        _users = [];
        _currentPage = 0;
        _tablePage = 0;
      }
    });

    try {
      final data = await UserService.getAllAdmins(
        page: _currentPage,
        pageSize: _pageSize,
        query: query,
        isAdmin: false,
      );

      setState(() {
        _count = data['count'] ?? 0;
        _users.addAll(data['data']);
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

  Future<void> _deleteUser(int userId) async {
    final confirm = await showDialog<bool>(
      context: context,
      builder: (context) => AlertDialog(
        title: const Text('Potvrda'),
        content:
            const Text('Da li ste sigurni da želite obrisati ovog korisnika?'),
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
      await UserService.deleteAdmin(userId);

      setState(() {
        _users.removeWhere((user) => user['id'] == userId);
        _count--;
      });

      SnackbarHelper.showSnackbar(context, 'Korisnik obrisan uspešno',
          backgroundColor: Colors.green);

      _fetchUsers(query: _searchController.text);
    } catch (e) {
      SnackbarHelper.showSnackbar(context, 'Error: $e');
    }
  }

  List<dynamic> get _currentUsers {
    final startIndex = _tablePage * _pageSize;
    int endIndex = startIndex + _pageSize;
    if (endIndex > _users.length) {
      endIndex = _users.length;
    }
    if (startIndex >= _users.length) {
      return [];
    }
    return _users.sublist(startIndex, endIndex);
  }

  bool get canGoNext {
    final nextPageIndex = (_tablePage + 1) * _pageSize;
    if (nextPageIndex >= _count) {
      return false;
    }
    return true;
  }

  bool get canGoPrev => _tablePage > 0;

  void _nextPage() {
    setState(() {
      final nextPage = _tablePage + 1;
      final nextStartIndex = nextPage * _pageSize;

      if (nextStartIndex >= _users.length && _users.length < _count) {
        _fetchUsers();
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
    _fetchUsers(query: _searchController.text);
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
        title: const Text('Pregled korisnika'),
      ),
      body: Column(
        children: [
          Padding(
            padding: const EdgeInsets.all(8.0),
            child: Row(
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
                                _onSearch();
                              },
                            )
                          : null,
                    ),
                    onSubmitted: (_) => _onSearch(),
                  ),
                ),
                const SizedBox(width: 8),
                ElevatedButton(
                  onPressed: _onSearch,
                  child: const Text('Traži'),
                ),
                const SizedBox(width: 16),
                Text(
                  'Ukupan broj registrovanih korisnika: $_count',
                  style: const TextStyle(
                      fontSize: 16, fontWeight: FontWeight.bold),
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
                      DataColumn(label: Text('Kanton')),
                      DataColumn(label: Text('Grad')),
                      DataColumn(label: Text('Datum Rođenja')),
                      DataColumn(label: Text('Slika')),
                      DataColumn(label: Text('Akcija')),
                    ],
                    rows: _currentUsers
                        .map(
                          (user) => DataRow(
                            cells: [
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
                                          DateTime.parse(user['dateOfBirth']))
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
                                IconButton(
                                  icon: const Icon(Icons.delete,
                                      color: Colors.red),
                                  onPressed: () => _deleteUser(user['id']),
                                ),
                              ),
                            ],
                          ),
                        )
                        .toList(),
                  ),
                ),
              ),
            ),
          ),
          Padding(
            padding: const EdgeInsets.symmetric(vertical: 8.0),
            child: Column(
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
                if (_isLoading)
                  const Padding(
                    padding: EdgeInsets.all(8.0),
                    child: CircularProgressIndicator(),
                  ),
              ],
            ),
          ),
        ],
      ),
    );
  }
}
