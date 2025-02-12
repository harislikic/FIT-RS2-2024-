import 'dart:convert';

import 'package:desktop_app/models/statistics.dart';
import 'package:desktop_app/services/config.dart';
import 'package:http/http.dart' as http;

class StatisticsService {
  Future<Statistics> fetchStatistics() async {

    try {
      String url = '$baseUrl/api/Statistics';
      final response = await http.get(Uri.parse(url));

      if (response.statusCode == 200) {
        return Statistics.fromJson(
            jsonDecode(response.body));
      } else {
        throw Exception('Error: ${response.statusCode} - ${response.body}');
      }
    } catch (e) {
      throw Exception(
          'Exception: $e');
    }
  }
}
