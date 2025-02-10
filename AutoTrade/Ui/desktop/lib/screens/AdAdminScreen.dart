import 'dart:io';

import 'package:desktop_app/components/GenderSelector.dart';
import 'package:desktop_app/components/shared/SnackbarHelper.dart';
import 'package:desktop_app/models/city.dart';
import 'package:desktop_app/services/CityService.dart';
import 'package:desktop_app/services/config.dart';
import 'package:file_picker/file_picker.dart';
import 'package:flutter/material.dart';
import 'package:fluttertoast/fluttertoast.dart';
import 'package:http/http.dart' as http;

class AddAdminScreen extends StatefulWidget {
  const AddAdminScreen({Key? key}) : super(key: key);

  @override
  State<AddAdminScreen> createState() => _AddAdminScreenState();
}

class _AddAdminScreenState extends State<AddAdminScreen> {
  final _formKey = GlobalKey<FormState>();

  final TextEditingController _userNameController = TextEditingController();
  final TextEditingController _firstNameController = TextEditingController();
  final TextEditingController _lastNameController = TextEditingController();
  final TextEditingController _emailController = TextEditingController();
  final TextEditingController _phoneNumberController = TextEditingController();
  final TextEditingController _adressController = TextEditingController();
  final TextEditingController _passwordController = TextEditingController();
  final TextEditingController _passwordConfController = TextEditingController();

  String? _selectedGender;
  DateTime? _selectedDate;
  int? _selectedCityId;
  File? _selectedImage;

  List<City> _cities = [];

  @override
  void initState() {
    super.initState();
    _fetchCities();
  }

  Future<void> _fetchCities() async {
    try {
      final cityService = CityService();
      final fetched = await cityService.fetchCities();
      setState(() {
        _cities = fetched;
      });
    } catch (e) {
      Fluttertoast.showToast(
        msg: 'Greška pri dohvatu gradova.',
        backgroundColor: Colors.red,
        textColor: Colors.white,
      );
    } finally {}
  }

  String? _validateField(String? value, String fieldName) {
    if (value == null || value.isEmpty) {
      return '$fieldName je obavezno.';
    }
    return null;
  }

  String? _validateEmail(String? value) {
    if (value == null || value.isEmpty) {
      return 'Email je obavezan.';
    }
    final emailRegex = RegExp(r'^[^@]+@[^@]+\.[^@]+');
    if (!emailRegex.hasMatch(value)) {
      return 'Unesite validan email.';
    }
    return null;
  }

  String? _validatePhone(String? value) {
    if (value == null || value.isEmpty) {
      return 'Broj telefona je obavezan.';
    }
    final phoneRegex = RegExp(r'^\+387\d{8,9}$');
    if (!phoneRegex.hasMatch(value)) {
      return 'Format: +387XXXXXXXX (8-9 brojeva).';
    }
    return null;
  }

  String? _validatePassword(String? value) {
    if (value == null || value.isEmpty) {
      return 'Lozinka je obavezna.';
    }
    if (value.length < 6) {
      return 'Lozinka mora imati bar 6 karaktera.';
    }
    return null;
  }

  Future<void> _pickDate() async {
    final now = DateTime.now();
    final newDate = await showDatePicker(
      context: context,
      initialDate: now.subtract(const Duration(days: 6570)), // 18 godina unazad
      firstDate: DateTime(1900),
      lastDate: now,
    );
    if (newDate != null) {
      setState(() {
        _selectedDate = newDate;
      });
    }
  }

  Future<void> _pickImage() async {
    final result = await FilePicker.platform.pickFiles(
      type: FileType.image,
    );

    if (result != null && result.files.single.path != null) {
      setState(() {
        _selectedImage = File(result.files.single.path!);
      });
    }
  }

  void _removeSelectedImage() {
    setState(() {
      _selectedImage = null;
    });
  }

