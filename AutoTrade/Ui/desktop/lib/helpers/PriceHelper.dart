import 'package:intl/intl.dart';

String formatPrice(double price) {
  final formatCurrency = NumberFormat("#,##0", "bs");
  return "${formatCurrency.format(price)} KM";
}
