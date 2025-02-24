import 'dart:io';
import 'package:desktop_app/helpers/PriceHelper.dart';
import 'package:desktop_app/models/statistics.dart';
import 'package:pdf/widgets.dart' as pw;

class PdfHelper {
  static Future<String> generateStatisticsPdf(Statistics statistics) async {
    final pdf = pw.Document();

    pdf.addPage(
      pw.MultiPage(
        build: (context) => [
          pw.Text("Statistika aplikacije", style: pw.TextStyle(fontSize: 24)),
          pw.SizedBox(height: 20),

          pw.Text("Izvjestaj", style: pw.TextStyle(fontSize: 20)),
          pw.Bullet(text: "Ukupno oglasa: ${statistics.totalAutomobileAds}"),
          pw.Bullet(text: "Ukupno korisnika: ${statistics.totalUsers}"),
          pw.Bullet(
              text:
                  "Registrovanih u zadnjih 5 godina: ${statistics.usersRegisteredLastFiveYear}"),
          pw.Bullet(text: "Ukupno komentara: ${statistics.totalComments}"),
          pw.Bullet(
              text:
                  "Ukupno pregleda oglasa: ${statistics.totalAutomobileViews}"),
          pw.Bullet(text: "Izdvojenih oglasa: ${statistics.highlightedCars}"),

          pw.SizedBox(height: 20),

          pw.Text("Top 10 najvise favorizovanih automobila",
              style: pw.TextStyle(fontSize: 20)),
          pw.TableHelper.fromTextArray(
            headers: ["Automobil", "Cijena", "Brend", "Favorita"],
            data: statistics.mostFavoritedCars
                .map((car) => [
                      car.title,
                      formatPrice(car.price),
                      car.carBrand,
                      car.favoriteCount.toString(),
                    ])
                .toList(),
          ),

          pw.SizedBox(height: 20),
          pw.Text("Broj oglasa po gradovima",
              style: pw.TextStyle(fontSize: 20)),
          pw.TableHelper.fromTextArray(
            headers: ["Grad", "Broj oglasa"],
            data: statistics.automobilesPerCity
                .map((data) => [
                      data.city,
                      data.automobileCount.toString(),
                    ])
                .toList(),
          ),

          pw.SizedBox(height: 20),

          pw.Text("Istaknuti vs Regularni oglasi",
              style: pw.TextStyle(fontSize: 20)),
          pw.Bullet(text: "Istaknuti oglasi: ${statistics.highlightedCars}"),
          pw.Bullet(
              text:
                  "Regularni oglasi: ${statistics.totalAutomobileAds - statistics.highlightedCars}"),
        ],
      ),
    );

    final appFolder = Directory(getDocumentsPath());

    if (!await appFolder.exists()) {
      await appFolder.create(recursive: true);
    }

    final file = File("${appFolder.path}/statistika_aplikacije.pdf");
    await file.writeAsBytes(await pdf.save());

    return file.path;
  }

  static String getDocumentsPath() {
    if (Platform.isWindows) {
      return '${Platform.environment['USERPROFILE']}\\Documents\\desktop_app';
    } else {
      return '${Platform.environment['HOME']}/Documents/desktop_app';
    }
  }
}
