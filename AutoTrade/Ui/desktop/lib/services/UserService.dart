import 'dart:convert';
import 'package:desktop_app/services/AuthService.dart';
import 'package:desktop_app/services/config.dart';
import 'package:http/http.dart' as http;

class UserService {
  static Future<Map<String, dynamic>?> getUserProfile() async {
    try {
      final userId = await AuthService.getUserId();
      if (userId == null) return null;

      final headers = await AuthService.getAuthHeaders();
      final response = await http.get(
        Uri.parse('$baseUrl/User/$userId'),
        headers: headers,
      );

      if (response.statusCode == 200) {
        return jsonDecode(response.body);
      } else {
        throw Exception('Failed to fetch user profile: ${response.statusCode}');
      }
    } catch (e) {
      throw Exception('Error while fetching user profile: $e');
    }
  }

  static Future<Map<String, dynamic>> getAllAdmins({
    int page = 0,
    int pageSize = 25,
    String? query,
    bool? isAdmin,
  }) async {
    try {
      final headers = await AuthService.getAuthHeaders();

      final Map<String, String> queryParams = {
        "Page": page.toString(),
        "PageSize": pageSize.toString(),
        if (query != null) "FullNameQuery": query,
        if (isAdmin != null) "IsAdmin": isAdmin.toString(),
      };

      final uri = Uri.parse('$baseUrl/User')
          .replace(queryParameters: queryParams);

      final response = await http.get(uri, headers: headers);

      if (response.statusCode == 200) {
        return jsonDecode(response.body) as Map<String, dynamic>;
      } else {
        throw Exception('Failed to fetch admins: ${response.statusCode}');
      }
    } catch (e) {
      throw Exception('Error while fetching admins: $e');
    }
  }

  static Future<void> deleteAdmin(int adminId) async {
    try {
      final headers = await AuthService.getAuthHeaders();
      final response = await http.delete(
        Uri.parse('$baseUrl/User/$adminId'),
        headers: headers,
      );

      if (response.statusCode != 200) {
        throw Exception('Failed to delete admin: ${response.statusCode}');
      }
    } catch (e) {
      throw Exception('Error while deleting admin: $e');
    }
  }
}
