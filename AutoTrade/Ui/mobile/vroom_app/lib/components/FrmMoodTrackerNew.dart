import 'package:flutter/material.dart';
import 'package:intl/intl.dart';
import 'package:vroom_app/models/user.dart';
import 'package:vroom_app/services/UserService.dart';
import 'package:vroom_app/services/MoodTrackerService.dart';

class FrmMoodTrackerNew extends StatefulWidget {
  const FrmMoodTrackerNew({super.key});

  @override
  State<FrmMoodTrackerNew> createState() => _FrmMoodTrackerNewState();
}

class _FrmMoodTrackerNewState extends State<FrmMoodTrackerNew> {
  final _formKey = GlobalKey<FormState>();

  List<User> _users = [];
  User? _selectedUser;
  String? _selectedMood;
  final _descriptionController = TextEditingController();
  DateTime _selectedDate = DateTime.now();
  bool _isSubmitting = false;

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
    _loadUsers();
  }

  Future<void> _loadUsers() async {
    try {
      final users = await UserService.getUsers();
      setState(() {
        _users = users;
      });
    } catch (e) {
      ScaffoldMessenger.of(context).showSnackBar(
          SnackBar(content: Text('Greška pri učitavanju korisnika: $e')));
    }
  }

  Future<void> _submit() async {
    if (!_formKey.currentState!.validate()) return;

    setState(() => _isSubmitting = true);

    try {
      await MoodTrackerService.addMoodTracker(
        userId: _selectedUser!.id,
        mood: _selectedMood!,
        description: _descriptionController.text,
        moodDate: _selectedDate,
      );

      Navigator.pop(context, true); // osveži listu na frmMoodTracker
    } catch (e) {
      ScaffoldMessenger.of(context)
          .showSnackBar(SnackBar(content: Text(e.toString())));
    } finally {
      setState(() => _isSubmitting = false);
    }
  }

  Future<void> _selectDate() async {
    final picked = await showDatePicker(
      context: context,
      initialDate: _selectedDate,
      firstDate: DateTime(2023),
      lastDate: DateTime.now(),
    );

    if (picked != null) {
      setState(() {
        _selectedDate = picked;
      });
    }
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text('Dodaj raspoloženje'),
        iconTheme: const IconThemeData(
          color: Colors.blueAccent,
        ),
      ),
      body: Padding(
        padding: const EdgeInsets.all(16),
        child: Form(
          key: _formKey,
          child: ListView(
            children: [
              DropdownButtonFormField<User>(
                decoration: const InputDecoration(labelText: 'Korisnik'),
                items: _users.map((user) {
                  return DropdownMenuItem(
                    value: user,
                    child: Text('${user.firstName} ${user.lastName}'),
                  );
                }).toList(),
                onChanged: (value) => setState(() => _selectedUser = value),
                validator: (value) =>
                    value == null ? 'Odaberite korisnika' : null,
              ),
              const SizedBox(height: 16),
              DropdownButtonFormField<String>(
                decoration: const InputDecoration(labelText: 'Raspoloženje'),
                items: _moods.map((mood) {
                  return DropdownMenuItem(value: mood, child: Text(mood));
                }).toList(),
                onChanged: (value) => setState(() => _selectedMood = value),
                validator: (value) =>
                    value == null ? 'Odaberite raspoloženje' : null,
              ),
              const SizedBox(height: 16),
              TextFormField(
                controller: _descriptionController,
                decoration: const InputDecoration(labelText: 'Opis'),
                maxLines: 3,
                validator: (value) =>
                    value == null || value.isEmpty ? 'Unesite opis' : null,
              ),
              const SizedBox(height: 16),
              Row(
                children: [
                  Text(
                      'Datum: ${DateFormat('dd.MM.yyyy').format(_selectedDate)}'),
                  const SizedBox(width: 16),
                  ElevatedButton(
                    onPressed: _selectDate,
                    child: const Text('Odaberi datum'),
                  )
                ],
              ),
              const SizedBox(height: 24),
              ElevatedButton(
                onPressed: _isSubmitting ? null : _submit,
                child: _isSubmitting
                    ? const CircularProgressIndicator()
                    : const Text('Spremi'),
              ),
            ],
          ),
        ),
      ),
    );
  }
}
