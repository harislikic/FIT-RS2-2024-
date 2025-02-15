import 'package:flutter/material.dart';
import 'package:intl/intl.dart';
import 'package:vroom_app/components/shared/CloseModalButton.dart';
import 'package:vroom_app/components/shared/ToastUtils.dart';

class ReservationModal extends StatefulWidget {
  final DateTime selectedDay;
  final void Function(DateTime reservationDateTime) onConfirm;

  const ReservationModal({
    Key? key,
    required this.selectedDay,
    required this.onConfirm,
  }) : super(key: key);

  @override
  _ReservationModalState createState() => _ReservationModalState();
}

class _ReservationModalState extends State<ReservationModal> {
  TimeOfDay? _selectedTime;

  void _selectTime(BuildContext context) async {
    final pickedTime = await showTimePicker(
      context: context,
      initialTime: TimeOfDay.now(),
    );
    if (pickedTime != null) {
      setState(() {
        _selectedTime = pickedTime;
      });
    }
  }

  void _confirmReservation() {
    if (_selectedTime == null) {
      ToastUtils.showErrorToast(message: 'Morate odabrati vrijeme.');
      return;
    }

    final reservationDateTime = DateTime(
      widget.selectedDay.year,
      widget.selectedDay.month,
      widget.selectedDay.day,
      _selectedTime!.hour,
      _selectedTime!.minute,
    );

    widget.onConfirm(reservationDateTime);
    Navigator.pop(context);
  }

  @override
  Widget build(BuildContext context) {
    return Padding(
      padding: const EdgeInsets.all(16.0),
      child: Column(
        mainAxisSize: MainAxisSize.min,
        children: [
          Stack(
            children: [
              Align(
                alignment: Alignment.topRight,
                child: CloseModalButton(
                  onPressed: () => Navigator.of(context).pop(),
                ),
              ),
              Padding(
                padding: const EdgeInsets.only(top: 8.0),
                child: Center(
                  child: Text(
                    'Odaberite vrijeme za\n${DateFormat('dd.MM.yyyy').format(widget.selectedDay)}',
                    style: const TextStyle(
                      fontSize: 16,
                      fontWeight: FontWeight.bold,
                      color: Colors.black87,
                    ),
                    textAlign: TextAlign.center,
                  ),
                ),
              ),
            ],
          ),
          const SizedBox(height: 20),
          Center(
            child: Column(
              mainAxisSize: MainAxisSize.min,
              children: [
                OutlinedButton.icon(
                  onPressed: () => _selectTime(context),
                  icon: const Icon(Icons.access_time),
                  label: Text(
                    _selectedTime == null
                        ? 'Odaberite vrijeme'
                        : 'Odabrano: ${_selectedTime!.format(context)}',
                  ),
                  style: OutlinedButton.styleFrom(
                    padding: const EdgeInsets.symmetric(
                        vertical: 12.0, horizontal: 16.0),
                    side: const BorderSide(color: Colors.blueGrey),
                    shape: RoundedRectangleBorder(
                      borderRadius: BorderRadius.circular(8.0),
                    ),
                  ),
                ),
                const SizedBox(height: 16),
                ElevatedButton(
                  onPressed: _confirmReservation,
                  style: ElevatedButton.styleFrom(
                    padding: const EdgeInsets.symmetric(
                        vertical: 16, horizontal: 20),
                    backgroundColor: Colors.white,
                    foregroundColor: Colors.blueAccent,
                    side: const BorderSide(color: Colors.blueGrey, width: 2),
                    shape: RoundedRectangleBorder(
                      borderRadius: BorderRadius.circular(12),
                    ),
                    elevation: 2,
                  ),
                  child: const Row(
                    mainAxisSize: MainAxisSize.min,
                    children: [
                      Icon(Icons.check_circle, color: Colors.blueAccent),
                      SizedBox(width: 8),
                      Text(
                        'Potvrdi',
                        style: TextStyle(
                            fontSize: 16, fontWeight: FontWeight.bold),
                      ),
                    ],
                  ),
                ),
              ],
            ),
          ),
          const SizedBox(height: 46),
        ],
      ),
    );
  }
}