  Future<void> _registerUser() async {
    if (!_formKey.currentState!.validate()) {
      return;
    }

    if (_passwordController.text != _passwordConfController.text) {
      _showSnackBar(context, 'Lozinke se ne poklapaju!');
      return;
    }

    if (_selectedDate == null) {
      _showSnackBar(context, 'Morate izabrati datum rođenja!',
          backgroundColor: Colors.red);

      return;
    }

    if (_selectedCityId == null) {
      _showSnackBar(context, 'Morate izabrati grad!',
          backgroundColor: Colors.red);
      return;
    }

    try {
      final url = Uri.parse('$baseUrl/User/admin');
      final request = http.MultipartRequest('POST', url);
      request.headers['Content-Type'] = 'multipart/form-data';

      request.fields['userName'] = _userNameController.text;
      request.fields['firstName'] = _firstNameController.text;
      request.fields['lastName'] = _lastNameController.text;
      request.fields['email'] = _emailController.text;
      request.fields['phoneNumber'] = _phoneNumberController.text;
      request.fields['adress'] = _adressController.text;
      request.fields['gender'] = _selectedGender ?? '';
      request.fields['password'] = _passwordController.text;
      request.fields['passwordConfirmation'] = _passwordConfController.text;
      request.fields['dateOfBirth'] = _selectedDate!.toIso8601String();
      request.fields['cityId'] = _selectedCityId.toString();

      if (_selectedImage != null) {
        final fileBytes = await _selectedImage!.readAsBytes();
        final fileName = _selectedImage!.path.split('/').last;
        final multiPart = http.MultipartFile.fromBytes(
          'profilePicture',
          fileBytes,
          filename: fileName,
        );
        request.files.add(multiPart);
      }

      final responseStream = await request.send();
      final response = await http.Response.fromStream(responseStream);

      if (response.statusCode == 200 || response.statusCode == 201) {
        SnackbarHelper.showSnackbar(context, 'Uspešno kreiran Admin!',
            backgroundColor: Colors.green);
        // _showSnackBar(context, 'Uspešno kreiran Admin!',
        //     backgroundColor: Colors.green);

        Navigator.pushReplacementNamed(context, '/');
      } else {
        final responseBody = response.body;

        // Definišite poruku greške
        String errorMessage = 'Došlo je do greške. Pokušajte ponovo.';

        // Ako odgovor sadrži specifičan tekst, prilagodite poruku greške
        if (responseBody.contains(
            'A user with the same username or email already exists')) {
          errorMessage =
              'Korisnik sa istim korisničkim imenom ili emailom već postoji.';
        } else if (responseBody.contains('Internal Server Error')) {
          errorMessage = 'Greška na serveru. Pokušajte ponovo kasnije.';
        }

        SnackbarHelper.showSnackbar(context, errorMessage,
            backgroundColor: Colors.red);
        // _showSnackBar(context, errorMessage, backgroundColor: Colors.red);
      }
    } catch (e) {
      print('Greška: $e');
      String errorMessage = 'Došlo je do greške. Pokušajte ponovo.';

      if (e
          .toString()
          .contains('A user with the same username or email already exists')) {
        errorMessage =
            'Korisnik sa istim korisničkim imenom ili emailom već postoji.';
      }

      SnackbarHelper.showSnackbar(context, errorMessage,
          backgroundColor: Colors.red);

      // _showSnackBar(context, errorMessage, backgroundColor: Colors.red);
    }
  }

