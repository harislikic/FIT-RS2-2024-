import 'package:collection/collection.dart';
import 'package:flutter/material.dart';
import 'package:intl/intl.dart';
import 'package:vroom_app/components/Reservation/ReservationCalendarView.dart';
import 'package:vroom_app/components/Reservation/ReservationModal.dart';
import 'package:vroom_app/components/Reservation/EditReservationModal.dart'; // <--- We'll create this new widget below
import 'package:vroom_app/components/shared/ToastUtils.dart';
import 'package:vroom_app/models/reservation.dart';
import 'package:vroom_app/services/AuthService.dart';
import 'package:vroom_app/services/ReservationService.dart';

class ReservationCalendar extends StatefulWidget {
  final List<Reservation> reservations;
  final int automobileAdId;
  final int automobileOwnerId;

  const ReservationCalendar({
    Key? key,
    required this.reservations,
    required this.automobileAdId,
    required this.automobileOwnerId,
  }) : super(key: key);

  @override
  _ReservationCalendarState createState() => _ReservationCalendarState();
}

class _ReservationCalendarState extends State<ReservationCalendar> {
  DateTime _selectedDay = DateTime.now();
  late List<Reservation> _currentReservations;

  @override
  void initState() {
    super.initState();
    _currentReservations = widget.reservations;
  }

  void _showReservationModal(BuildContext context, DateTime selectedDay) async {
    final userId = await AuthService.getUserId();

    if (userId == null) {
      ToastUtils.showErrorToast(
          message: 'Morate biti prijavljeni da biste napravili rezervaciju.');
      return;
    }

    if (userId == widget.automobileOwnerId) {
      ToastUtils.showErrorToast(
          message: 'Ne možete rezervisati vlastiti oglas.');
      return;
    }

    showModalBottomSheet(
      context: context,
      builder: (BuildContext context) {
        return ReservationModal(
          selectedDay: selectedDay,
          onConfirm: (reservationDateTime) {
            _sendReservationRequest(reservationDateTime);
          },
        );
      },
    );
  }

  Future<void> _sendReservationRequest(DateTime reservationDateTime) async {
    try {
      final reservationService = ReservationService();
      final userId = await AuthService.getUserId();

      await reservationService.createReservation(
        reservationDate: reservationDateTime,
        userId: userId!,
        automobileAdId: widget.automobileAdId,
      );

      ToastUtils.showToast(message: 'Rezervacija uspješno dodana.');
      final updatedReservations = await reservationService
          .getReservationsByAutomobileId(automobileAdId: widget.automobileAdId);

      setState(() {
        _currentReservations = updatedReservations;
      });
    } catch (e) {
      ToastUtils.showErrorToast(
        message: 'Greška pri dodavanju rezervacije: $e',
      );
    }
  }

  void _showEditReservationModal(
      BuildContext context, Reservation userReservation) {
    showModalBottomSheet(
      context: context,
      builder: (BuildContext context) {
        return EditReservationModal(
          reservation: userReservation,
          onConfirm: (newDateTime) {
            _updateReservationRequest(userReservation, newDateTime);
          },
          onDelete: () {
            _deleteReservationRequest(userReservation.reservationId);
          },
        );
      },
    );
  }

  Future<void> _updateReservationRequest(
      Reservation userReservation, DateTime newDateTime) async {
    try {
      final reservationService = ReservationService();
      final userId = await AuthService.getUserId();

      if (userId == null) {
        ToastUtils.showErrorToast(message: 'Niste prijavljeni.');
        return;
      }

      await reservationService.updateReservation(
        reservationId: userReservation.reservationId,
        newReservationDate: newDateTime,
        userId: userId,
        automobileAdId: widget.automobileAdId,
      );

      ToastUtils.showToast(message: 'Rezervacija uspješno ažurirana.');

      final updatedReservations = await reservationService
          .getReservationsByAutomobileId(automobileAdId: widget.automobileAdId);

      setState(() {
        _currentReservations = updatedReservations;
      });
    } catch (e) {
      ToastUtils.showErrorToast(
        message: 'Greška pri ažuriranju rezervacije: $e',
      );
    }
  }

  Future<void> _deleteReservationRequest(int reservationId) async {
    try {
      final reservationService = ReservationService();
      await reservationService.deleteReservation(reservationId: reservationId);

      ToastUtils.showToast(message: 'Rezervacija uspješno obrisana.');

      final updatedReservations = await reservationService
          .getReservationsByAutomobileId(automobileAdId: widget.automobileAdId);

      setState(() {
        _currentReservations = updatedReservations;
      });
    } catch (e) {
      ToastUtils.showErrorToast(
        message: 'Greška pri brisanju rezervacije: $e',
      );
    }
  }

  @override
  Widget build(BuildContext context) {
    final Map<String, List<Reservation>> reservationsByDate = {};
    for (var reservation in _currentReservations) {
      final String dateKey = DateFormat('yyyy-MM-dd')
          .format(DateTime.parse(reservation.reservationDate));
      if (!reservationsByDate.containsKey(dateKey)) {
        reservationsByDate[dateKey] = [];
      }
      reservationsByDate[dateKey]!.add(reservation);
    }

    return Column(
      children: [
        ReservationCalendarView(
          reservationsByDate: reservationsByDate,
          selectedDay: _selectedDay,
          onDaySelected: (selectedDay) async {
            setState(() {
              _selectedDay = selectedDay;
            });

            final formattedDate = DateFormat('yyyy-MM-dd').format(selectedDay);
            final userId = await AuthService.getUserId();

            if (reservationsByDate.containsKey(formattedDate)) {
              final reservations = reservationsByDate[formattedDate]!;

              final myReservation = reservations.firstWhereOrNull(
                (res) => res.userId == userId,
              );

              if (myReservation != null) {
                _showEditReservationModal(context, myReservation);
                return;
              } else {
                final hasApproved =
                    reservations.any((res) => res.status == "Approved");
                final hasPending =
                    reservations.any((res) => res.status == "Pending");

                if (hasApproved) {
                  ToastUtils.showErrorToast(
                      message: 'Datum je odobren i zauzet.');
                } else if (hasPending) {
                  ToastUtils.showInfoToast(message: 'Datum je u obradi.');
                }
              }
            } else {
              _showReservationModal(context, selectedDay);
            }
          },
        ),
      ],
    );
  }
}
