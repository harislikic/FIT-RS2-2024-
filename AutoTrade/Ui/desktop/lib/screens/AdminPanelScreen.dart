import 'package:desktop_app/components/AdminList.dart';
import 'package:desktop_app/components/AutomobileAdsList.dart';
import 'package:desktop_app/components/PaymentAnalytics.dart';
import 'package:desktop_app/components/UsersList.dart';
import 'package:desktop_app/components/shared/TooltipIconButton.dart';
import 'package:desktop_app/screens/ LoginScreen.dart';
import 'package:desktop_app/screens/AdAdminScreen.dart';
import 'package:desktop_app/screens/StripeTransactionsScreen.dart';
import 'package:desktop_app/services/AuthService.dart';
import 'package:flutter/material.dart';

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
              child: Column(
                crossAxisAlignment: CrossAxisAlignment.start,
                mainAxisAlignment: MainAxisAlignment.start,
                children: [
                  Row(
                    mainAxisAlignment: MainAxisAlignment.spaceBetween,
                    children: [
                      const Text(
                        'Admin Panel',
                        style: TextStyle(
                          color: Colors.white,
                          fontSize: 24,
                          fontWeight: FontWeight.bold,
                        ),
                      ),
                      TooltipIconButton(
                        message: 'Zatvori',
                        icon: Icons.close,
                        iconColor: Colors.white,
                        onPressed: () {
                          Navigator.of(context).pop();
                        },
                      ),
                    ],
                  ),
                ],
              ),
            ),
            ListTile(
              leading: const Icon(Icons.person_add, color: Colors.green),
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
              leading: const Icon(Icons.group, color: Colors.orange),
              title: const Text('Pregled Korsnika'),
              onTap: () {
                Navigator.of(context).push(
                  MaterialPageRoute(
                    builder: (context) => const UsersList(),
                  ),
                );
              },
            ),
            ListTile(
              leading: const Icon(Icons.car_crash, color: Colors.blue),
              title: const Text('Pregled oglasa'),
              onTap: () {
                Navigator.of(context).push(
                  MaterialPageRoute(
                    builder: (context) => AutomobileAdsList(),
                  ),
                );
              },
            ),
            ListTile(
              leading: const Icon(Icons.analytics_sharp, color: Colors.purple),
              title: const Text('Stripe Analitika transkacija'),
              onTap: () {
                Navigator.of(context).push(
                  MaterialPageRoute(
                    builder: (context) => StripeTransactionsScreen(),
                  ),
                );
              },
            ),
            ListTile(
              leading: const Icon(Icons.analytics, color: Colors.redAccent),
              title: const Text('Bazza Analitika transkacija'),
              onTap: () {
                Navigator.of(context).push(
                  MaterialPageRoute(
                    builder: (context) => PaymentAnalytics(),
                  ),
                );
              },
            ),
            
            FutureBuilder<bool>(
              future: AuthService.checkIfUserIsLoggedIn(),
              builder: (context, snapshot) {
               
                if (!snapshot.hasData) {
                  return const SizedBox();
                }
             
                if (!snapshot.data!) {
                  return const SizedBox();
                }

                return ListTile(
                  leading: const Icon(Icons.logout, color: Colors.grey),
                  title: const Text('Odjava'),
                  onTap: () async {
                    await AuthService.logout();
                    Navigator.of(context).pushReplacement(
                      MaterialPageRoute(
                        builder: (context) => const LoginScreen(),
                      ),
                    );
                  },
                );
              },
            ),
          ],
        ),
      ),
      body: const AdminList(),
    );
  }
}
