import 'dart:convert';
import 'package:desktop_app/services/config.dart';
import 'package:http/http.dart' as http;
import 'package:shared_preferences/shared_preferences.dart';

class AuthService {
  
  static Future<bool> login(String username, String password) async {
    try {
      final response = await http.post(
        Uri.parse('$baseUrl/User/login/admin'),
        headers: {'Content-Type': 'application/json'},
        body: jsonEncode({
          'username': username,
          'password': password,
        }),
      );

      if (response.statusCode == 200) {
        final responseData = jsonDecode(response.body);
        final userId = responseData['id'];

        await saveCredentials(username, password, userId);
        return true;
      } else {
        return false;
      }
    } catch (e) {
      print('Greška tokom prijave: $e');
      return false;
    }
  }

  static Future<void> saveCredentials(
      String username, String password, int userId) async {
    final prefs = await SharedPreferences.getInstance();
    await prefs.setString('username', username);
    await prefs.setString('password', password);
    await prefs.setInt('userId', userId);
  }

  static Future<String?> getUsername() async {
    final prefs = await SharedPreferences.getInstance();
    return prefs.getString('username');
  }

  static Future<String?> getPassword() async {
    final prefs = await SharedPreferences.getInstance();
    return prefs.getString('password');
  }

  static Future<void> logout() async {
    final prefs = await SharedPreferences.getInstance();
    await prefs.remove('username');
    await prefs.remove('password');
    await prefs.remove('userId');
  }

  static Future<bool> checkIfUserIsLoggedIn() async {
    final userId = await AuthService.getUserId();
    return userId != null;
  }

  static Future<int?> getUserId() async {
    final prefs = await SharedPreferences.getInstance();
    return prefs.getInt('userId');
  }

  static Future<Map<String, String>> getAuthHeaders() async {
    final username = await getUsername();
    final password = await getPassword();

    if (username != null && password != null) {
      final basicAuth =
          'Basic ' + base64Encode(utf8.encode('$username:$password'));
      return {'Authorization': basicAuth};
    }
    return {};
  }
}
