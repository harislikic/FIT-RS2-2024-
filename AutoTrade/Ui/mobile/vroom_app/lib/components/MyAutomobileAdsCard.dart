import 'package:flutter/material.dart';
import 'package:intl/intl.dart';
import 'package:vroom_app/components/ConfirmationDialog.dart';
import 'package:vroom_app/services/config.dart';
import '../models/automobileAd.dart';
import '../screens/automobileDetailsScreen.dart';

class MyAutomobileAdsCard extends StatelessWidget {
  final AutomobileAd automobileAd;
  final Future<void> Function(int automobileId) onRemove;
  final Future<void> Function(int automobileId) onComplete;
  final String selectedTab;

  const MyAutomobileAdsCard({
    Key? key,
    required this.automobileAd,
    required this.onRemove,
    required this.onComplete,
    required this.selectedTab,
  }) : super(key: key);

  void _showConfirmationDialog(BuildContext context) {
    showDialog(
      context: context,
      builder: (BuildContext context) {
        return ConfirmationDialog(
          title: "Potvrda brisanja",
          content: "Da li ste sigurni da želite da uklonite ovaj oglas?",
          successMessage: "Oglas je uspešno uklonjen.",
          onConfirm: () async {
            await onRemove(automobileAd.id);
          },
          onCancel: () {},
        );
      },
    );
  }

  void _showCompleteDialog(BuildContext context) {
    showDialog(
      context: context,
      builder: (BuildContext context) {
        return ConfirmationDialog(
          title: "Potvrda završavanja",
          content: "Da li ste sigurni da želite završiti ovaj oglas?",
          successMessage: "Oglas je uspešno završen.",
          onConfirm: () async {
            await onComplete(automobileAd.id);
          },
          onCancel: () {},
        );
      },
    );
  }

  @override
  Widget build(BuildContext context) {
    return Card(
      shape: RoundedRectangleBorder(
        borderRadius: BorderRadius.circular(15),
      ),
      elevation: 4,
      margin: const EdgeInsets.symmetric(horizontal: 8.0, vertical: 6.0),
      child: Column(
        crossAxisAlignment: CrossAxisAlignment.start,
        children: [
          ClipRRect(
            borderRadius: const BorderRadius.vertical(top: Radius.circular(15)),
            child: automobileAd.images.isNotEmpty
                ? Image.network(
                    '$baseUrl${automobileAd.images.isNotEmpty ? automobileAd.images.first.imageUrl : ''}',
                    height: 200,
                    width: double.infinity,
                    fit: BoxFit.cover,
                    errorBuilder: (context, error, stackTrace) {
                      return Image.asset(
                        'assets/noCarfallback.jpg',
                        height: 200,
                        width: double.infinity,
                        fit: BoxFit.cover,
                      );
                    },
                  )
                : Container(
                    height: 200,
                    color: Colors.grey.shade200,
                    child: const Center(
                      child: Icon(Icons.directions_car,
                          size: 40, color: Colors.grey),
                    ),
                  ),
          ),
          Padding(
            padding:
                const EdgeInsets.symmetric(horizontal: 12.0, vertical: 8.0),
            child: Column(
              crossAxisAlignment: CrossAxisAlignment.start,
              children: [
                Row(
                  children: [
                    const Icon(
                      Icons.title,
                      size: 18,
                      color: Colors.grey,
                    ),
                    const SizedBox(width: 8),
                    Expanded(
                      child: Text(
                        automobileAd.title,
                        style: const TextStyle(
                          fontSize: 18,
                          fontWeight: FontWeight.bold,
                        ),
                        maxLines: 2,
                        overflow: TextOverflow.ellipsis,
                      ),
                    ),
                  ],
                ),
                const Divider(
                  color: Colors.grey,
                  thickness: 0.5,
                  height: 20,
                ),
                Row(
                  children: [
                    const Icon(
                      Icons.date_range,
                      size: 18,
                      color: Colors.grey,
                    ),
                    const SizedBox(width: 8),
                    Text(
                      'Datum dodavanja: ${DateFormat('dd.MM.yyyy').format(automobileAd.dateOfAdd)}',
                      style: const TextStyle(
                        fontSize: 14,
                        color: Colors.black54,
                      ),
                    ),
                  ],
                ),
                const Divider(
                  color: Colors.grey,
                  thickness: 0.5,
                  height: 20,
                ),
                Row(
                  children: [
                    const Icon(
                      Icons.attach_money,
                      size: 18,
                      color: Colors.green,
                    ),
                    const SizedBox(width: 8),
                    Text(
                      '${NumberFormat('#,##0').format(automobileAd.price)} KM',
                      style: const TextStyle(
                        fontSize: 16,
                        fontWeight: FontWeight.bold,
                        color: Colors.blueGrey,
                      ),
                    ),
                  ],
                ),
              ],
            ),
          ),
          Padding(
            padding: const EdgeInsets.symmetric(horizontal: 8.0, vertical: 8.0),
            child: Row(
              mainAxisAlignment: MainAxisAlignment.spaceBetween,
              children: [
                Container(
                  decoration: BoxDecoration(
                    color: Colors.grey.shade200,
                    shape: BoxShape.circle,
                    boxShadow: [
                      BoxShadow(
                        color: Colors.black.withOpacity(0.1),
                        blurRadius: 6,
                        spreadRadius: 3,
                        offset: const Offset(0, 3),
                      ),
                    ],
                  ),
                  child: IconButton(
                    icon: const Icon(
                      Icons.delete_outline_outlined,
                      color: Colors.redAccent,
                      size: 28,
                    ),
                    onPressed: () => _showConfirmationDialog(context),
                  ),
                ),
                Row(
                  children: [
                    if (selectedTab != 'done')
                      ElevatedButton.icon(
                        onPressed: () => _showCompleteDialog(context),
                        icon: const Icon(Icons.check_circle_outline,
                            size: 20, color: Colors.green),
                        label: const Text(
                          "Završi",
                          style: TextStyle(color: Colors.blueGrey),
                        ),
                        style: ElevatedButton.styleFrom(
                          foregroundColor: Colors.white,
                          backgroundColor: Colors.white,
                          side: const BorderSide(
                              color: Colors.blueGrey, width: 1.5),
                          padding: const EdgeInsets.symmetric(
                              horizontal: 16.0, vertical: 8.0),
                          shape: RoundedRectangleBorder(
                            borderRadius: BorderRadius.circular(20),
                          ),
                        ),
                      ),
                    if (selectedTab != 'done') const SizedBox(width: 8),
                    ElevatedButton.icon(
                      onPressed: () {
                        Navigator.push(
                          context,
                          MaterialPageRoute(
                            builder: (context) => AutomobileDetailsScreen(
                              automobileAdId: automobileAd.id,
                            ),
                          ),
                        );
                      },
                      icon: const Icon(Icons.directions_car,
                          size: 20, color: Colors.white),
                      label: const Text(
                        "Posjeti",
                        style: TextStyle(color: Colors.white),
                      ),
                      style: ElevatedButton.styleFrom(
                        foregroundColor: Colors.white,
                        backgroundColor: Colors.lightBlue.shade300,
                        padding: const EdgeInsets.symmetric(
                            horizontal: 16.0, vertical: 8.0),
                        shape: RoundedRectangleBorder(
                          borderRadius: BorderRadius.circular(20),
                        ),
                        elevation: 4,
                        shadowColor: Colors.lightBlueAccent,
                      ),
                    ),
                  ],
                ),
              ],
            ),
          )
        ],
      ),
    );
  }
}
