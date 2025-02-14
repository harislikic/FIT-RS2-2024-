import 'dart:convert';

import 'package:desktop_app/models/comment.dart';
import 'package:desktop_app/services/AuthService.dart';
import 'package:desktop_app/services/config.dart';
import 'package:http/http.dart' as http;

class CommentService {
  Future<List<Comment>> fetchCommentsByAutomobileId(int automobileId) async {
    final String url = '$baseUrl/Comment/automobile/$automobileId';

    final response = await http.get(Uri.parse(url));

    if (response.statusCode == 200) {
      final data = json.decode(response.body);

      if (data is List) {
        return data.map((json) => Comment.fromJson(json)).toList();
      } else {
        return [];
      }
    } else {
      throw Exception('Failed to load comments');
    }
  }

  Future<Map<String, dynamic>> fetchAllComments({
    int? userId,
    int? automobileId,
    int page = 0,
    int pageSize = 25,
  }) async {
    final String urlBase = '$baseUrl/Comment/search';

    final Map<String, String> queryParams = {
      'Page': page.toString(),
      'PageSize': pageSize.toString(),
    };


    if (userId != null) {
      queryParams['UserId'] = userId.toString();
    }
    if (automobileId != null) {
      queryParams['AutomobileId'] = automobileId.toString();
    }
    final Uri url = Uri.parse(urlBase).replace(queryParameters: queryParams);


    final response = await http.get(url);

    if (response.statusCode == 200) {
      final data = json.decode(response.body);

      if (data is Map<String, dynamic>) {
        final totalCount = data['totalCount'] ?? 0;
        final comments = (data['comments'] as List?)
                ?.map((json) => Comment.fromJson(json))
                .toList() ??
            [];

        return {
          'totalCount': totalCount,
          'comments': comments,
        };
      } else {
        return {
          'totalCount': 0,
          'comments': [],
        };
      }
    } else {
      throw Exception('Failed to load comments');
    }
  }

  Future<void> deleteComment({
    required int commentId,
  }) async {
    final String url = '$baseUrl/Comment/$commentId';
    final headers = await AuthService.getAuthHeaders();

    final response = await http.delete(
      Uri.parse(url),
      headers: headers,
    );

    if (response.statusCode == 200) {
      print('Comment deleted successfully.');
    } else {
      throw Exception(
          'Failed to delete comment. Status Code: ${response.statusCode}');
    }
  }
}
