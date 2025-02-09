import 'package:flutter/material.dart';
import 'package:desktop_app/services/AuthService.dart';

class SplashScreen extends StatefulWidget {
  const SplashScreen({Key? key}) : super(key: key);

  @override
  State<SplashScreen> createState() => _SplashScreenState();
}

class _SplashScreenState extends State<SplashScreen> {
  @override
  void initState() {
    super.initState();
    _checkLoginStatus();
  }

  Future<void> _checkLoginStatus() async {
    // Provera da li je korisnik prijavljen
    final isLoggedIn = await AuthService.checkIfUserIsLoggedIn();

    if (isLoggedIn) {
      // Ako je prijavljen, idi na Admin Panel Screen
      Navigator.pushReplacementNamed(context, '/admin-panel');
    } else {
      // Ako nije prijavljen, idi na Login Screen
      Navigator.pushReplacementNamed(context, '/login');
    }
  }

  @override
  Widget build(BuildContext context) {
    return const Scaffold(
      body: Center(
        child: CircularProgressIndicator(), // Prikazivanje loading indikatora
      ),
    );
  }
}
