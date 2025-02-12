import 'package:desktop_app/models/PaymentResponse.dart';
import 'package:desktop_app/services/PaymentService.dart';
import 'package:flutter/material.dart';
import 'package:fl_chart/fl_chart.dart';

class PaymentAnalytics extends StatefulWidget {
  @override
  _PaymentAnalyticsState createState() => _PaymentAnalyticsState();
}


//delete
class _PaymentAnalyticsState extends State<PaymentAnalytics> {
  final PaymentService _paymentService = PaymentService();
  Future<PaymentResponse>? _paymentData;

  int? _selectedYear;
  int? _selectedMonth;

  final List<int> _years =
      List.generate(5, (index) => DateTime.now().year - index);
  final List<String> _months = [
    'Januar',
    'Februar',
    'Mart',
    'April',
    'Maj',
    'Juni',
    'Juli',
    'August',
    'Septembar',
    'Oktobar',
    'Novembar',
    'Decembar'
  ];

  @override
  void initState() {
    super.initState();
    _fetchData();
  }

  void _fetchData() {
    setState(() {
      _paymentData = _paymentService.getAllTransactions(
          year: _selectedYear,
          month: _selectedMonth != null ? _selectedMonth! + 1 : null);
    });
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(title: Text('Analitika uplata')),
      body: Padding(
        padding: const EdgeInsets.all(16.0),
        child: Column(
          crossAxisAlignment: CrossAxisAlignment.start,
          children: [
            // Filteri (godina i mjesec)
            Row(
              mainAxisAlignment: MainAxisAlignment.spaceEvenly,
              children: [
                DropdownButton<int>(
                  hint: Text("Odaberi godinu"),
                  value: _selectedYear,
                  onChanged: (value) {
                    setState(() {
                      _selectedYear = value;
                      _fetchData();
                    });
                  },
                  items: _years.map((year) {
                    return DropdownMenuItem<int>(
                      value: year,
                      child: Text(year.toString()),
                    );
                  }).toList(),
                ),
                DropdownButton<int>(
                  hint: Text("Odaberi mjesec"),
                  value: _selectedMonth,
                  onChanged: (value) {
                    setState(() {
                      _selectedMonth = value;
                      _fetchData();
                    });
                  },
                  items: _months.asMap().entries.map((entry) {
                    int index = entry.key;
                    String month = entry.value;
                    return DropdownMenuItem<int>(
                      value: index,
                      child: Text(month),
                    );
                  }).toList(),
                ),
              ],
            ),

            SizedBox(height: 20),

            // FutureBuilder za grafikone
            FutureBuilder<PaymentResponse>(
              future: _paymentData,
              builder: (context, snapshot) {
                if (snapshot.connectionState == ConnectionState.waiting) {
                  return Center(child: CircularProgressIndicator());
                } else if (snapshot.hasError) {
                  return Center(child: Text('Greška: ${snapshot.error}'));
                } else if (!snapshot.hasData ||
                    snapshot.data!.transactions.isEmpty) {
                  return Center(child: Text('Nema pronađenih transakcija'));
                }

                final data = snapshot.data!;
                return Expanded(
                  child: Column(
                    children: [
                      Text(
                        'Ukupan broj transakcija: ${data.totalRecords}',
                        style: TextStyle(
                            fontSize: 18, fontWeight: FontWeight.bold),
                      ),
                      Text(
                        'Ukupan iznos: ${data.totalAmount.toStringAsFixed(2)}',
                        style: TextStyle(
                            fontSize: 18, fontWeight: FontWeight.bold),
                      ),

                      SizedBox(height: 20),

                      // Prikaz ukupnog iznosa po valutama
                      _buildCurrencyTotals(data),

                      SizedBox(height: 20),

                      // Grafici (BarChart i PieChart)
                      Expanded(
                        child: Row(
                          children: [
                            Expanded(child: _buildBarChart(data)),
                            SizedBox(width: 16),
                            Expanded(child: _buildPieChart(data)),
                          ],
                        ),
                      ),
                    ],
                  ),
                );
              },
            ),
          ],
        ),
      ),
    );
  }

  // Prikaz ukupnog iznosa po valutama
  Widget _buildCurrencyTotals(PaymentResponse data) {
    Map<String, double> currencyTotals = {};

    for (var transaction in data.transactions) {
      String currency = transaction.currency.toUpperCase();
      currencyTotals[currency] =
          (currencyTotals[currency] ?? 0) + transaction.amount;
    }

    return Card(
      elevation: 4,
      child: Padding(
        padding: const EdgeInsets.all(8.0),
        child: Column(
          crossAxisAlignment: CrossAxisAlignment.start,
          children: currencyTotals.entries.map((entry) {
            return Text(
              '${entry.key}: ${entry.value.toStringAsFixed(2)}',
              style: TextStyle(fontSize: 16, fontWeight: FontWeight.bold),
            );
          }).toList(),
        ),
      ),
    );
  }

  // BarChart za transakcije po mjesecima
  Widget _buildBarChart(PaymentResponse data) {
    Map<int, double> monthlyTotals = {};

    for (var transaction in data.transactions) {
      int month = transaction.createdAt.month;
      monthlyTotals[month] = (monthlyTotals[month] ?? 0) + transaction.amount;
    }

    return Card(
      elevation: 4,
      child: Padding(
        padding: const EdgeInsets.all(8.0),
        child: BarChart(
          BarChartData(
            barGroups: monthlyTotals.entries.map((entry) {
              return BarChartGroupData(
                x: entry.key,
                barRods: [BarChartRodData(toY: entry.value, width: 15)],
              );
            }).toList(),
            titlesData: FlTitlesData(
              bottomTitles: AxisTitles(
                  sideTitles: SideTitles(
                showTitles: true,
                getTitlesWidget: (value, _) {
                  int index = value.toInt() - 1;
                  if (index >= 0 && index < _months.length) {
                    return Text(_months[index].substring(0, 3));
                  } else {
                    return Text("");
                  }
                },
              )),
              leftTitles: AxisTitles(sideTitles: SideTitles(showTitles: true)),
            ),
          ),
        ),
      ),
    );
  }

  // PieChart za transakcije po statusu
  Widget _buildPieChart(PaymentResponse data) {
    Map<String, double> statusTotals = {};

    for (var transaction in data.transactions) {
      String status = transaction.status.toLowerCase();
      statusTotals[status] = (statusTotals[status] ?? 0) + transaction.amount;
    }

    return Card(
      elevation: 4,
      child: Padding(
        padding: const EdgeInsets.all(8.0),
        child: PieChart(
          PieChartData(
            sections: statusTotals.entries.map((entry) {
              return PieChartSectionData(
                title: '${entry.key}: ${entry.value.toStringAsFixed(1)}',
                value: entry.value,
                radius: 40,
              );
            }).toList(),
          ),
        ),
      ),
    );
  }
}
