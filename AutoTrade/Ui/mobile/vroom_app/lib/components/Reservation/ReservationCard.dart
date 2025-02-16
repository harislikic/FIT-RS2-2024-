import 'package:flutter/material.dart';
import 'package:intl/intl.dart';
import 'package:vroom_app/models/reservation.dart';
import 'package:vroom_app/screens/automobileDetailsScreen.dart';
import 'package:vroom_app/services/config.dart';

class ReservationCard extends StatelessWidget {
  final Reservation reservation;
  final VoidCallback? onApprove;
  final VoidCallback? onDecline;
  final VoidCallback? onDelete;

  const ReservationCard({
    Key? key,
    required this.reservation,
    this.onApprove,
    this.onDecline,
    required this.onDelete,
  }) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Card(
      margin: const EdgeInsets.symmetric(horizontal: 12, vertical: 8),
      shape: RoundedRectangleBorder(borderRadius: BorderRadius.circular(12)),
      elevation: 3,
      child: Column(
        children: [
          Row(
            children: [
              GestureDetector(
                onTap: () {
                  Navigator.push(
                    context,
                    MaterialPageRoute(
                      builder: (context) => AutomobileDetailsScreen(
                        automobileAdId: reservation.automobileAdId!,
                      ),
                    ),
                  );
                },
                child: ClipRRect(
                  borderRadius: const BorderRadius.only(
                    topLeft: Radius.circular(12),
                    bottomLeft: Radius.circular(12),
                  ),
                  child: Image.network(
                    "$baseUrl${reservation.firstImage}",
                    height: 120,
                    width: 120,
                    fit: BoxFit.cover,
                    errorBuilder: (context, error, stackTrace) {
                      return Image.asset(
                        'assets/noCarfallback.jpg',
                        height: 120,
                        width: 120,
                        fit: BoxFit.cover,
                      );
                    },
                  ),
                ),
              ),
              const SizedBox(width: 12),
              Expanded(
                child: Column(
                  crossAxisAlignment: CrossAxisAlignment.start,
                  children: [
                    Text(
                      reservation.title ?? "N/A",
                      style: const TextStyle(
                        fontSize: 18,
                        fontWeight: FontWeight.bold,
                      ),
                    ),
                    Text(
                      "${NumberFormat('#,##0').format(reservation.price ?? 0)} KM",
                      style: const TextStyle(
                        fontSize: 16,
                        color: Colors.black,
                      ),
                    ),
                    const SizedBox(height: 4),
                    Row(
                      children: [
                        CircleAvatar(
                          radius: 20,
                          backgroundImage: reservation.user?.profilePicture !=
                                  null
                              ? NetworkImage(
                                  "$baseUrl${reservation.user?.profilePicture}")
                              : const AssetImage(
                                  'assets/defaultUser.jpg',
                                ) as ImageProvider,
                          backgroundColor: Colors.grey.shade200,
                        ),
                        const SizedBox(width: 8),
                        Text(
                          reservation.user?.userName ?? "N/A",
                          style: const TextStyle(
                            fontSize: 14,
                            color: Colors.black87,
                          ),
                        ),
                      ],
                    ),
                    const SizedBox(height: 4),
                    Text(
                      "Želi da napravi rezervaciju dana ${DateFormat('dd.MM.yyyy HH:mm').format(DateTime.parse(reservation.reservationDate))}.",
                      style: const TextStyle(
                        fontSize: 14,
                        color: Colors.black,
                      ),
                    ),
                  ],
                ),
              ),
            ],
          ),
          Row(
            mainAxisAlignment: MainAxisAlignment.spaceAround,
            children: [
              if (reservation.status == "Pending") ...[
                ElevatedButton.icon(
                  onPressed: onApprove,
                  style: ElevatedButton.styleFrom(
                    side: const BorderSide(
                      color: Colors.green,
                      width: 2,
                    ),
                    backgroundColor: Colors.white,
                    padding:
                        const EdgeInsets.symmetric(horizontal: 16, vertical: 8),
                  ),
                  icon: const Icon(Icons.check, color: Colors.black),
                  label: const Text(
                    "Odobri",
                    style: TextStyle(color: Colors.black),
                  ),
                ),
                ElevatedButton.icon(
                  onPressed: onDecline,
                  style: ElevatedButton.styleFrom(
                    side: const BorderSide(
                      color: Colors.red,
                      width: 2,
                    ),
                    backgroundColor: Colors.white,
                    padding:
                        const EdgeInsets.symmetric(horizontal: 16, vertical: 8),
                  ),
                  icon: const Icon(Icons.cancel, color: Colors.red),
                  label: const Text(
                    "Odbi",
                    style: TextStyle(color: Colors.black),
                  ),
                ),
              ],
              if (reservation.status == "Approved" ||
                  reservation.status == "Rejected")
                ElevatedButton.icon(
                  onPressed: onDelete,
                  style: ElevatedButton.styleFrom(
                    backgroundColor: Colors.white,
                    padding:
                        const EdgeInsets.symmetric(horizontal: 16, vertical: 8),
                  ),
                  icon: const Icon(Icons.delete, color: Colors.red),
                  label: const Text(
                    "Obriši",
                    style: TextStyle(color: Colors.black),
                  ),
                ),
            ],
          ),
        ],
      ),
    );
  }
}
