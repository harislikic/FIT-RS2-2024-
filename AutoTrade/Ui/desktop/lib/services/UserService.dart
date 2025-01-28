import 'dart:convert';
import 'package:desktop_app/services/ApiConfig.dart';
import 'package:desktop_app/services/AuthService.dart';
import 'package:http/http.dart' as http;

class UserService {
  static Future<Map<String, dynamic>?> getUserProfile() async {
    try {
      final userId = await AuthService.getUserId();
      if (userId == null) return null;

      final headers = await AuthService.getAuthHeaders();
      final response = await http.get(
        Uri.parse('${ApiConfig.baseUrl}/User/$userId'),
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
      final String isAdminFilter = isAdmin != null ? '&IsAdmin=$isAdmin' : '';
      final uri = Uri.parse(
        '${ApiConfig.baseUrl}/User?Page=$page&PageSize=$pageSize${query != null ? '&FirstNameGTE=$query&UserName=$query' : ''}$isAdminFilter',
      );
      final response = await http.get(uri, headers: headers);

      if (response.statusCode == 200) {
        return jsonDecode(response.body);
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
        Uri.parse('${ApiConfig.baseUrl}/User/$adminId'),
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
