import 'dart:convert';
import 'package:vroom_app/models/moodTracker.dart';
import 'package:vroom_app/services/AuthService.dart';

import 'package:vroom_app/services/config.dart';
import 'package:http/http.dart' as http;

class MoodTrackerService {
  static Future<List<MoodTracker>> getMoodTrackers(
      String? mood, int? userId, String? startDate, String? endDate) async {
    try {
      final queryParams = {
        if (mood != null) 'mood': mood,
        if (userId != null) 'userId': userId.toString(),
        if (startDate != null) 'startDate': startDate,
        if (endDate != null) 'endDate': endDate,
      };

      final url = Uri.parse('$baseUrl/MoodTracker')
          .replace(queryParameters: {...queryParams});
      print('url : ${url}');

      final response = await http.get(url);

      if (response.statusCode == 200) {
        final data = json.decode(response.body);
        if (data is Map<String, dynamic> && data['data'] is List) {
          final items = data['data'] as List;
          return items.map((json) => MoodTracker.fromJson(json)).toList();
        } else {
          return [];
        }
      } else {
        throw Exception(
            'Failed to fetch mood trackers: ${response.statusCode}');
      }
    } catch (e) {
      throw Exception('Failed to fetch mood trackers ${e}');
    }
  }

  static Future<void> addMoodTracker({
    required int userId,
    required String mood,
    required String description,
    required DateTime moodDate,
  }) async {
    final headers = await AuthService.getAuthHeaders();
    headers['Content-Type'] = 'application/json';
    final url = Uri.parse('$baseUrl/MoodTracker');

    print("📤 Slanje podataka: userId=$userId, mood=$mood");

    final response = await http.post(
      url,
      headers: headers,
      body: jsonEncode({
        'userId': userId,
        'mood': mood,
        'description': description,
        'moodDate': moodDate.toIso8601String(),
      }),
    );

    print("📤 json ${response.body}");

    if (response.statusCode != 200 && response.statusCode != 201) {
      final message = response.body;
      throw Exception(message.isNotEmpty ? message : 'Greška pri dodavanju.');
    }
  }
}
