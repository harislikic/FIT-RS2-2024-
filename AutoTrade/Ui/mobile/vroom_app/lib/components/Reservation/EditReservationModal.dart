import 'package:flutter/material.dart';
import 'package:vroom_app/components/ConfirmationDialog.dart';
import 'package:vroom_app/models/reservation.dart';
import 'package:intl/intl.dart';

class EditReservationModal extends StatefulWidget {
  final Reservation reservation;
  final Function(DateTime) onConfirm;
  final VoidCallback onDelete;

  const EditReservationModal({
    Key? key,
    required this.reservation,
    required this.onConfirm,
    required this.onDelete,
  }) : super(key: key);

  @override
  _EditReservationModalState createState() => _EditReservationModalState();
}

class _EditReservationModalState extends State<EditReservationModal> {
  late DateTime _originalDateTime;
  late DateTime _selectedDateTime;
  bool _hasChanged = false;

  @override
  void initState() {
    super.initState();
    final original = DateTime.parse(widget.reservation.reservationDate);
    _originalDateTime = original;
    _selectedDateTime = original;
  }

  @override
  Widget build(BuildContext context) {
    return Container(
      padding: const EdgeInsets.all(16),
      child: Column(
        mainAxisSize: MainAxisSize.min,
        children: [
          const Text(
            'Uredi rezervaciju',
            style: TextStyle(fontSize: 20, fontWeight: FontWeight.bold),
          ),
          const SizedBox(height: 16),
          Text(
            'Trenutno vrijeme: ${DateFormat.Hm().format(_selectedDateTime)}',
            style: const TextStyle(fontSize: 16),
          ),
          const SizedBox(height: 16),
          ElevatedButton(
            onPressed: _pickNewTime,
            child: const Text('Izaberi novo vrijeme'),
          ),
          const SizedBox(height: 24),
          Row(
            mainAxisAlignment: MainAxisAlignment.spaceEvenly,
            children: [
              ElevatedButton.icon(
                icon: const Icon(Icons.save),
                label: const Text('Spremi'),
                onPressed: _hasChanged
                    ? () {
                        widget.onConfirm(_selectedDateTime);
                        Navigator.pop(context);
                      }
                    : null,
              ),
              ElevatedButton.icon(
                icon: const Icon(Icons.delete, color: Colors.red),
                style: ElevatedButton.styleFrom(
                  backgroundColor: Colors.white,
                ),
                label: const Text('Obriši'),
                onPressed: _showDeleteConfirmation,
              ),
            ],
          ),
        ],
      ),
    );
  }

  Future<void> _pickNewTime() async {
    final newTime = await showTimePicker(
      context: context,
      initialTime: TimeOfDay.fromDateTime(_selectedDateTime),
    );
    if (newTime == null) return;

    final updatedDateTime = DateTime(
      _selectedDateTime.year,
      _selectedDateTime.month,
      _selectedDateTime.day,
      newTime.hour,
      newTime.minute,
    );

    setState(() {
      _selectedDateTime = updatedDateTime;
      _hasChanged = !_timesAreEqual(_selectedDateTime, _originalDateTime);
    });
  }

  bool _timesAreEqual(DateTime a, DateTime b) {
    return a.year == b.year &&
        a.month == b.month &&
        a.day == b.day &&
        a.hour == b.hour &&
        a.minute == b.minute;
  }

  void _showDeleteConfirmation() {
    showDialog(
      context: context,
      builder: (context) => ConfirmationDialog(
        title: "Potvrda brisanja",
        content: "Da li ste sigurni da želite obrisati ovu rezervaciju?",
        onConfirm: () {
          widget.onDelete();
          Navigator.of(context).pop(); 
        },
        onCancel: () {},
        successMessage: "Rezervacija je uspješno obrisana!",
      ),
    );
  }
}
