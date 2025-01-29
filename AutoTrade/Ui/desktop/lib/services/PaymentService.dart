import 'dart:convert';

import 'package:desktop_app/models/PaymentResponse.dart';
import 'package:desktop_app/services/ApiConfig.dart';
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
      final response = await http.get(Uri.parse(url), headers: {'accept': 'text/plain'});

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
}
