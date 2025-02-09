import 'dart:convert';

import 'package:desktop_app/models/PaymentResponse.dart';
import 'package:flutter_dotenv/flutter_dotenv.dart';
import 'package:http/http.dart' as http;

class PaymentService {
  Future<PaymentResponse> getAllTransactions({int? year, int? month}) async {
    String url = '${dotenv.env['BASE_URL']}/PaymentTransaction';

    if (year != null || month != null) {
      List<String> params = [];
      if (year != null) params.add('year=$year');
      if (month != null) params.add('month=$month');
      url += '?${params.join('&')}';
    }

    try {
      final response =
          await http.get(Uri.parse(url), headers: {'accept': 'text/plain'});

      if (response.statusCode == 200) {
        final data = json.decode(response.body);
        return PaymentResponse.fromJson(data);
      } else {
        throw Exception('Failed to load transactions: ${response.statusCode}');
      }
    } catch (e) {
      throw Exception('Error fetching transactions: $e');
    }
  }

  final String _stripeSecretKey = dotenv.env['STRIPE_SECRET_KEY']!;

  /// ✅ Metoda koja dohvaća SVE Stripe transakcije bez paginacije
  Future<List<dynamic>> getStripeTransactions() async {
    const String url = 'https://api.stripe.com/v1/charges?limit=300';

    try {
      final response = await http.get(
        Uri.parse(url), // Bez paginacije, preuzima sve transakcije
        headers: {
          'Authorization': 'Bearer $_stripeSecretKey',
          'Content-Type': 'application/x-www-form-urlencoded',
        },
      );

      if (response.statusCode == 200) {
        final data = json.decode(response.body);
        return data['data']; // Vraća listu transakcija
      } else {
        throw Exception('Stripe API error: ${response.statusCode}');
      }
    } catch (e) {
      throw Exception('Greška pri dohvaćanju Stripe transakcija: $e');
    }
  }
}
