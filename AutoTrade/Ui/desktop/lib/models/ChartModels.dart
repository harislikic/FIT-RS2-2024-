import 'dart:ui';

class StackedChartData {
  final String currency;
  final double revenue;
  final double count;

  StackedChartData(this.currency, this.revenue, this.count);
}

class ChartData {
  final String month;
  final double revenue;
  final int count;

  ChartData(this.month, this.revenue, this.count);
}

class MonthlyChartData {
  final String month;
  final double revenue;
  final int count;

  MonthlyChartData(this.month, this.revenue, this.count);
}

class CurrencyChartData {
  final String currency;
  final double amount;

  CurrencyChartData(this.currency, this.amount);
}

class PieChartData {
  final String category;
  final double amount;
  final Color color;

  PieChartData(this.category, this.amount, this.color);
}
