import 'package:flutter/material.dart';
import 'package:intl/intl.dart';

String formatDate(String? date) {
  if (date == null) return "N/A";
  try {
    final parsedDate = DateTime.parse(date);
    return DateFormat("dd.MM.yyyy").format(parsedDate);
  } catch (_) {
    return "N/A";
  }
}

String FormatRemainingTime(DateTime expiryDate) {
  final now = DateTime.now();
  final difference = expiryDate.difference(now);

  final days = difference.inDays;
  final hours = difference.inHours % 24;
  final minutes = difference.inMinutes % 60;

  if (days > 0) {
    return 'Izdvojen još $days ${days == 1 ? 'dan' : 'dana'} i $hours ${hours == 1 ? 'sat' : 'sata'}.';
  } else if (hours > 0) {
    return 'Izdvojen još $hours ${hours == 1 ? 'sat' : 'sata'} i $minutes ${minutes == 1 ? 'minut' : 'minuta'}.';
  } else {
    return 'Izdvojen još $minutes ${minutes == 1 ? 'minut' : 'minuta'}.';
  }
}

String formatPrice(double? price) {
  if (price == null) return 'Nema cijenu';
  final NumberFormat formatter = NumberFormat("#,##0", "en_US");
  return '${formatter.format(price)} KM';
}

String formatPhoneNumber(String phoneNumber) {
  final RegExp regex = RegExp(r'(\+\d{3})(\d{2})(\d{3})(\d{3})');
  final Match? match = regex.firstMatch(phoneNumber);

  if (match != null) {
    final String countryCode = match.group(1) ?? '';
    final String areaCode = match.group(2) ?? '';
    final String firstPart = match.group(3) ?? '';
    final String secondPart = match.group(4) ?? '';
    return '$countryCode $areaCode $firstPart-$secondPart';
  }
  return phoneNumber;
}

class TimeHelper {
  static String timeAgo(DateTime date) {
    final now = DateTime.now();
    final difference = now.difference(date);

    if (difference.inDays < 1) {
      return "Danas";
    } else if (difference.inDays == 1) {
      return "Prije 1 dan";
    } else if (difference.inDays < 30) {
      return "Prije ${difference.inDays} dana";
    } else if (difference.inDays < 365) {
      int months = (difference.inDays / 30).floor();
      return "Prije $months ${months == 1 ? 'mjesec' : 'mjeseca'}";
    } else {
      int years = (difference.inDays / 365).floor();
      return "Prije $years ${years == 1 ? 'godinu' : 'godine'}";
    }
  }
}

Widget getAccountAgeBadge(String createdAt) {
  if (createdAt.isEmpty) return const SizedBox();

  DateTime createdDate = DateTime.parse(createdAt);
  int yearsActive = DateTime.now().year - createdDate.year;

  if (yearsActive < 1) return const SizedBox();

  IconData icon;
  Color color;
  String label;

  if (yearsActive >= 10) {
    icon = Icons.verified;
    color = Colors.blueAccent;
    label = "10+ godina";
  } else if (yearsActive >= 7) {
    icon = Icons.star;
    color = Colors.purple;
    label = "7+ godina";
  } else if (yearsActive >= 5) {
    icon = Icons.workspace_premium;
    color = Colors.orange;
    label = "5+ godina";
  } else if (yearsActive >= 3) {
    icon = Icons.military_tech;
    color = Colors.green;
    label = "3+ godine";
  } else {
    icon = Icons.access_time;
    color = Colors.grey;
    label = "1+ godina";
  }

  return Container(
    padding: const EdgeInsets.symmetric(horizontal: 8, vertical: 4),
    decoration: BoxDecoration(
      color: color.withOpacity(0.2),
      borderRadius: BorderRadius.circular(12),
    ),
    child: Row(
      mainAxisSize: MainAxisSize.min,
      children: [
        Icon(icon, size: 16, color: color),
        const SizedBox(width: 4),
        Text(
          label,
          style: TextStyle(
              color: color, fontSize: 12, fontWeight: FontWeight.bold),
        ),
      ],
    ),
  );
}
