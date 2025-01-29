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
                  child: Column(
                    children: [
                      Expanded(child: _buildLineChart(transactions)),
                      SizedBox(height: 16),
                      Expanded(
                        child: Row(
                          children: [
                            Expanded(child: _buildPieChart(transactions)),
                            SizedBox(width: 16),
                            Expanded(
                                child: _buildCardBrandPieChart(transactions)),
                          ],
                        ),
                      ),
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
      DateTime date =
          DateTime.fromMillisecondsSinceEpoch(transaction['created'] * 1000);
      int day = date.day;
      dailyCounts[day] = (dailyCounts[day] ?? 0) + 1;
    }

    List<int> sortedDays = dailyCounts.keys.toList()..sort();
    List<FlSpot> spots = sortedDays.map((day) {
      return FlSpot(day.toDouble(), dailyCounts[day]!.toDouble());
    }).toList();

    return Card(
      elevation: 4,
      child: Padding(
        padding: const EdgeInsets.all(8.0),
        child: LineChart(
          LineChartData(
            lineBarsData: [
              LineChartBarData(
                spots: spots,
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
                  reservedSize: 22,
                  getTitlesWidget: (value, meta) {
                    int day = value.toInt();
                    return _formatDayLabel(day, sortedDays);
                  },
                  interval: sortedDays.length > 7
                      ? (sortedDays.length / 7).floorToDouble()
                      : 1,
                ),
              ),
              leftTitles: AxisTitles(
                sideTitles: SideTitles(showTitles: true, reservedSize: 40),
              ),
            ),
            borderData: FlBorderData(show: false),
            gridData: FlGridData(show: true),
          ),
        ),
      ),
    );
  }

  /// 📅 Formats x-axis labels to prevent cluttering
  Widget _formatDayLabel(int day, List<int> sortedDays) {
    if (sortedDays.length > 7) {
      // Show only key dates
      if (sortedDays.indexOf(day) % (sortedDays.length ~/ 7) != 0) {
        return const SizedBox(); // Skip some labels to prevent clutter
      }
    }
    return Text(
      'Dan $day',
      style: TextStyle(fontSize: 12, fontWeight: FontWeight.w500),
    );
  }

  /// 🥧 PieChart - Distribucija ukupnih iznosa po statusu transakcija
  Widget _buildPieChart(List<dynamic> transactions) {
    Map<String, double> statusAmounts = {};

    for (var transaction in transactions) {
      String status = transaction['status'].toLowerCase();
      double amount = (transaction['amount'] / 100).toDouble();
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
                  sectionsSpace: 4,
                  centerSpaceRadius: 40,
                ),
              ),
            ),
          ],
        ),
      ),
    );
  }

  /// 🥧 PieChart - Kartični brendovi (Visa, Mastercard, itd.)
  Widget _buildCardBrandPieChart(List<dynamic> transactions) {
    Map<String, double> cardBrandCounts = {};

    for (var transaction in transactions) {
      if (transaction['payment_method_details'] != null &&
          transaction['payment_method_details']['card'] != null) {
        String brand = transaction['payment_method_details']['card']['brand']
            .toString()
            .toUpperCase();
        cardBrandCounts[brand] = (cardBrandCounts[brand] ?? 0) + 1;
      }
    }

    return Card(
      elevation: 4,
      child: Padding(
        padding: const EdgeInsets.all(8.0),
        child: Column(
          children: [
            Text(
              'Distribucija kartičnih brendova',
              style: TextStyle(fontSize: 16, fontWeight: FontWeight.bold),
            ),
            SizedBox(height: 10),
            Expanded(
              child: PieChart(
                PieChartData(
                  sections: cardBrandCounts.entries.map((entry) {
                    return PieChartSectionData(
                      title: '${entry.key}\n${entry.value.toStringAsFixed(0)}',
                      value: entry.value,
                      radius: 50,
                      titleStyle: TextStyle(
                        fontSize: 12,
                        fontWeight: FontWeight.bold,
                        color: Colors.white,
                      ),
                      color: _getCardBrandColor(entry.key),
                    );
                  }).toList(),
                  sectionsSpace: 4,
                  centerSpaceRadius: 40,
                ),
              ),
            ),
          ],
        ),
      ),
    );
  }
}

/// 🎨 Assign colors based on transaction status
Color _getStatusColor(String status) {
  switch (status) {
    case 'succeeded':
      return Colors.greenAccent.shade700;
    case 'failed':
      return Colors.redAccent.shade700;
    case 'pending':
      return Colors.orangeAccent.shade700;
    case 'canceled':
      return Colors.grey.shade700;
    case 'requires_action':
      return Colors.blue.shade700;
    default:
      return Colors.blueGrey.shade600; // Default color for unknown statuses
  }
}

/// 🎨 Assign colors for different card brands
Color _getCardBrandColor(String brand) {
  switch (brand) {
    case 'VISA':
      return Colors.blue.shade700;
    case 'MASTERCARD':
      return Colors.red.shade700;
    case 'AMEX':
      return Colors.cyan.shade700;
    case 'DISCOVER':
      return Colors.orange.shade700;
    case 'JCB':
      return Colors.purple.shade700;
    case 'DINERS CLUB':
      return Colors.green.shade700;
    default:
      return Colors.grey.shade700; // Default color for unknown brands
  }
}
