import 'package:desktop_app/screens/%20LoginScreen.dart';

import 'package:desktop_app/services/AuthService.dart';
import 'package:desktop_app/screens/AdminPanelScreen.dart'; // Pretpostavljam da već imaš AdminPanelScreen
import 'package:flutter/material.dart';

void main() {
  runApp(const MyApp());
}

class MyApp extends StatelessWidget {
  const MyApp({super.key});

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: 'Flutter Demo',
      theme: ThemeData(
        colorScheme: ColorScheme.fromSeed(seedColor: Colors.deepPurple),
        useMaterial3: true,
      ),
      home: const InitialScreen(), // Početni ekran
      routes: {
        '/admin-panel': (context) =>
            const AdminPanelScreen(), // Ruta za Admin Panel
        '/login': (context) => const LoginScreen(), // Ruta za Login
      },
    );
  }
}

class InitialScreen extends StatelessWidget {
  const InitialScreen({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return FutureBuilder<bool>(
      future: AuthService
          .checkIfUserIsLoggedIn(), // Provera da li je korisnik logovan
      builder: (context, snapshot) {
        if (snapshot.connectionState == ConnectionState.waiting) {
          // Prikazivanje loading ekrana dok se čeka rezultat
          return const Scaffold(
            body: Center(
              child: CircularProgressIndicator(),
            ),
          );
        } else if (snapshot.hasData && snapshot.data == true) {
          // Ako je korisnik logovan, preusmeravamo ga na Admin Panel
          Future.microtask(() {
            Navigator.pushReplacementNamed(context, '/admin-panel');
          });
        } else {
          // Ako korisnik nije logovan, preusmeravamo ga na Login ekran
          Future.microtask(() {
            Navigator.pushReplacementNamed(context, '/login');
          });
        }

        return const SizedBox(); // Povratna vrednost dok čekamo navigaciju
      },
    );
  }
}
