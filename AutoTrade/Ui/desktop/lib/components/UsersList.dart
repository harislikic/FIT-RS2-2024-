import 'package:desktop_app/components/shared/SnackbarHelper.dart';
import 'package:desktop_app/services/ApiConfig.dart';
import 'package:desktop_app/services/UserService.dart';
import 'package:flutter/material.dart';

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
      }
    });

    try {
      final data = await UserService.getAllAdmins(
        page: _currentPage,
        pageSize: _pageSize,
        query: query,
        isAdmin: false
      );

      setState(() {
        _count = data['count'];
        _users.addAll(data['data']);
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
        content: const Text('Da li ste sigurni da želite obrisati ovog korisnika?'),
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

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text('Lista korisnika'),
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
                    decoration: const InputDecoration(
                      labelText: 'Pretraga',
                      border: OutlineInputBorder(),
                      isDense: true,
                    ),
                    onSubmitted: (_) => _fetchUsers(query: _searchController.text),
                  ),
                ),
                const SizedBox(width: 8),
                ElevatedButton(
                  onPressed: () => _fetchUsers(query: _searchController.text),
                  child: const Text('Traži'),
                ),
                const SizedBox(width: 16),
                Text('Ukupan broj: $_count'),
              ],
            ),
          ),
          Expanded(
            child: _isLoading
                ? const Center(child: CircularProgressIndicator())
                : SingleChildScrollView(
                    scrollDirection: Axis.horizontal,
                    child: DataTable(
                      columns: const [
                        DataColumn(label: Text('ID')),
                        DataColumn(label: Text('Ime')),
                        DataColumn(label: Text('Prezime')),
                        DataColumn(label: Text('Username')),
                        DataColumn(label: Text('Email')),
                        DataColumn(label: Text('Telefon')),
                        DataColumn(label: Text('Adresa')),
                        DataColumn(label: Text('Grad')),
                        DataColumn(label: Text('Datum Rođenja')),
                        DataColumn(label: Text('Slika')),
                        DataColumn(label: Text('Akcija')),
                      ],
                      rows: _users
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
                                DataCell(Text(user['dateOfBirth'] != null
                                    ? user['dateOfBirth']
                                    : '-')),
                                DataCell(
                                  user['profilePicture'] != null
                                      ? Image.network(
                                          '${ApiConfig.baseUrl}${user['profilePicture']}',
                                          width: 50,
                                          height: 50,
                                        )
                                      : const Icon(Icons.person),
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
        ],
      ),
    );
  }
}
