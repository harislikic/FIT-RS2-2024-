class PaymentTransaction {
  final int transactionId;
  final String paymentId;
  final double amount;
  final String currency;
  final String status;
  final DateTime createdAt;
  final DateTime updatedAt;

  PaymentTransaction({
    required this.transactionId,
    required this.paymentId,
    required this.amount,
    required this.currency,
    required this.status,
    required this.createdAt,
    required this.updatedAt,
  });

  factory PaymentTransaction.fromJson(Map<String, dynamic> json) {
    return PaymentTransaction(
      transactionId: json['transactionId'],
      paymentId: json['paymentId'],
      amount: (json['amount'] as num).toDouble(),
      currency: json['currency'],
      status: json['status'],
      createdAt: DateTime.parse(json['createdAt']),
      updatedAt: DateTime.parse(json['updatedAt']),
    );
  }
}
