import 'dart:io';
import 'package:pdf/widgets.dart' as pw;
import 'package:pdf/widgets.dart';
import 'package:desktop_app/helpers/DateHelper.dart';

class StripePdfHelper {
  static Future<String> generateStripeTransactionsPdf(
    List<dynamic> transactions,
  ) async {
    final pdf = pw.Document();

    final int totalTransactions = transactions.length;

    Map<String, Map<String, double>> currencyStats = {};

    Map<String, Map<String, double>> monthlyStats = {};

    Map<String, int> statusStats = {};
    Map<String, int> brandStats = {};

    for (var transaction in transactions) {
      // Amount & currency
      String currency = transaction['currency'].toUpperCase();
      double amount = (transaction['amount'] / 100).toDouble();
      currencyStats.putIfAbsent(currency, () => {'amount': 0, 'count': 0});
      if (!currencyStats.containsKey(currency)) {
        currencyStats[currency] = {'amount': 0.0, 'count': 0.0};
      }

      currencyStats[currency]!['amount'] =
          (currencyStats[currency]!['amount'] ?? 0.0) + amount;

      currencyStats[currency]!['count'] =
          (currencyStats[currency]!['count'] ?? 0.0) + 1;

      DateTime date =
          DateTime.fromMillisecondsSinceEpoch(transaction['created'] * 1000);
      int month = date.month;
      int year = date.year;
      String key = "$month/$year";
      monthlyStats.putIfAbsent(key, () => {'count': 0, 'totalAmount': 0});
      monthlyStats[key]!['count'] = monthlyStats[key]!['count']! + 1;
      monthlyStats[key]!['totalAmount'] =
          monthlyStats[key]!['totalAmount']! + amount;

      String status = transaction['status'] ?? 'unknown';
      statusStats[status] = (statusStats[status] ?? 0) + 1;

      String brand = transaction['card_brand'] ?? 'N/A';
      brandStats[brand] = (brandStats[brand] ?? 0) + 1;
    }

    pdf.addPage(
      pw.MultiPage(
        build: (context) => [
          pw.Text("Stripe Analitika", style: pw.TextStyle(fontSize: 24)),
          pw.SizedBox(height: 20),
          pw.Text("Opsti pregled", style: pw.TextStyle(fontSize: 18)),
          pw.Bullet(text: "Ukupan broj transakcija: $totalTransactions"),
          pw.SizedBox(height: 20),
          pw.Text("Statistika po valutama", style: pw.TextStyle(fontSize: 18)),
          _buildCurrencyTable(currencyStats),
          pw.SizedBox(height: 20),
          pw.Text("Mjesecne transakcije i prihod",
              style: pw.TextStyle(fontSize: 18)),
          _buildMonthlyTable(monthlyStats),
          pw.SizedBox(height: 20),
          pw.Text("Raspodjela po statusu", style: pw.TextStyle(fontSize: 18)),
          _buildStatusTable(statusStats),
          pw.SizedBox(height: 20),
        ],
      ),
    );

    final appFolder = Directory(_getDocumentsPath());
    if (!await appFolder.exists()) {
      await appFolder.create(recursive: true);
    }

    final file = File("${appFolder.path}/stripe_analitika.pdf");
    await file.writeAsBytes(await pdf.save());
    return file.path;
  }

  static pw.Widget _buildCurrencyTable(Map<String, Map<String, double>> data) {
    final headers = ["Valuta", "Ukupni iznos", "Broj transakcija"];
    final rows = data.entries.map((entry) {
      final currency = entry.key;
      final totalAmt = entry.value['amount']!.toStringAsFixed(2);
      final count = entry.value['count']!.toInt().toString();
      return [currency, totalAmt, count];
    }).toList();

    return pw.TableHelper.fromTextArray(
      headers: headers,
      data: rows,
      headerStyle: pw.TextStyle(fontWeight: FontWeight.bold),
      cellAlignment: pw.Alignment.centerLeft,
    );
  }

  static pw.Widget _buildMonthlyTable(Map<String, Map<String, double>> data) {
    final headers = ["Mjesec/Godina", "Iznos", "Transakcije"];

    final rows = data.entries.map((entry) {
      final parts = entry.key.split('/');
      final monthNum = parts[0];
      final year = parts[1];
      final monthName = DateHelper.getMonthName(monthNum);
      final label = '$monthName $year';

      final amount = entry.value['totalAmount']!.toStringAsFixed(2);
      final count = entry.value['count']!.toInt().toString();
      return [label, amount, count];
    }).toList();

    return pw.TableHelper.fromTextArray(
      headers: headers,
      data: rows,
      headerStyle: pw.TextStyle(fontWeight: FontWeight.bold),
      cellAlignment: pw.Alignment.centerLeft,
    );
  }

  static pw.Widget _buildStatusTable(Map<String, int> statusStats) {
    final headers = ["Status", "Broj transakcija"];
    final rows = statusStats.entries.map((e) {
      return [e.key, e.value.toString()];
    }).toList();

    return pw.TableHelper.fromTextArray(
      headers: headers,
      data: rows,
      headerStyle: pw.TextStyle(fontWeight: FontWeight.bold),
      cellAlignment: pw.Alignment.centerLeft,
    );
  }

  static String _getDocumentsPath() {
    if (Platform.isWindows) {
      return '${Platform.environment['USERPROFILE']}\\Documents\\desktop_app';
    } else {
      return '${Platform.environment['HOME']}/Documents/desktop_app';
    }
  }
}
