import 'dart:convert';

import 'package:desktop_app/models/PaymentResponse.dart';
import 'package:desktop_app/services/ApiConfig.dart';
import 'package:flutter_dotenv/flutter_dotenv.dart';
import 'package:http/http.dart' as http;

class PaymentService {
  Future<PaymentResponse> getAllTransactions({int? year, int? month}) async {
    String url = '${ApiConfig.baseUrl}/PaymentTransaction';

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

  /// ✅ Metoda koja iterativno dohvaća SVE Stripe transakcije
  Future<List<dynamic>> getStripeTransactions() async {
    const String url = 'https://api.stripe.com/v1/charges';
    List<dynamic> allTransactions = [];
    String? startingAfter;

    try {
      while (true) {
        // Dodaj paginaciju ako postoji `starting_after`
        final response = await http.get(
          Uri.parse(startingAfter == null
              ? '$url?limit=100'
              : '$url?limit=100&starting_after=$startingAfter'),
          headers: {
            'Authorization': 'Bearer $_stripeSecretKey',
            'Content-Type': 'application/x-www-form-urlencoded',
          },
        );

        if (response.statusCode == 200) {
          final data = json.decode(response.body);

          // Dodaj transakcije u listu
          allTransactions.addAll(data['data']);

          // Ako nema više podataka, prekidamo petlju
          if (!data['has_more']) {
            break;
          }

          // Postavi novi `starting_after` za sledeću stranicu
          startingAfter = data['data'].last['id'];
        } else {
          throw Exception('Stripe API error: ${response.statusCode}');
        }
      }

      return allTransactions;
    } catch (e) {
      throw Exception('Greška pri dohvaćanju Stripe transakcija: $e');
    }
  }
}
