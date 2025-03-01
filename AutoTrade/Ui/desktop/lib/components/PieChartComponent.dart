import 'package:flutter/material.dart';
import 'package:syncfusion_flutter_charts/charts.dart';
import 'package:desktop_app/models/ChartModels.dart';
import '../helpers/ColorHelper.dart';

class PieChartComponent extends StatelessWidget {
  final List<dynamic> transactions;
  final String chartType;

  PieChartComponent({required this.transactions, required this.chartType});

  @override
  Widget build(BuildContext context) {
    Map<String, double> dataMap = _generateData();
    int totalTransactions = transactions.length;
    int succeededTransactions = transactions
        .where(
            (transaction) => transaction['status'].toLowerCase() == 'succeeded')
        .length;

    List<PieChartData> chartData = dataMap.entries.map((entry) {
      return PieChartData(
          entry.key, entry.value, ColorHelper.getColor(entry.key));
    }).toList();

    return Card(
      elevation: 4,
      child: Padding(
        padding: const EdgeInsets.all(8.0),
        child: Column(
          children: [
            Text(
              chartType == 'status'
                  ? 'Distribucija iznosa po statusu'
                  : 'Distribucija kartičnih brendova',
              style: const TextStyle(fontSize: 16, fontWeight: FontWeight.bold),
            ),
            const SizedBox(height: 8),
            if (chartType == 'status') ...[
              Text(
                'Ukupno transakcija: $totalTransactions',
                style:
                    const TextStyle(fontSize: 14, fontWeight: FontWeight.bold),
              ),
              Text(
                'Uspješnih transakcija: $succeededTransactions',
                style: const TextStyle(
                    fontSize: 14,
                    color: Colors.green,
                    fontWeight: FontWeight.bold),
              ),
              const SizedBox(height: 10),
            ],
            Expanded(
              child: SfCircularChart(
                legend: const Legend(
                    isVisible: true, position: LegendPosition.bottom),
                tooltipBehavior: TooltipBehavior(enable: true),
                series: <CircularSeries>[
                  PieSeries<PieChartData, String>(
                    dataSource: chartData,
                    xValueMapper: (PieChartData data, _) => data.category,
                    yValueMapper: (PieChartData data, _) => data.amount,
                    pointColorMapper: (PieChartData data, _) => data.color,
                    dataLabelSettings: const DataLabelSettings(isVisible: true),
                  )
                ],
              ),
            ),
          ],
        ),
      ),
    );
  }

  Map<String, double> _generateData() {
    Map<String, double> dataMap = {};

    if (chartType == 'status') {
      for (var transaction in transactions) {
        String status = transaction['status'].toLowerCase();
        double amount = (transaction['amount'] / 100).toDouble();
        dataMap[status] = (dataMap[status] ?? 0) + amount;
      }
    } else if (chartType == 'card_brand') {
      for (var transaction in transactions) {
        if (transaction['payment_method_details'] != null &&
            transaction['payment_method_details']['card'] != null) {
          String brand = transaction['payment_method_details']['card']['brand']
              .toString()
              .toUpperCase();
          dataMap[brand] = (dataMap[brand] ?? 0) + 1;
        }
      }
    }

    return dataMap;
  }
}
