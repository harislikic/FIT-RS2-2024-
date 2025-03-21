import 'dart:convert';
import 'package:desktop_app/models/carModel.dart';
import 'package:desktop_app/services/AuthService.dart';
import 'package:desktop_app/services/config.dart';
import 'package:http/http.dart' as http;

class CarModelService {
  Future<List<CarModel>> fetchCarModels(
      {int page = 0, int pageSize = 50}) async {
    const String url = '$baseUrl/CarModel';

    final Uri uri = Uri.parse(url).replace(queryParameters: {
      'Page': page.toString(),
      'PageSize': pageSize.toString(),
    });

    final response = await http.get(uri);

    if (response.statusCode == 200) {
      final data = json.decode(response.body);

      if (data['data'] != null && data['data'] is List) {
        final List<dynamic> items = data['data'];
        return items.map((json) => CarModel.fromJson(json)).toList();
      } else {
        return [];
      }
    } else {
      throw Exception('Failed to load car models');
    }
  }

  Future<void> addCarModel(String name) async {
    final Uri uri = Uri.parse('$baseUrl/CarModel');
    final headers = await AuthService.getAuthHeaders();
    headers['Content-Type'] = 'application/json';

    final body = json.encode({'name': name});

    final response = await http.post(uri, headers: headers, body: body);

    if (response.statusCode < 200 || response.statusCode >= 300) {
      throw Exception('Failed to add car model: ${response.body}');
    }
  }

  Future<void> updateCarModel(int id, String name) async {
    final Uri uri = Uri.parse('$baseUrl/CarModel/$id');
    final headers = await AuthService.getAuthHeaders();
    headers['Content-Type'] = 'application/json';

    final body = json.encode({'name': name});

    final response = await http.put(uri, headers: headers, body: body);
    if (response.statusCode != 200) {
      throw Exception('Failed to update car model');
    }
  }

  Future<void> deleteCarModel(int id) async {
    final Uri uri = Uri.parse('$baseUrl/CarModel/$id');
    final headers = await AuthService.getAuthHeaders();

    final response = await http.delete(uri, headers: headers);
    if (response.statusCode != 200) {
      throw Exception('Failed to delete car model');
    }
  }
}