  void _showSnackBar(BuildContext context, String message,
      {Color backgroundColor = Colors.red}) {
    ScaffoldMessenger.of(context).showSnackBar(
      SnackBar(
        content: Text(message),
        backgroundColor: backgroundColor,
        behavior: SnackBarBehavior.floating,
        duration: const Duration(seconds: 3),
      ),
    );
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text(
          "Dodaj Admina",
          style: TextStyle(color: Colors.white),
        ),
        backgroundColor: Colors.blueGrey[900],
        iconTheme: const IconThemeData(
          color: Colors.white,
        ),
      ),
      body: Center(
        child: ConstrainedBox(
          constraints:
              const BoxConstraints(maxWidth: 600), // Maksimalna širina forme
          child: Card(
            elevation: 4,
            margin: const EdgeInsets.all(16),
            child: Padding(
              padding: const EdgeInsets.all(16),
              child: Form(
                key: _formKey,
                child: ListView(
                  shrinkWrap: true, // Sprečava nepotrebno širenje liste
                  children: [
                    TextFormField(
                      controller: _userNameController,
                      decoration:
                          const InputDecoration(labelText: 'Korisničko ime'),
                      validator: (value) =>
                          _validateField(value, 'Korisničko ime'),
                    ),
                    const SizedBox(height: 16),
                    TextFormField(
                      controller: _firstNameController,
                      decoration: const InputDecoration(labelText: 'Ime'),
                      validator: (value) => _validateField(value, 'Ime'),
                    ),
                    const SizedBox(height: 16),
                    TextFormField(
                      controller: _lastNameController,
                      decoration: const InputDecoration(labelText: 'Prezime'),
                      validator: (value) => _validateField(value, 'Prezime'),
                    ),
                    const SizedBox(height: 16),
                    TextFormField(
                      controller: _emailController,
                      decoration: const InputDecoration(labelText: 'Email'),
                      validator: (value) => _validateEmail(value),
                    ),
                    const SizedBox(height: 16),
                    TextFormField(
                      controller: _phoneNumberController,
                      decoration:
                          const InputDecoration(labelText: 'Broj telefona'),
                      validator: (value) => _validatePhone(value),
                    ),
                    const SizedBox(height: 16),
                    TextFormField(
                      controller: _adressController,
                      decoration: const InputDecoration(labelText: 'Adresa'),
                      validator: (value) => _validateField(value, 'Adresa'),
                    ),
                    GenderSelector(
                      selectedGender: _selectedGender,
                      onGenderSelected: (gender) {
                        setState(() {
                          _selectedGender = gender;
                        });
                      },
                    ),
                    TextFormField(
                      controller: _passwordController,
                      decoration: const InputDecoration(labelText: 'Lozinka'),
                      obscureText: true,
                      validator: _validatePassword,
                    ),
                    const SizedBox(height: 16),
                    TextFormField(
                      controller: _passwordConfController,
                      decoration:
                          const InputDecoration(labelText: 'Potvrda lozinke'),
                      obscureText: true,
                      validator: _validatePassword,
                    ),
                    const SizedBox(height: 16),
                    DropdownButtonFormField<int>(
                      value: _selectedCityId,
                      items: _cities
                          .map((city) => DropdownMenuItem<int>(
                                value: city.id,
                                child: Text(city.title),
                              ))
                          .toList(),
                      onChanged: (value) {
                        setState(() {
                          _selectedCityId = value;
                        });
                      },
                      decoration: const InputDecoration(labelText: 'Grad'),
                    ),
                    const SizedBox(height: 16),
                    ElevatedButton(
                      onPressed: _pickDate,
                      child: Text(_selectedDate == null
                          ? 'Izaberite datum rođenja'
                          : 'Datum rođenja: ${_selectedDate!.toIso8601String().split('T')[0]}'),
                    ),
                    const SizedBox(height: 16),
                    if (_selectedImage != null)
                      Stack(
                        children: [
                          Image.file(_selectedImage!, height: 150),
                          Positioned(
                            right: 0,
                            top: 0,
                            child: IconButton(
                              icon: const Icon(Icons.close, color: Colors.red),
                              onPressed: _removeSelectedImage,
                            ),
                          ),
                        ],
                      ),
                    const SizedBox(height: 16),
                    ElevatedButton(
                      onPressed: _pickImage,
                      child: const Text('Dodaj Sliku'),
                    ),
                    const SizedBox(height: 16),
                    ElevatedButton(
                      onPressed: _registerUser,
                      child: const Text('Dodaj Admina'),
                    ),
                  ],
                ),
              ),
            ),
          ),
        ),
      ),
    );
  }
}
