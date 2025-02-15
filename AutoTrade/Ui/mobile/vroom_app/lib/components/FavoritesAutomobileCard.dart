import 'package:flutter/material.dart';
import 'package:intl/intl.dart';
import 'package:vroom_app/components/ConfirmationDialog.dart';
import 'package:vroom_app/models/favoritesAutomobiles.dart';
import 'package:vroom_app/screens/automobileDetailsScreen.dart';
import 'package:vroom_app/services/config.dart';
import 'package:vroom_app/utils/helpers.dart';

class FavoritesAutomobileCard extends StatelessWidget {
  final FavoritesAutomobiles favoritesAutomobile;
  final Function onRemoveFavorite;

  const FavoritesAutomobileCard({
    Key? key,
    required this.favoritesAutomobile,
    required this.onRemoveFavorite,
  }) : super(key: key);

  void _showConfirmationDialog(BuildContext context) {
    showDialog(
      context: context,
      builder: (BuildContext context) {
        return ConfirmationDialog(
          title: "Potvrda brisanja",
          content:
              "Da li ste sigurni da želite da uklonite ovaj oglas iz favorita?",
          successMessage: "Oglas je uspešno uklonjen iz favorita.",
          onConfirm: () {
            onRemoveFavorite(favoritesAutomobile.id);
          },
          onCancel: () {},
        );
      },
    );
  }

  @override
  Widget build(BuildContext context) {
    return GestureDetector(
      onTap: () {
        Navigator.push(
          context,
          MaterialPageRoute(
            builder: (context) => AutomobileDetailsScreen(
              automobileAdId: favoritesAutomobile.id,
            ),
          ),
        );
      },
      child: Card(
        shape: RoundedRectangleBorder(
          borderRadius: BorderRadius.circular(10),
        ),
        elevation: 4,
        clipBehavior: Clip.antiAlias,
        child: Stack(
          children: [
            Column(
              crossAxisAlignment: CrossAxisAlignment.start,
              children: [
                if (favoritesAutomobile.images.isNotEmpty)
                  Image.network(
                    '$baseUrl${favoritesAutomobile.images.first.imageUrl}',
                    height: 140,
                    width: double.infinity,
                    fit: BoxFit.cover,
                  )
                else
                  Container(
                    height: 140,
                    color: Colors.grey.shade200,
                    child: const Center(
                      child: Icon(Icons.directions_car,
                          size: 40, color: Colors.grey),
                    ),
                  ),
                Padding(
                  padding: const EdgeInsets.symmetric(
                      horizontal: 8.0, vertical: 5.0),
                  child: Column(
                    crossAxisAlignment: CrossAxisAlignment.start,
                    children: [
                      SizedBox(
                        height: 40,
                        child: Align(
                          alignment: Alignment.centerLeft,
                          child: Text(
                            favoritesAutomobile.title,
                            style: const TextStyle(
                              fontSize: 14,
                              fontWeight: FontWeight.bold,
                            ),
                            maxLines: 2,
                            overflow: TextOverflow.ellipsis,
                          ),
                        ),
                      ),
                      const SizedBox(height: 2),
                      Container(
                        decoration: BoxDecoration(
                          color: Colors.white70,
                          borderRadius: BorderRadius.circular(10),
                        ),
                        padding: const EdgeInsets.only(
                            top: 8, left: 8, right: 8, bottom: 8),
                        child: Row(
                          mainAxisAlignment: MainAxisAlignment.spaceBetween,
                          children: [
                            Column(
                              children: [
                                const Icon(Icons.speed,
                                    size: 20, color: Colors.grey),
                                const SizedBox(height: 2),
                                Text(
                                  '${NumberFormat("#,###", "en_US").format(favoritesAutomobile.mileage)} km',
                                  style: const TextStyle(
                                    fontSize: 10,
                                    color: Colors.black,
                                  ),
                                ),
                              ],
                            ),
                            Column(
                              children: [
                                const Icon(Icons.calendar_today,
                                    size: 20, color: Colors.grey),
                                const SizedBox(height: 2),
                                Text(
                                  '${favoritesAutomobile.yearOfManufacture}',
                                  style: const TextStyle(
                                      fontSize: 10, color: Colors.black),
                                ),
                              ],
                            ),
                            Column(
                              children: [
                                const Icon(Icons.directions_car,
                                    size: 20, color: Colors.grey),
                                const SizedBox(height: 2),
                                Text(
                                  '${favoritesAutomobile.horsePower} HP',
                                  style: const TextStyle(
                                      fontSize: 10, color: Colors.black),
                                ),
                              ],
                            ),
                          ],
                        ),
                      ),
                      const SizedBox(height: 4),
                      Text(formatPrice(favoritesAutomobile.price),
                          style: const TextStyle(
                              fontSize: 14, fontWeight: FontWeight.bold)),
                    ],
                  ),
                ),
              ],
            ),
            Positioned(
              top: 4,
              right: 4,
              child: GestureDetector(
                onTap: () {
                  _showConfirmationDialog(context);
                },
                child: Container(
                  padding: const EdgeInsets.all(8),
                  decoration: BoxDecoration(
                    color: Colors.blueGrey.shade900.withOpacity(0.7),
                    shape: BoxShape.circle,
                    boxShadow: [
                      BoxShadow(
                        color: Colors.black.withOpacity(0.2),
                        blurRadius: 5,
                        spreadRadius: 2,
                      ),
                    ],
                  ),
                  child: const Icon(
                    Icons.delete_outlined,
                    color: Colors.redAccent,
                    size: 20,
                  ),
                ),
              ),
            )
          ],
        ),
      ),
    );
  }
}
