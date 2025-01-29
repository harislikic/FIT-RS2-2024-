import 'package:flutter/material.dart';
import 'package:fl_chart/fl_chart.dart';
import 'package:desktop_app/services/PaymentService.dart';

class StripeTransactionsScreen extends StatefulWidget {
  @override
  _StripeTransactionsScreenState createState() =>
      _StripeTransactionsScreenState();
}

class _StripeTransactionsScreenState extends State<StripeTransactionsScreen> {
  final PaymentService _paymentService = PaymentService();
  Future<List<dynamic>>? _stripeData;

  @override
  void initState() {
    super.initState();
    _fetchStripeData();
  }

  void _fetchStripeData() {
    setState(() {
      _stripeData = _paymentService.getStripeTransactions();
    });
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(title: Text('Stripe Analitika')),
      body: Padding(
        padding: const EdgeInsets.all(16.0),
        child: FutureBuilder<List<dynamic>>(
          future: _stripeData,
          builder: (context, snapshot) {
            if (snapshot.connectionState == ConnectionState.waiting) {
              return Center(child: CircularProgressIndicator());
            } else if (snapshot.hasError) {
              return Center(child: Text('Greška: ${snapshot.error}'));
            } else if (!snapshot.hasData || snapshot.data!.isEmpty) {
              return Center(child: Text('Nema pronađenih transakcija'));
            }

            final transactions = snapshot.data!;
            return Column(
              crossAxisAlignment: CrossAxisAlignment.start,
              children: [
                _buildSummary(transactions),
                SizedBox(height: 20),
                Expanded(
                  child: Row(
                    children: [
                      Expanded(child: _buildLineChart(transactions)),
                      SizedBox(width: 16),
                      Expanded(child: _buildPieChart(transactions)),
                    ],
                  ),
                ),
              ],
            );
          },
        ),
      ),
    );
  }

  /// 📌 Prikaz ključnih podataka
  Widget _buildSummary(List<dynamic> transactions) {
    int totalTransactions = transactions.length;
    Map<String, double> currencyTotals = {};

    for (var transaction in transactions) {
      String currency = transaction['currency'].toUpperCase();
      double amount = (transaction['amount'] / 100).toDouble();
      currencyTotals[currency] = (currencyTotals[currency] ?? 0) + amount;
    }

    return Card(
      elevation: 4,
      child: Padding(
        padding: const EdgeInsets.all(8.0),
        child: Column(
          crossAxisAlignment: CrossAxisAlignment.start,
          children: [
            Text(
              'Ukupan broj transakcija: $totalTransactions',
              style: TextStyle(fontSize: 18, fontWeight: FontWeight.bold),
            ),
            ...currencyTotals.entries.map((entry) => Text(
                  '${entry.key}: ${entry.value.toStringAsFixed(2)}',
                  style: TextStyle(fontSize: 16, fontWeight: FontWeight.bold),
                )),
          ],
        ),
      ),
    );
  }

  /// 📊 LineChart - Broj transakcija po danima
  Widget _buildLineChart(List<dynamic> transactions) {
    Map<int, int> dailyCounts = {};

    for (var transaction in transactions) {
      int day =
          DateTime.fromMillisecondsSinceEpoch(transaction['created'] * 1000)
              .day;
      dailyCounts[day] = (dailyCounts[day] ?? 0) + 1;
    }

    return Card(
      elevation: 4,
      child: Padding(
        padding: const EdgeInsets.all(8.0),
        child: LineChart(
          LineChartData(
            lineBarsData: [
              LineChartBarData(
                spots: dailyCounts.entries.map((entry) {
                  return FlSpot(entry.key.toDouble(), entry.value.toDouble());
                }).toList(),
                isCurved: true,
                gradient: LinearGradient(
                  colors: [Colors.deepPurple, Colors.purpleAccent],
                  begin: Alignment.centerLeft,
                  end: Alignment.centerRight,
                ),
                barWidth: 3,
                belowBarData: BarAreaData(
                  show: true,
                  gradient: LinearGradient(
                    colors: [
                      Colors.deepPurple.withOpacity(0.3),
                      Colors.purpleAccent.withOpacity(0.1)
                    ],
                    begin: Alignment.topCenter,
                    end: Alignment.bottomCenter,
                  ),
                ),
              ),
            ],
            titlesData: FlTitlesData(
              bottomTitles: AxisTitles(
                sideTitles: SideTitles(
                  showTitles: true,
                  getTitlesWidget: (value, _) => Text(
                    'Dan ${value.toInt()}',
                    style: TextStyle(fontSize: 12),
                  ),
                ),
              ),
              leftTitles: AxisTitles(sideTitles: SideTitles(showTitles: true)),
            ),
            borderData: FlBorderData(show: false),
            gridData: FlGridData(show: true),
          ),
        ),
      ),
    );
  }

  /// 🥧 PieChart - Distribucija ukupnih iznosa po statusu transakcija
  Widget _buildPieChart(List<dynamic> transactions) {
    Map<String, double> statusAmounts = {};

    for (var transaction in transactions) {
      String status = transaction['status'].toLowerCase();
      double amount = (transaction['amount'] / 100)
          .toDouble(); // Pretvaramo iz centi u glavnu valutu
      statusAmounts[status] = (statusAmounts[status] ?? 0) + amount;
    }

    return Card(
      elevation: 4,
      child: Padding(
        padding: const EdgeInsets.all(8.0),
        child: Column(
          children: [
            Text(
              'Distribucija iznosa po statusu',
              style: TextStyle(fontSize: 16, fontWeight: FontWeight.bold),
            ),
            SizedBox(height: 10),
            Expanded(
              child: PieChart(
                PieChartData(
                  sections: statusAmounts.entries.map((entry) {
                    return PieChartSectionData(
                      title: '${entry.key}\n${entry.value.toStringAsFixed(2)}',
                      value: entry.value,
                      radius: 50,
                      titleStyle: TextStyle(
                        fontSize: 12,
                        fontWeight: FontWeight.bold,
                        color: Colors.white,
                      ),
                      color: _getStatusColor(entry.key),
                    );
                  }).toList(),
                  sectionsSpace: 4, // Povećavamo prostor između segmenata
                  centerSpaceRadius:
                      40, // Ostavljamo mesto u centru za bolji izgled
                ),
              ),
            ),
          ],
        ),
      ),
    );
  }

  /// 🎨 Boje za status transakcija
  /// 🎨 Definisanje boja za svaki status transakcije
  Color _getStatusColor(String status) {
    switch (status) {
      case 'succeeded':
        return Colors.greenAccent.shade700;
      case 'failed':
        return Colors.redAccent.shade700;
      case 'pending':
        return Colors.orangeAccent.shade700;
      default:
        return Colors.blueGrey.shade600;
    }
  }
}
