import 'package:desktop_app/models/PaymentTransaction.dart';

class PaymentResponse {
  final int totalRecords;
  final double totalAmount;
  final List<PaymentTransaction> transactions;

  PaymentResponse({
    required this.totalRecords,
    required this.totalAmount,
    required this.transactions,
  });

  factory PaymentResponse.fromJson(Map<String, dynamic> json) {
    return PaymentResponse(
      totalRecords: json['totalRecords'],
      totalAmount: (json['totalAmount'] as num)
          .toDouble(),
      transactions: (json['transactions'] as List)
          .map((t) => PaymentTransaction.fromJson(t))
          .toList(),
    );
  }
}
