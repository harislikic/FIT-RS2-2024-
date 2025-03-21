import 'dart:convert';
import 'package:desktop_app/models/carBrand.dart';

import 'package:desktop_app/services/config.dart';
import 'package:http/http.dart' as http;

import 'AuthService.dart';

class CarBrandService {
  Future<List<CarBrand>> fetchCarBrands(
      {int page = 0, int pageSize = 50}) async {
    const String url = '$baseUrl/CarBrand';

    final Uri uri = Uri.parse(url).replace(queryParameters: {
      'Page': page.toString(),
      'PageSize': pageSize.toString(),
    });

    final response = await http.get(uri);

    if (response.statusCode == 200) {
      final data = json.decode(response.body);

      if (data['data'] != null && data['data'] is List) {
        final List<dynamic> items = data['data'];
        return items.map((json) => CarBrand.fromJson(json)).toList();
      } else {
        return [];
      }
    } else {
      throw Exception('Failed to load car brands');
    }
  }

  Future<void> addCarBrand(String name) async {
    final Uri uri = Uri.parse('$baseUrl/CarBrand');
    final headers = await AuthService.getAuthHeaders();
    headers['Content-Type'] = 'application/json';

    final body = json.encode({'name': name});

    final response = await http.post(uri, headers: headers, body: body);

    if (response.statusCode < 200 || response.statusCode >= 300) {
      throw Exception('Failed to add car brand: ${response.body}');
    }
  }

  Future<void> updateCarBrand(int id, String name) async {
    final Uri uri = Uri.parse('$baseUrl/CarBrand/$id');
    final headers = await AuthService.getAuthHeaders();
    headers['Content-Type'] = 'application/json';

    final body = json.encode({'name': name});

    final response = await http.put(uri, headers: headers, body: body);
    if (response.statusCode != 200) {
      throw Exception('Failed to update car brand');
    }
  }

  Future<void> deleteCarBrand(int id) async {
    final Uri uri = Uri.parse('$baseUrl/CarBrand/$id');
    final headers = await AuthService.getAuthHeaders();

    final response = await http.delete(uri, headers: headers);
    if (response.statusCode != 200) {
      throw Exception('Failed to delete car brand');
    }
  }
}
