import 'package:desktop_app/components/AdminList.dart';
import 'package:desktop_app/components/UsersList.dart';
import 'package:flutter/material.dart';
import 'AdAdminScreen.dart';

class AdminPanelScreen extends StatelessWidget {
  const AdminPanelScreen({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text('Admin Panel'),
      ),
      drawer: Drawer(
        child: ListView(
          padding: EdgeInsets.zero,
          children: [
            DrawerHeader(
              decoration: BoxDecoration(color: Colors.blueGrey[900]),
              child: const Text(
                'Admin Panel',
                style: TextStyle(
                  color: Colors.white,
                  fontSize: 24,
                  fontWeight: FontWeight.bold,
                ),
              ),
            ),
            ListTile(
              leading: const Icon(Icons.person_add),
              title: const Text('Dodaj Admina'),
              onTap: () {
                Navigator.of(context).push(
                  MaterialPageRoute(
                    builder: (context) => const AddAdminScreen(),
                  ),
                );
              },
            ),
              ListTile(
              leading: const Icon(Icons.group),
              title: const Text('Pregled Korsnika'),
              onTap: () {
                Navigator.of(context).push(
                  MaterialPageRoute(
                    builder: (context) => const UsersList(),
                  ),
                );
              },
            ),
          ],
        ),
      ),
      body: const AdminList()
    );
  }
}
