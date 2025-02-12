import 'package:desktop_app/services/Statistics.dart';
import 'package:flutter/material.dart';
import 'package:fl_chart/fl_chart.dart';
import 'package:desktop_app/models/statistics.dart';

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
      appBar: AppBar(title: Text("Statistika aplikacije")),
      body: FutureBuilder<Statistics>(
        future: _statisticsFuture,
        builder: (context, snapshot) {
          if (snapshot.connectionState == ConnectionState.waiting) {
            return Center(child: CircularProgressIndicator());
          } else if (snapshot.hasError) {
            return Center(child: Text('Neuspješno učitavanje podataka: ${snapshot.error}'));
          } else if (!snapshot.hasData) {
            return Center(child: Text('Nema dostupnih podataka'));
          }

          final statistics = snapshot.data!;

          return SingleChildScrollView(
            padding: EdgeInsets.all(16),
            child: Column(
              crossAxisAlignment: CrossAxisAlignment.start,
              children: [
                _buildSummaryCards(statistics),
                SizedBox(height: 20),
                _buildMostFavoritedCar(statistics),
                SizedBox(height: 20),
                _buildBarChart(statistics),
                SizedBox(height: 20),
                _buildPieChart(statistics),
              ],
            ),
          );
        },
      ),
    );
  }

  /// ✅ Prikaz osnovnih podataka
  Widget _buildSummaryCards(Statistics statistics) {
    return Row(
      mainAxisAlignment: MainAxisAlignment.spaceEvenly,
      children: [
        _buildCard("Ukupno oglasa", statistics.totalAutomobileAds.toString()),
        _buildCard("Ukupno korisnika", statistics.totalUsers.toString()),
        _buildCard("Ukupno komentara", statistics.totalComments.toString()),
        _buildCard("Izdvojenih oglasa", statistics.highlightedCars.toString()),
      ],
    );
  }

  Widget _buildCard(String title, String value) {
    return Card(
      elevation: 4,
      shape: RoundedRectangleBorder(borderRadius: BorderRadius.circular(10)),
      child: Padding(
        padding: EdgeInsets.all(16),
        child: Column(
          children: [
            Text(title, style: TextStyle(fontSize: 16, fontWeight: FontWeight.bold)),
            SizedBox(height: 8),
            Text(value, style: TextStyle(fontSize: 18, color: Colors.blue)),
          ],
        ),
      ),
    );
  }


  /// ✅ Prikaz najfavorizovanijeg automobila
  Widget _buildMostFavoritedCar(Statistics statistics) {
    var car = statistics.mostFavoritedCar;
    return Card(
      elevation: 4,
      shape: RoundedRectangleBorder(borderRadius: BorderRadius.circular(10)),
      child: Padding(
        padding: EdgeInsets.all(16),
        child: Column(
          crossAxisAlignment: CrossAxisAlignment.start,
          children: [
            Text("Najviše favorizovan auto", style: TextStyle(fontSize: 18, fontWeight: FontWeight.bold)),
            SizedBox(height: 10),
            Text("Model: ${car.title}", style: TextStyle(fontSize: 16)),
            Text("Cijena: \$${car.price}", style: TextStyle(fontSize: 16)),
            Text("Broj favorita: ${car.favoriteCount}", style: TextStyle(fontSize: 16, color: Colors.red)),
          ],
        ),
      ),
    );
  }

  /// ✅ Prikaz Bar Charta (Oglasi po gradovima)
  Widget _buildBarChart(Statistics statistics) {
    return Card(
      elevation: 4,
      shape: RoundedRectangleBorder(borderRadius: BorderRadius.circular(10)),
      child: Padding(
        padding: EdgeInsets.all(16),
        child: Column(
          children: [
            Text("Broj oglasa po gradovima", style: TextStyle(fontSize: 18, fontWeight: FontWeight.bold)),
            SizedBox(height: 20),
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
                    leftTitles: AxisTitles(sideTitles: SideTitles(showTitles: true)),
                    bottomTitles: AxisTitles(
                      sideTitles: SideTitles(
                        showTitles: true,
                        getTitlesWidget: (double value, TitleMeta meta) {
                          int index = value.toInt();
                          if (index < 0 || index >= statistics.automobilesPerCity.length) {
                            return Container();
                          }
                          return Padding(
                            padding: EdgeInsets.only(top: 6),
                            child: Text(
                              statistics.automobilesPerCity[index].city, // ✅ Prikaz punog imena grada
                              style: TextStyle(fontSize: 10),
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

  /// ✅ Prikaz Pie Charta (Highlighted vs. Regular oglasi)
  Widget _buildPieChart(Statistics statistics) {
    return Card(
      elevation: 4,
      shape: RoundedRectangleBorder(borderRadius: BorderRadius.circular(10)),
      child: Padding(
        padding: EdgeInsets.all(16),
        child: Column(
          children: [
            Text("Istaknuti oglasi vs. regularni", style: TextStyle(fontSize: 18, fontWeight: FontWeight.bold)),
            SizedBox(height: 20),
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
                      value: (statistics.totalAutomobileAds - statistics.highlightedCars).toDouble(),
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
