import 'package:desktop_app/helpers/PdfHelper.dart';
import 'package:desktop_app/helpers/PriceHelper.dart';
import 'package:desktop_app/services/Statistics.dart';
import 'package:flutter/material.dart';
import 'package:fl_chart/fl_chart.dart';
import 'package:desktop_app/models/statistics.dart';
import 'package:open_file/open_file.dart';

class StatisticsScreen extends StatefulWidget {
  @override
  _StatisticsScreenState createState() => _StatisticsScreenState();
}

class _StatisticsScreenState extends State<StatisticsScreen> {
  final StatisticsService _statisticsService = StatisticsService();
  late Future<Statistics> _statisticsFuture;

  @override
  void initState() {
    super.initState();
    _statisticsFuture = _statisticsService.fetchStatistics();
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text("Statistika aplikacije"),
      ),
      body: FutureBuilder<Statistics>(
        future: _statisticsFuture,
        builder: (context, snapshot) {
          if (snapshot.connectionState == ConnectionState.waiting) {
            return Center(child: CircularProgressIndicator());
          } else if (snapshot.hasError) {
            return Center(
                child:
                    Text('Neuspješno učitavanje podataka: ${snapshot.error}'));
          } else if (!snapshot.hasData) {
            return const Center(child: Text('Nema dostupnih podataka'));
          }

          final statistics = snapshot.data!;

          return SingleChildScrollView(
            padding: EdgeInsets.all(16),
            child: Column(
              crossAxisAlignment: CrossAxisAlignment.start,
              children: [
                _buildSummaryCards(statistics),
                const SizedBox(height: 20),
                _buildMostFavoritedCars(statistics),
                const SizedBox(height: 20),
                _buildBarChart(statistics),
                const SizedBox(height: 20),
                _buildPieChart(statistics),
              ],
            ),
          );
        },
      ),
    );
  }

  Widget _buildSummaryCards(Statistics statistics) {
    return Row(
      crossAxisAlignment: CrossAxisAlignment.start,
      children: [
        Expanded(
          child: SingleChildScrollView(
            scrollDirection: Axis.horizontal,
            child: Wrap(
              spacing: 10,
              runSpacing: 10,
              alignment: WrapAlignment.center,
              children: [
                _buildCard(
                    "Ukupno oglasa", statistics.totalAutomobileAds.toString()),
                _buildCard(
                    "Ukupno korisnika", statistics.totalUsers.toString()),
                _buildCard("Registrovanih u zadnjih 5 godina",
                    statistics.usersRegisteredLastFiveYear.toString()),
                _buildCard(
                    "Ukupno komentara", statistics.totalComments.toString()),
                _buildCard("Ukupno pregleda oglasa",
                    statistics.totalAutomobileViews.toString()),
                _buildCard(
                    "Izdvojenih oglasa", statistics.highlightedCars.toString()),
              ],
            ),
          ),
        ),
        const SizedBox(width: 10),
        Tooltip(
          message: "Kliknite za preuzimanje izvjestaja",
          child: ElevatedButton.icon(
            icon: Icon(Icons.download),
            label: Text("Skini PDF"),
            onPressed: () async {
              final pdfPath = await PdfHelper.generateStatisticsPdf(statistics);

              if (!mounted) return;
              showDialog(
                context: context,
                builder: (context) => AlertDialog(
                  title: Text("PDF generisan!"),
                  content: SelectableText(
                      "PDF izvještaj je sačuvan na lokaciji:\n$pdfPath"),
                  actions: [
                    TextButton(
                      onPressed: () => Navigator.pop(context),
                      child: Text("Zatvori"),
                    ),
                    TextButton(
                      onPressed: () => OpenFile.open(pdfPath),
                      child: Text("Otvori PDF"),
                    ),
                  ],
                ),
              );
            },
          ),
        ),
      ],
    );
  }

  Widget _buildCard(String title, String value) {
    return Container(
      width: 160,
      padding: const EdgeInsets.all(8),
      child: Card(
        color: Colors.purple[50],
        elevation: 3,
        shape: RoundedRectangleBorder(borderRadius: BorderRadius.circular(10)),
        child: Padding(
          padding: const EdgeInsets.all(12),
          child: Column(
            children: [
              Text(title,
                  textAlign: TextAlign.center,
                  style: const TextStyle(
                      fontSize: 14, fontWeight: FontWeight.bold)),
              const SizedBox(height: 6),
              Text(value,
                  style: const TextStyle(
                      fontSize: 18,
                      fontWeight: FontWeight.bold,
                      color: Colors.blue)),
            ],
          ),
        ),
      ),
    );
  }

  Widget _buildMostFavoritedCars(Statistics statistics) {
    return Card(
      elevation: 4,
      shape: RoundedRectangleBorder(borderRadius: BorderRadius.circular(10)),
      child: Padding(
        padding: const EdgeInsets.all(16),
        child: Column(
          crossAxisAlignment: CrossAxisAlignment.start,
          children: [
            const Text("Top 10 najviše favorizovanih automobila",
                style: TextStyle(fontSize: 18, fontWeight: FontWeight.bold)),
            const SizedBox(height: 10),
            Wrap(
              spacing: 8,
              runSpacing: 8,
              children: statistics.mostFavoritedCars.map((car) {
                return SizedBox(
                  width: 150,
                  child: Card(
                    elevation: 3,
                    shape: RoundedRectangleBorder(
                        borderRadius: BorderRadius.circular(8)),
                    child: Padding(
                      padding: const EdgeInsets.all(8),
                      child: Column(
                        crossAxisAlignment: CrossAxisAlignment.start,
                        children: [
                          Text(car.title,
                              style: const TextStyle(
                                  fontSize: 14, fontWeight: FontWeight.bold)),
                          Text("Cijena: ${formatPrice(car.price)}"),
                          Text("Brend: ${car.carBrand}"),
                          Text("Favorita: ${car.favoriteCount}",
                              style: const TextStyle(color: Colors.red)),
                        ],
                      ),
                    ),
                  ),
                );
              }).toList(),
            ),
          ],
        ),
      ),
    );
  }

  Widget _buildBarChart(Statistics statistics) {
    return Card(
      elevation: 4,
      shape: RoundedRectangleBorder(borderRadius: BorderRadius.circular(10)),
      child: Padding(
        padding: EdgeInsets.all(16),
        child: Column(
          children: [
            const Text("Broj oglasa po gradovima",
                style: TextStyle(fontSize: 18, fontWeight: FontWeight.bold)),
            const SizedBox(height: 20),
            SizedBox(
              height: 300,
              child: BarChart(
                BarChartData(
                  barGroups: statistics.automobilesPerCity.map((data) {
                    return BarChartGroupData(
                      x: statistics.automobilesPerCity.indexOf(data),
                      barRods: [
                        BarChartRodData(
                          fromY: 0,
                          toY: data.automobileCount.toDouble(),
                          color: Colors.blue,
                        ),
                      ],
                    );
                  }).toList(),
                  titlesData: FlTitlesData(
                    leftTitles:
                        AxisTitles(sideTitles: SideTitles(showTitles: true)),
                    bottomTitles: AxisTitles(
                      sideTitles: SideTitles(
                        showTitles: true,
                        getTitlesWidget: (double value, TitleMeta meta) {
                          int index = value.toInt();
                          if (index < 0 ||
                              index >= statistics.automobilesPerCity.length) {
                            return Container();
                          }
                          return Padding(
                            padding: const EdgeInsets.only(top: 6),
                            child: Text(
                              statistics.automobilesPerCity[index].city,
                              style: const TextStyle(fontSize: 10),
                            ),
                          );
                        },
                      ),
                    ),
                  ),
                ),
              ),
            ),
          ],
        ),
      ),
    );
  }

  Widget _buildPieChart(Statistics statistics) {
    return Card(
      elevation: 4,
      shape: RoundedRectangleBorder(borderRadius: BorderRadius.circular(10)),
      child: Padding(
        padding: EdgeInsets.all(16),
        child: Column(
          children: [
            const Text("Istaknuti oglasi vs. regularni",
                style: TextStyle(fontSize: 18, fontWeight: FontWeight.bold)),
            const SizedBox(height: 20),
            SizedBox(
              height: 200,
              child: PieChart(
                PieChartData(
                  sections: [
                    PieChartSectionData(
                      value: statistics.highlightedCars.toDouble(),
                      title: "Istaknuti",
                      color: Colors.green,
                    ),
                    PieChartSectionData(
                      value: (statistics.totalAutomobileAds -
                              statistics.highlightedCars)
                          .toDouble(),
                      title: "Regularni",
                      color: Colors.grey,
                    ),
                  ],
                ),
              ),
            ),
          ],
        ),
      ),
    );
  }
}
