import 'dart:convert';
import 'package:desktop_app/models/city.dart';
import 'package:desktop_app/services/config.dart';
import 'package:http/http.dart' as http;

class CityService {
  Future<List<City>> fetchCities({int page = 0, int pageSize = 90}) async {
    final String url = '$baseUrl/City';

    final Uri uri = Uri.parse(url).replace(queryParameters: {
      'Page': page.toString(),
      'PageSize': pageSize.toString(),
    });

    final response = await http.get(uri);

    if (response.statusCode == 200) {
      final data = json.decode(response.body);

      if (data['data'] != null && data['data'] is List) {
        final List<dynamic> items = data['data'];
        return items.map((json) => City.fromJson(json)).toList();
      } else {
        return [];
      }
    } else {
      throw Exception('Failed to load car models');
    }
  }
}
