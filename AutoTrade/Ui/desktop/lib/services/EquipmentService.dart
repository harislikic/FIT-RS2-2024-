import 'dart:convert';
import 'package:desktop_app/models/equipment.dart';
import 'package:desktop_app/services/AuthService.dart';
import 'package:desktop_app/services/config.dart';
import 'package:http/http.dart' as http;

class EquipmentService {
  Future<List<Equipment>> fetchEquipments(
      {int page = 0, int pageSize = 100}) async {
    const String url = '$baseUrl/Equipment';

    final Uri uri = Uri.parse(url).replace(queryParameters: {
      'Page': page.toString(),
      'PageSize': pageSize.toString(),
    });

    final response = await http.get(uri);

    if (response.statusCode == 200) {
      final data = json.decode(response.body);

      if (data['data'] != null && data['data'] is List) {
        final List<dynamic> items = data['data'];
        return items.map((json) => Equipment.fromJson(json)).toList();
      } else {
        return [];
      }
    } else {
      throw Exception('Failed to load equipments types');
    }
  }

  Future<void> addEquipment(String name) async {
    final Uri uri = Uri.parse('$baseUrl/Equipment');
    final headers = await AuthService.getAuthHeaders();
    headers['Content-Type'] = 'application/json';

    final body = json.encode({'name': name});

    final response = await http.post(uri, headers: headers, body: body);

    if (response.statusCode < 200 || response.statusCode >= 300) {
      throw Exception('Failed to add Equipment: ${response.body}');
    }
  }

  Future<void> updateEquipment(int id, String name) async {
    final Uri uri = Uri.parse('$baseUrl/Equipment/$id');
    final headers = await AuthService.getAuthHeaders();
    headers['Content-Type'] = 'application/json';

    final body = json.encode({'name': name});

    final response = await http.put(uri, headers: headers, body: body);
    if (response.statusCode != 200) {
      throw Exception('Failed to update Equipment');
    }
  }

  Future<void> deleteEquipment(int id) async {
    final Uri uri = Uri.parse('$baseUrl/Equipment/$id');
    final headers = await AuthService.getAuthHeaders();

    final response = await http.delete(uri, headers: headers);
    if (response.statusCode != 200) {
      throw Exception('Failed to delete Equipment');
    }
  }
}
