import 'package:flutter/material.dart';
import 'package:intl/intl.dart';
import 'package:vroom_app/models/moodTracker.dart';
import 'package:vroom_app/models/user.dart';
import 'package:vroom_app/services/MoodTrackerService.dart';
import 'package:vroom_app/services/UserService.dart';

import 'FrmMoodTrackerNew.dart';

class FrmMoodTracker extends StatefulWidget {
  const FrmMoodTracker({Key? key}) : super(key: key);

  @override
  State<FrmMoodTracker> createState() => _FrmMoodTrackerState();
}

class _FrmMoodTrackerState extends State<FrmMoodTracker> {
  late Future<List<MoodTracker>> _moodTrackersFuture;

  List<User> _users = [];
  User? _selectedUser;
  String? _selectedMood;
  DateTime? _startDate;
  DateTime? _endDate;

  final List<String> _moods = [
    'Sretan',
    'Tužan',
    'Uzbuđen',
    'Umoran',
    'Pod stresom'
  ];

  @override
  void initState() {
    super.initState();
    _fetchMoodTrackers();
    _loadUsers();
  }

  Future<void> _loadUsers() async {
    try {
      final users = await UserService.getUsers();
      setState(() {
        _users = users;
      });
    } catch (e) {
      print('Greška pri učitavanju korisnika: $e');
    }
  }

  void _fetchMoodTrackers({
    String? mood,
    int? userId,
    DateTime? startDate,
    DateTime? endDate,
  }) {
    final formattedStart =
        startDate != null ? DateFormat('dd-MM-yyyy').format(startDate) : null;

    final formattedEnd =
        endDate != null ? DateFormat('dd-MM-yyyy').format(endDate) : null;
    setState(() {
      _moodTrackersFuture = MoodTrackerService.getMoodTrackers(
          mood, userId, formattedStart, formattedEnd);
    });
  }

  String _formatDate(DateTime date) {
    return DateFormat('dd.MM.yyyy').format(date);
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text('Mood Tracker'),
        actions: [
          IconButton(
            icon: const Icon(Icons.add, color: Colors.blue),
            tooltip: "Dodaj",
            onPressed: () async {
              // Navigacija ka frmMoodTrackerNew
              final result = await Navigator.push(
                context,
                MaterialPageRoute(
                    builder: (context) => const FrmMoodTrackerNew()),
              );

              // Ako je dodat novi mood, osveži listu
              if (result == true) {
                _fetchMoodTrackers();
              }
            },
          )
        ],
      ),
      body: Column(
        children: [
          // 🔽 FILTERI
          Padding(
            padding: const EdgeInsets.all(8.0),
            child: Column(
              children: [
                Column(
                  children: [
                    DropdownButtonFormField<User>(
                      decoration: const InputDecoration(labelText: 'Korisnik'),
                      items: _users.map((user) {
                        return DropdownMenuItem(
                          value: user,
                          child: Text('${user.firstName} ${user.lastName}'),
                        );
                      }).toList(),
                      value: _selectedUser,
                      onChanged: (value) =>
                          setState(() => _selectedUser = value),
                    ),
                    DropdownButtonFormField<String>(
                      decoration:
                          const InputDecoration(labelText: 'Raspoloženje'),
                      items: _moods.map((mood) {
                        return DropdownMenuItem(value: mood, child: Text(mood));
                      }).toList(),
                      value: _selectedMood,
                      onChanged: (value) =>
                          setState(() => _selectedMood = value),
                    ),
                  ],
                ),
                Row(
                  children: [
                    Expanded(
                      child: TextButton.icon(
                        icon: const Icon(Icons.date_range),
                        label: Text(_startDate == null
                            ? 'Od datuma'
                            : DateFormat('dd.MM.yyyy').format(_startDate!)),
                        onPressed: () async {
                          final picked = await showDatePicker(
                            context: context,
                            initialDate: DateTime.now(),
                            firstDate: DateTime(2023),
                            lastDate: DateTime.now(),
                          );
                          if (picked != null)
                            setState(() => _startDate = picked);
                        },
                      ),
                    ),
                    Expanded(
                      child: TextButton.icon(
                        icon: const Icon(Icons.date_range),
                        label: Text(_endDate == null
                            ? 'Do datuma'
                            : DateFormat('dd.MM.yyyy').format(_endDate!)),
                        onPressed: () async {
                          final picked = await showDatePicker(
                            context: context,
                            initialDate: DateTime.now(),
                            firstDate: DateTime(2023),
                            lastDate: DateTime.now(),
                          );
                          if (picked != null) setState(() => _endDate = picked);
                        },
                      ),
                    ),
                  ],
                ),
                ElevatedButton.icon(
                  icon: const Icon(Icons.filter_alt),
                  label: const Text('Primeni filtere'),
                  onPressed: () {
                    _fetchMoodTrackers(
                      mood: _selectedMood,
                      userId: _selectedUser?.id,
                      startDate: _startDate,
                      endDate: _endDate,
                    );
                  },
                ),
                TextButton.icon(
                  icon: const Icon(Icons.clear),
                  label: const Text('Resetuj filtere'),
                  onPressed: () {
                    setState(() {
                      _selectedMood = null;
                      _selectedUser = null;
                      _startDate = null;
                      _endDate = null;
                    });
                    _fetchMoodTrackers();
                  },
                ),
              ],
            ),
          ),

          // 🔽 LISTA MOODOVA
          Expanded(
            child: FutureBuilder<List<MoodTracker>>(
              future: _moodTrackersFuture,
              builder: (context, snapshot) {
                if (snapshot.connectionState == ConnectionState.waiting) {
                  return const Center(child: CircularProgressIndicator());
                } else if (snapshot.hasError) {
                  return Center(child: Text('Greška: ${snapshot.error}'));
                } else if (!snapshot.hasData || snapshot.data!.isEmpty) {
                  return const Center(
                      child: Text('Nema zapisa o raspoloženju.'));
                }

                final moodTrackers = snapshot.data!;

                return ListView.builder(
                  itemCount: moodTrackers.length,
                  itemBuilder: (context, index) {
                    final mood = moodTrackers[index];
                    return Card(
                      margin: const EdgeInsets.symmetric(
                          horizontal: 10, vertical: 6),
                      child: ListTile(
                        title: Text(
                            '${mood.user?.firstName} ${mood.user?.lastName}'),
                        subtitle: Column(
                          crossAxisAlignment: CrossAxisAlignment.start,
                          children: [
                            Text('Raspoloženje: ${mood.mood}'),
                            Text('Opis: ${mood.description}'),
                            Text('Datum: ${_formatDate(mood.moodDate)}'),
                          ],
                        ),
                      ),
                    );
                  },
                );
              },
            ),
          )
        ],
      ),
    );
  }
}
