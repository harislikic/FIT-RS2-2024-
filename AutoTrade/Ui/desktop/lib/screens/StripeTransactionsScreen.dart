import 'package:desktop_app/helpers/StripePdfHelper.dart';
import 'package:flutter/material.dart';
import 'package:syncfusion_flutter_charts/charts.dart';
import 'package:open_file/open_file.dart';

import '../components/PieChartComponent.dart';
import 'package:desktop_app/models/ChartModels.dart';
import 'package:desktop_app/services/PaymentService.dart';

import 'package:desktop_app/helpers/DateHelper.dart';

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

  Future<void> _generateAndShowPdf(List<dynamic> transactions) async {
    try {
      final pdfPath =
          await StripePdfHelper.generateStripeTransactionsPdf(transactions);

      if (!mounted) return;

      showDialog(
        context: context,
        builder: (context) => AlertDialog(
          title: const Text("PDF generisan!"),
          content:
              SelectableText("PDF izvještaj je sačuvan na lokaciji:\n$pdfPath"),
          actions: [
            TextButton(
              onPressed: () => Navigator.pop(context),
              child: const Text("Zatvori"),
            ),
            TextButton(
              onPressed: () {
                OpenFile.open(pdfPath);
              },
              child: const Text("Otvori PDF"),
            ),
          ],
        ),
      );
    } catch (e) {
      print("Greška prilikom kreiranja PDF-a: $e");
      ScaffoldMessenger.of(context).showSnackBar(
        SnackBar(content: Text("Neuspješno kreiranje PDF-a: $e")),
      );
    }
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text('Stripe Analitika'),
      ),
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
                Tooltip(
                  message: "Kliknite za preuzimanje izvještaja",
                  child: ElevatedButton.icon(
                    icon: Icon(Icons.download),
                    label: Text("Skini PDF"),
                    onPressed: () async {
                      // Just call the helper function
                      _generateAndShowPdf(transactions);
                    },
                  ),
                ),
                const SizedBox(height: 20),
                _buildSummary(transactions),
                const SizedBox(height: 20),
                Expanded(
                  child: Column(
                    children: [
                      Expanded(child: _buildColumnChart(transactions)),
                      const SizedBox(height: 16),
                      Expanded(
                        child: Row(
                          children: [
                            Expanded(
                                child: PieChartComponent(
                                    transactions: transactions,
                                    chartType: 'status')),
                            const SizedBox(width: 16),
                            Expanded(
                                child: PieChartComponent(
                                    transactions: transactions,
                                    chartType: 'card_brand')),
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

  Widget _buildSummary(List<dynamic> transactions) {
    int totalTransactions = transactions.length;
    Map<String, Map<String, double>> currencyStats = {};

    for (var transaction in transactions) {
      String currency = transaction['currency'].toUpperCase();
      double amount = (transaction['amount'] / 100).toDouble();

      if (!currencyStats.containsKey(currency)) {
        currencyStats[currency] = {'amount': 0, 'count': 0};
      }

      currencyStats[currency]!['amount'] =
          (currencyStats[currency]!['amount'] ?? 0) + amount;
      currencyStats[currency]!['count'] =
          (currencyStats[currency]!['count'] ?? 0) + 1;
    }

    List<StackedChartData> chartData = currencyStats.entries.map((entry) {
      return StackedChartData(
          entry.key, entry.value['amount']!, entry.value['count']!);
    }).toList();

    return Card(
      elevation: 4,
      child: Padding(
        padding: const EdgeInsets.all(8.0),
        child: Column(
          crossAxisAlignment: CrossAxisAlignment.start,
          children: [
            Text(
              'Ukupan broj transakcija: $totalTransactions',
              style: const TextStyle(fontSize: 18, fontWeight: FontWeight.bold),
            ),
            const SizedBox(height: 10),
            SizedBox(
              height: 250,
              child: SfCartesianChart(
                primaryXAxis: CategoryAxis(),
                title: ChartTitle(text: 'Prihod i broj transakcija po valuti'),
                legend: const Legend(isVisible: true),
                series: <ChartSeries>[
                  StackedColumnSeries<StackedChartData, String>(
                    dataSource: chartData,
                    xValueMapper: (StackedChartData data, _) => data.currency,
                    yValueMapper: (StackedChartData data, _) => data.revenue,
                    name: 'Prihod',
                    color: Colors.blueAccent,
                    dataLabelSettings: const DataLabelSettings(isVisible: true),
                  ),
                  StackedColumnSeries<StackedChartData, String>(
                    dataSource: chartData,
                    xValueMapper: (StackedChartData data, _) => data.currency,
                    yValueMapper: (StackedChartData data, _) => data.count,
                    name: 'Transakcije',
                    color: Colors.orangeAccent,
                    dataLabelSettings: const DataLabelSettings(isVisible: true),
                  ),
                ],
              ),
            ),
          ],
        ),
      ),
    );
  }

  Widget _buildColumnChart(List<dynamic> transactions) {
    Map<String, Map<String, double>> monthlyStats = {};

    for (var transaction in transactions) {
      DateTime date =
          DateTime.fromMillisecondsSinceEpoch(transaction['created'] * 1000);
      int month = date.month;
      int year = date.year;
      String key = "$month/$year";

      if (!monthlyStats.containsKey(key)) {
        monthlyStats[key] = {'count': 0, 'totalAmount': 0};
      }

      monthlyStats[key]!['count'] = monthlyStats[key]!['count']! + 1;
      monthlyStats[key]!['totalAmount'] =
          monthlyStats[key]!['totalAmount']! + (transaction['amount'] / 100);
    }

    List<ChartData> chartData = monthlyStats.entries.map((entry) {
      List<String> parts = entry.key.split('/');
      String month = DateHelper.getMonthName(parts[0]);
      String year = parts[1];

      return ChartData(
        "$month $year",
        entry.value['totalAmount']!,
        entry.value['count']!.toInt(),
      );
    }).toList();

    return Card(
      elevation: 4,
      child: Padding(
        padding: const EdgeInsets.all(8.0),
        child: SfCartesianChart(
          primaryXAxis: CategoryAxis(),
          title: ChartTitle(text: 'Mjesečne transakcije i prihod'),
          legend: const Legend(isVisible: true),
          tooltipBehavior: TooltipBehavior(enable: true),
          series: <ChartSeries<ChartData, String>>[
            ColumnSeries<ChartData, String>(
              name: 'Ukupni prihod',
              dataSource: chartData,
              xValueMapper: (ChartData data, _) => data.month,
              yValueMapper: (ChartData data, _) => data.revenue,
              dataLabelSettings: const DataLabelSettings(isVisible: true),
              color: Colors.blueAccent,
            ),
            LineSeries<ChartData, String>(
              name: 'Ukupan broj transakcija',
              dataSource: chartData,
              xValueMapper: (ChartData data, _) => data.month,
              yValueMapper: (ChartData data, _) => data.count,
              markerSettings: const MarkerSettings(isVisible: true),
              dataLabelSettings: const DataLabelSettings(isVisible: true),
              color: Colors.orange,
            ),
          ],
        ),
      ),
    );
  }
}
