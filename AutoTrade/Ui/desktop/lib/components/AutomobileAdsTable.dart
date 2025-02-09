import 'package:desktop_app/components/ImageGalleryDialog.dart';
import 'package:flutter/material.dart';
import 'package:flutter_dotenv/flutter_dotenv.dart';
import 'package:intl/intl.dart';
import 'package:desktop_app/models/automobileAd.dart';

class AutomobileAdsTable extends StatelessWidget {
  final List<AutomobileAd> ads;
  final Function(int) onDelete;
  final Function(int) onApprove;

  const AutomobileAdsTable({
    Key? key,
    required this.ads,
    required this.onDelete,
    required this.onApprove,
  }) : super(key: key);

  void _showAllImages(BuildContext context, List<String> imageUrls) {
    showDialog(
      context: context,
      builder: (context) => ImageGalleryDialog(imageUrls: imageUrls),
    );
  }

  @override
  Widget build(BuildContext context) {
    return Expanded(
      child: SingleChildScrollView(
        scrollDirection: Axis.horizontal,
        child: DataTable(
          columns: const [
            DataColumn(label: Text('ID')),
            DataColumn(label: Text('Naslov')),
            DataColumn(label: Text('Cijena')),
            DataColumn(label: Text('Kilometraža')),
            DataColumn(label: Text('Godina proizvodnje')),
            DataColumn(label: Text('Status')),
            DataColumn(label: Text('Vlasnik')),
            DataColumn(label: Text('Kanton')),
            DataColumn(label: Text('Grad')),
            DataColumn(label: Text('Datum dodavanja')),
            DataColumn(label: Text('Pregledi')),
            DataColumn(label: Text('Registrovano')),
            DataColumn(label: Text('Istaknuto')),
            DataColumn(label: Text('Slika')),
            DataColumn(label: Text('Akcija')),
          ],
          rows: ads.map((ad) {
            return DataRow(cells: [
              DataCell(Text(ad.id.toString())),
              DataCell(SizedBox(
                width: 300,
                child: Text(
                  ad.title,
                  overflow: TextOverflow.ellipsis,
                  maxLines: 1,
                ),
              )),
              DataCell(Text(NumberFormat("#,###").format(ad.price))),
              DataCell(Text(NumberFormat("#,###").format(ad.mileage))),
              DataCell(Text(ad.yearOfManufacture.toString())),
              DataCell(Text(ad.status)),
              DataCell(Text('${ad.user?.firstName} ${ad.user?.lastName}')),
              DataCell(Text('${ad.user?.city?.canton.title}')),
              DataCell(Text('${ad.user?.city?.title}')),
              DataCell(Text(DateFormat('dd.MM.yyyy').format(ad.dateOfAdd))),
              DataCell(Text(ad.viewsCount.toString())),
              DataCell(
                ad.registered
                    ? const Icon(Icons.check_circle, color: Colors.green)
                    : const Icon(Icons.cancel, color: Colors.red),
              ),
              DataCell(
                ad.isHighlighted
                    ? Text(
                        'Ističe: ${DateFormat('dd.MM.yyyy').format(ad.highlightExpiryDate!)}',
                        style: const TextStyle(
                            color: Colors.orange, fontWeight: FontWeight.bold),
                      )
                    : const Text('-'),
              ),
              DataCell(
                ad.images.isNotEmpty
                    ? MouseRegion(
                        cursor: SystemMouseCursors.click,
                        child: GestureDetector(
                          onTap: () {
                            showDialog(
                              context: context,
                              builder: (context) => ImageGalleryDialog(
                                imageUrls:
                                    ad.images.map((e) => e.imageUrl).toList(),
                              ),
                            );
                          },
                          child: Tooltip(
                            message: "Klikom prikaži sve slike",
                            child: Image.network(
                              '${dotenv.env['BASE_URL']}${ad.images.first.imageUrl}',
                              width: 50,
                              height: 50,
                              errorBuilder: (context, error, stackTrace) {
                                return const Icon(Icons.broken_image,
                                    size: 50, color: Colors.grey);
                              },
                            ),
                          ),
                        ),
                      )
                    : const Text('-'), // Ako nema slika, prikaži crticu
              ),
              DataCell(
                Row(
                  children: [
                    if (ad.status == "Pending")
                      IconButton(
                        icon:
                            const Icon(Icons.check_circle, color: Colors.green),
                        onPressed: () => onApprove(ad.id),
                      ),
                    IconButton(
                      icon: const Icon(Icons.delete, color: Colors.red),
                      onPressed: () => onDelete(ad.id),
                    ),
                  ],
                ),
              ),
            ]);
          }).toList(),
        ),
      ),
    );
  }
}
