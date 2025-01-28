import 'package:desktop_app/components/shared/SnackbarHelper.dart';
import 'package:desktop_app/services/ApiConfig.dart';
import 'package:desktop_app/services/UserService.dart';
import 'package:flutter/material.dart';

class AdminList extends StatefulWidget {
  const AdminList({Key? key}) : super(key: key);

  @override
  State<AdminList> createState() => _AdminListState();
}

class _AdminListState extends State<AdminList> {
  final TextEditingController _searchController = TextEditingController();
  List<dynamic> _admins = [];
  int _count = 0;
  int _currentPage = 0;
  bool _isLoading = false;
  final int _pageSize = 25;

  @override
  void initState() {
    super.initState();
    _fetchAdmins();
  }

  Future<void> _fetchAdmins({String? query}) async {
    if (_isLoading) return;

    setState(() {
      _isLoading = true;

      // Resetuj listu admina samo ako radimo novu pretragu
      if (query != null) {
        _admins = [];
        _currentPage = 0; // Resetuj paginaciju
      }
    });

    try {
      final data = await UserService.getAllAdmins(
        page: _currentPage,
        pageSize: _pageSize,
        query: query,
      );

      setState(() {
        _count = data['count'];
        _admins.addAll(data['data']);
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

      // Ponovno učitavanje podataka
      _fetchAdmins(query: _searchController.text);
    } catch (e) {
      ScaffoldMessenger.of(context).showSnackBar(
        SnackBar(content: Text('Error: $e')),
      );
    }
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text('Admin lista'),
      ),
      body: Column(
        children: [
          Padding(
            padding: const EdgeInsets.all(8.0),
            child: Row(
              children: [
                SizedBox(
                  width: 400, // Postavite željenu širinu
                  child: TextField(
                    controller: _searchController,
                    decoration: const InputDecoration(
                      labelText: 'Pretraga',
                      border: OutlineInputBorder(),
                      isDense: true, // Manji padding unutar polja
                    ),
                    onSubmitted: (_) =>
                        _fetchAdmins(query: _searchController.text),
                  ),
                ),
                const SizedBox(width: 8),
                ElevatedButton(
                  onPressed: () => _fetchAdmins(query: _searchController.text),
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
                      rows: _admins
                          .map(
                            (admin) => DataRow(
                              cells: [
                                DataCell(Text(admin['id'].toString())),
                                DataCell(Text(admin['firstName'] ?? '-')),
                                DataCell(Text(admin['lastName'] ?? '-')),
                                DataCell(Text(admin['userName'] ?? '-')),
                                DataCell(Text(admin['email'] ?? '-')),
                                DataCell(Text(admin['phoneNumber'] ?? '-')),
                                DataCell(Text(admin['adress'] ?? '-')),
                                DataCell(Text(admin['city']['title'] ?? '-')),
                                DataCell(Text(admin['dateOfBirth'] != null
                                    ? admin['dateOfBirth']
                                    : '-')),
                                DataCell(
                                  admin['profilePicture'] != null
                                      ? Image.network(
                                          '${ApiConfig.baseUrl}${admin['profilePicture']}',
                                          width: 50,
                                          height: 50,
                                        )
                                      : const Icon(Icons.person),
                                ),
                                DataCell(
                                  IconButton(
                                    icon: const Icon(Icons.delete,
                                        color: Colors.red),
                                    onPressed: () => _deleteAdmin(admin['id']),
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
