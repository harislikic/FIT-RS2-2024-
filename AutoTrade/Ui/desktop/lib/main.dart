import 'package:desktop_app/screens/%20LoginScreen.dart';
import 'package:desktop_app/screens/SplashScreen.dart';

import 'package:desktop_app/services/AuthService.dart';
import 'package:desktop_app/screens/AdminPanelScreen.dart';
import 'package:flutter/material.dart';
import 'package:flutter_dotenv/flutter_dotenv.dart';
import 'package:flutter_stripe/flutter_stripe.dart';

void main() async {
  WidgetsFlutterBinding
      .ensureInitialized();

  try {
    await dotenv.load(fileName: ".env");
  } catch (e) {
    print("⚠️ Greška pri učitavanju `.env`: $e");
  }

  String stripePublishableKey = dotenv.env['STRIPE_PUBLISHABLE_KEY'] ?? '';
  if (stripePublishableKey.isEmpty) {
    print("⚠️ Upozorenje: `STRIPE_PUBLISHABLE_KEY` nije pronađen!");
  } else {
    Stripe.publishableKey = stripePublishableKey;
  }

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
      home: const SplashScreen(),
      routes: {
        '/admin-panel': (context) =>
            const AdminPanelScreen(),
        '/login': (context) => const LoginScreen(), 
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
          .checkIfUserIsLoggedIn(),
      builder: (context, snapshot) {
        if (snapshot.connectionState == ConnectionState.waiting) {
         
          return const Scaffold(
            body: Center(
              child: CircularProgressIndicator(),
            ),
          );
        } else if (snapshot.hasData && snapshot.data == true) {
          
          Future.microtask(() {
            Navigator.pushReplacementNamed(context, '/admin-panel');
          });
        } else {
         
          Future.microtask(() {
            Navigator.pushReplacementNamed(context, '/login');
          });
        }

        return const SizedBox();
      },
    );
  }
}
