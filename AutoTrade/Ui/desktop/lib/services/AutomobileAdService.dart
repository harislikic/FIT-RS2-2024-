import 'dart:async';
import 'dart:convert';
import 'package:http/http.dart' as http;
import '../models/automobileAd.dart';
import 'ApiConfig.dart';

class AutomobileAdService {
  Future<Map<String, dynamic>> fetchAutomobileAds({
    String searchTerm = '',
    int page = 0,
    int pageSize = 25,
    String? status,
  }) async {
    final queryParams = {
      'Page': page.toString(),
      'PageSize': pageSize.toString(),
      if (searchTerm.isNotEmpty) 'Title': searchTerm,
      if (status != null) 'Status': status,
    };

    final uri = Uri.parse('${ApiConfig.baseUrl}/AutomobileAd')
        .replace(queryParameters: queryParams);
    final response = await http.get(uri);

    if (response.statusCode == 200) {
      final Map<String, dynamic> data = json.decode(response.body);
      return {
        'count': data['count'], // ✔️ Pravi API vraća 'count'
        'data': List<AutomobileAd>.from(
            data['data'].map((item) => AutomobileAd.fromJson(item))),
      };
    } else {
      throw Exception('Failed to load automobile ads');
    }
  }

  Future<void> removeAutomobile(
      int automobileId, Map<String, String> authHeaders) async {
    authHeaders['accept'] = 'text/plain';

    final response = await http.delete(
      Uri.parse('${ApiConfig.baseUrl}/AutomobileAd/$automobileId'),
      headers: authHeaders,
    );

    if (response.statusCode != 200) {
      throw Exception('Failed to remove automobile');
    }
  }

  Future<void> markAsActive(int automobileId) async {
    final uri = Uri.parse(
        '${ApiConfig.baseUrl}/AutomobileAd/mar-as-active/$automobileId');

    final response =
        await http.put(uri, headers: {'accept': 'application/json'});

    if (response.statusCode == 200) {
      print('AutomobileAd $automobileId marked as active');
    } else {
      throw Exception('Failed to mark automobile as active: ${response.body}');
    }
  }
}
