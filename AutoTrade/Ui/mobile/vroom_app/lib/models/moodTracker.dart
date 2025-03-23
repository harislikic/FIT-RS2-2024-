import 'package:vroom_app/models/user.dart';

class MoodTracker {
  final int id;
  final int? userId;
  final User? user;
  final String mood;
  final String description;
  final DateTime moodDate;
  final DateTime? createdAt;

  MoodTracker(
      {required this.id,
      this.userId,
      this.user,
      required this.mood,
      required this.description,
      required this.moodDate,
      this.createdAt});

  factory MoodTracker.fromJson(Map<String, dynamic> json) {
    return MoodTracker(
        id: json['id'] ?? 0,
        userId: json['userId'] ?? 0,
        user: json['user'] != null ? User.fromJson(json['user']) : null,
        mood: json['mood'],
        description: json['description'],
        moodDate: DateTime.parse(json['moodDate']),
        createdAt: DateTime.parse(json['createdAt']));
  }
}
