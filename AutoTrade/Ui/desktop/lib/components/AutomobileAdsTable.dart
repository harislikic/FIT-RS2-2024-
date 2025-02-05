import 'package:flutter/material.dart';
import 'package:intl/intl.dart';
import 'package:desktop_app/models/automobileAd.dart';
import 'package:desktop_app/services/ApiConfig.dart';

class AutomobileAdsTable extends StatelessWidget {
  final List<AutomobileAd> ads;
  final Function(int) onDelete;
  final Function(int) onApprove;
  final ScrollController scrollController;

  const AutomobileAdsTable({
    Key? key,
    required this.ads,
    required this.onDelete,
    required this.onApprove,
    required this.scrollController,
  }) : super(key: key);

  void _showAllImages(BuildContext context, List<String> imageUrls) {
    showDialog(
      context: context,
      builder: (context) => Dialog(
        child: Column(
          mainAxisSize: MainAxisSize.min,
          children: [
            const Padding(
              padding: EdgeInsets.all(8.0),
              child: Text("Sve slike",
                  style: TextStyle(fontSize: 18, fontWeight: FontWeight.bold)),
            ),
            SizedBox(
              height: 300,
              child: ListView.builder(
                scrollDirection: Axis.horizontal,
                itemCount: imageUrls.length,
                itemBuilder: (context, index) => Padding(
                  padding: const EdgeInsets.all(8.0),
                  child:
                      Image.network('${ApiConfig.baseUrl}${imageUrls[index]}'),
                ),
              ),
            ),
            TextButton(
                onPressed: () => Navigator.pop(context),
                child: const Text("Zatvori")),
          ],
        ),
      ),
    );
  }

  @override
  Widget build(BuildContext context) {
    return Expanded(
      child: SingleChildScrollView(
        controller: scrollController,
        scrollDirection: Axis.horizontal,
        child: DataTable(
          dividerThickness: 1,
          headingRowColor: MaterialStateProperty.all(Colors.blueGrey[50]),
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
          rows: ads
              .map(
                (AutomobileAd ad) => DataRow(
                  cells: [
                    DataCell(Text(ad.id.toString())), // ID
                    DataCell(
                      SizedBox(
                        width: 300,
                        child: Text(
                          ad.title,
                          overflow: TextOverflow
                              .ellipsis, 
                          maxLines: 1, 
                          softWrap: false,
                        ),
                      ),
                    ),

                    DataCell(Text(NumberFormat("#,###")
                        .format(ad.price))), // ✅ Formatirana cijena
                    DataCell(Text(NumberFormat("#,###").format(ad.mileage))),
                    DataCell(Text(
                        ad.yearOfManufacture.toString())), // Godina proizvodnje
                    DataCell(Text(ad.status)), // Status
                    DataCell(Text(
                        '${ad.user?.firstName} ${ad.user?.lastName}')), // Vlasnik
                    DataCell(Text('${ad.user?.city?.canton.title}')), // Kanton
                    DataCell(Text('${ad.user?.city?.title}')), // Grad
                    DataCell(Text(DateFormat('dd.MM.yyyy')
                        .format(ad.dateOfAdd))), // Datum dodavanja
                    DataCell(Text(ad.viewsCount.toString())), // Pregledi
                    DataCell(
                      ad.registered
                          ? const Icon(Icons.check_circle,
                              color: Colors.green) // Registrovano (✅)
                          : const Icon(Icons.cancel,
                              color: Colors.red), // Nije registrovano (❌)
                    ),
                    DataCell(
                      ad.isHighlighted
                          ? Text(
                              'Ističe: ${DateFormat('dd.MM.yyyy').format(ad.highlightExpiryDate!)}',
                              style: const TextStyle(
                                  color: Colors.orange,
                                  fontWeight: FontWeight.bold),
                            )
                          : const Text('-'),
                    ), // Istaknuto
                    DataCell(
                      MouseRegion(
                        cursor: SystemMouseCursors.click,
                        child: GestureDetector(
                          onTap: () => _showAllImages(context,
                              ad.images.map((e) => e.imageUrl).toList()),
                          child: Tooltip(
                            message: "Klikom prikaži sve slike",
                            child: Image.network(
                              '${ApiConfig.baseUrl}${ad.images.first.imageUrl}',
                              width: 50,
                              height: 50,
                            ),
                          ),
                        ),
                      ),
                    ), // Slika
                    DataCell(
                      Row(
                        children: [
                          if (ad.status == "Pending")
                            IconButton(
                              icon: const Icon(Icons.check_circle,
                                  color: Colors.green),
                              onPressed: () => onApprove(ad.id),
                            ),
                          IconButton(
                            icon: const Icon(Icons.delete, color: Colors.red),
                            onPressed: () => onDelete(ad.id),
                          ),
                        ],
                      ),
                    ), // Akcije (Odobravanje ili brisanje)
                  ],
                ),
              )
              .toList(),
        ),
      ),
    );
  }
}
