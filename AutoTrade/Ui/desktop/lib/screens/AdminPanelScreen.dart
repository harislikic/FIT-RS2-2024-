import 'package:desktop_app/components/AdminList.dart';
import 'package:desktop_app/components/AutomobileAdsList.dart';
import 'package:desktop_app/components/CarBrandList.dart';
import 'package:desktop_app/components/CarCategoryList.dart';
import 'package:desktop_app/components/CarModelList.dart';
import 'package:desktop_app/components/CommentList.dart';
import 'package:desktop_app/components/EquipmentList.dart';
import 'package:desktop_app/components/UsersList.dart';
import 'package:desktop_app/components/shared/TooltipIconButton.dart';
import 'package:desktop_app/screens/ LoginScreen.dart';
import 'package:desktop_app/screens/AdAdminScreen.dart';
import 'package:desktop_app/screens/StatisticsScreen.dart';
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
                    builder: (context) => const AddAdminScreen(isAdmin: true,),
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
                    builder: (context) => const AutomobileAdsList(),
                  ),
                );
              },
            ),
            ListTile(
              leading: const Icon(Icons.branding_watermark_outlined,
                  color: Colors.purpleAccent),
              title: const Text('Brendovi automobila'),
              onTap: () {
                Navigator.of(context).push(
                  MaterialPageRoute(
                    builder: (context) => const CarBrandList(),
                  ),
                );
              },
            ),
            ListTile(
              leading: const Icon(Icons.category, color: Colors.purpleAccent),
              title: const Text('Kategorije automobila'),
              onTap: () {
                Navigator.of(context).push(
                  MaterialPageRoute(
                    builder: (context) => const CarCategoryList(),
                  ),
                );
              },
            ),
            ListTile(
              leading:
                  const Icon(Icons.model_training, color: Colors.purpleAccent),
              title: const Text('Modeli automobila'),
              onTap: () {
                Navigator.of(context).push(
                  MaterialPageRoute(
                    builder: (context) => const CarModelList(),
                  ),
                );
              },
            ),
            ListTile(
              leading:
                  const Icon(Icons.garage_rounded, color: Colors.purpleAccent),
              title: const Text('Dodatna oprema automobila'),
              onTap: () {
                Navigator.of(context).push(
                  MaterialPageRoute(
                    builder: (context) => const EquipmentList(),
                  ),
                );
              },
            ),
            ListTile(
              leading: const Icon(Icons.comment, color: Colors.amber),
              title: const Text('Pregled komentara'),
              onTap: () {
                Navigator.of(context).push(
                  MaterialPageRoute(
                    builder: (context) => const CommentList(),
                  ),
                );
              },
            ),
            ListTile(
              leading: const Icon(Icons.analytics_sharp, color: Colors.purple),
              title: const Text('Stripe Analitika'),
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
              title: const Text('Analitika'),
              onTap: () {
                Navigator.of(context).push(
                  MaterialPageRoute(
                    builder: (context) => StatisticsScreen(),
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
