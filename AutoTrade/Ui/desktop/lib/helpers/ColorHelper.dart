import 'package:flutter/material.dart';

class ColorHelper {
  static Color getColor(String key) {
    Map<String, Color> colorMap = {
      'succeeded': Colors.greenAccent.shade700,
      'failed': Colors.redAccent.shade700,
      'pending': Colors.orangeAccent.shade700,
      'canceled': Colors.grey.shade700,
      'requires_action': Colors.blue.shade700,
      'VISA': Colors.blue.shade700,
      'MASTERCARD': Colors.red.shade700,
      'AMEX': Colors.cyan.shade700,
      'DISCOVER': Colors.orange.shade700,
      'JCB': Colors.purple.shade700,
      'DINERS CLUB': Colors.green.shade700,
    };

    return colorMap[key] ?? Colors.grey.shade600;
  }
}
