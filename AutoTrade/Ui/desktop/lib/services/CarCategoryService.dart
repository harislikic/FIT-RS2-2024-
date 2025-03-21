import 'dart:convert';
import 'package:desktop_app/models/carCategory.dart';
import 'package:desktop_app/services/AuthService.dart';
import 'package:desktop_app/services/config.dart';
import 'package:http/http.dart' as http;

class CarCategoryService {
  Future<List<CarCategory>> fetchCarCategories(
      {int page = 0, int pageSize = 25}) async {
    const String url = '$baseUrl/CarCategory';

    final Uri uri = Uri.parse(url).replace(queryParameters: {
      'Page': page.toString(),
      'PageSize': pageSize.toString(),
    });

    final response = await http.get(uri);

    if (response.statusCode == 200) {
      final data = json.decode(response.body);

      if (data['data'] != null && data['data'] is List) {
        final List<dynamic> items = data['data'];
        return items.map((json) => CarCategory.fromJson(json)).toList();
      } else {
        return [];
      }
    } else {
      throw Exception('Failed to load car categories');
    }
  }

  Future<void> addCarCategory(String name) async {
    final Uri uri = Uri.parse('$baseUrl/CarCategory');
    final headers = await AuthService.getAuthHeaders();
    headers['Content-Type'] = 'application/json';

    final body = json.encode({'name': name});

    final response = await http.post(uri, headers: headers, body: body);

    if (response.statusCode < 200 || response.statusCode >= 300) {
      throw Exception('Failed to add car category: ${response.body}');
    }
  }

  Future<void> updateCarCategory(int id, String name) async {
    final Uri uri = Uri.parse('$baseUrl/CarCategory/$id');
    final headers = await AuthService.getAuthHeaders();
    headers['Content-Type'] = 'application/json';

    final body = json.encode({'name': name});

    final response = await http.put(uri, headers: headers, body: body);
    if (response.statusCode != 200) {
      throw Exception('Failed to update car brand');
    }
  }
}
