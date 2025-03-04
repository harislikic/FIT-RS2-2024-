import 'dart:io';

import 'package:flutter/foundation.dart';
import 'package:flutter/material.dart';
import 'package:image_picker/image_picker.dart';
import 'package:vroom_app/components/shared/ToastUtils.dart';
import 'package:vroom_app/models/canton.dart';
import 'package:vroom_app/models/city.dart';
import 'package:vroom_app/services/AutmobileDropDownService.dart';
import 'package:vroom_app/services/UserService.dart';
import 'package:vroom_app/services/config.dart';
import 'package:vroom_app/utils/helpers.dart';

class EditProfileScreen extends StatefulWidget {
  final Map<String, dynamic> userProfile;

  const EditProfileScreen({Key? key, required this.userProfile})
      : super(key: key);

  @override
  State<EditProfileScreen> createState() => _EditProfileScreenState();
}

class _EditProfileScreenState extends State<EditProfileScreen> {
  late Map<String, dynamic> editedProfile;
  List<City> cities = [];
  City? selectedCity;
  bool isLoadingCities = true;
  String? profileImagePath;
  bool isLocalImage = false;
  final _formKey = GlobalKey<FormState>();

  bool isSaveButtonDisabled = true;

  @override
  void initState() {
    super.initState();
    editedProfile = Map.from(widget.userProfile);
    profileImagePath = widget.userProfile["profilePicture"];
    fetchCities();
  }

  void _checkIfChangesMade() {
    bool changesMade =
        !mapEquals(editedProfile, widget.userProfile) || isLocalImage;
    setState(() {
      isSaveButtonDisabled = !changesMade;
    });
  }

  Future<void> fetchCities() async {
    try {
      final service = AutomobileDropDownService();
      final fetchedCities = await service.fetchCities();
      setState(() {
        cities = fetchedCities;
        final cityId = widget.userProfile["cityId"];
        if (cityId != null) {
          selectedCity = cities.firstWhere(
            (city) => city.id == cityId,
            orElse: () => City(
              id: cityId,
              title: "Nepoznat grad",
              canton: Canton(
                id: 0,
                title: "Nepoznat kanton",
              ),
            ),
          );
        }
        isLoadingCities = false;
      });
    } catch (e) {
      setState(() {
        isLoadingCities = false;
      });
    }
  }

  Future<void> pickProfileImage() async {
    final ImagePicker picker = ImagePicker();
    final XFile? image = await picker.pickImage(source: ImageSource.gallery);

    if (image != null) {
      setState(() {
        profileImagePath = image.path;
        isLocalImage = true;
        editedProfile["profilePicture"] = image.path;
        _checkIfChangesMade();
      });
    }
  }

  void _saveChanges() async {
    if (!_formKey.currentState!.validate()) {
      return;
    }

    try {
      editedProfile["cityId"] = selectedCity?.id;
      editedProfile.remove("city");

      File? profilePictureFile;
      bool isImageUpdated = false;

      if (isLocalImage && profileImagePath != null) {
        profilePictureFile = File(profileImagePath!);
        isImageUpdated = true;
      }

      final response = await UserService.updateUserProfile(
        userId: widget.userProfile["id"],
        userData: editedProfile,
        profilePicture: profilePictureFile,
        isImageUpdated: isImageUpdated,
      );

      if (response != null) {
        ToastUtils.showToast(message: "Profil uspešno ažuriran!");
        Navigator.pop(context, response);
      } else {
        ToastUtils.showErrorToast(message: "Profil nije ažuriran!");
      }
    } catch (e) {
      ToastUtils.showErrorToast(message: "Greška: $e");
    }
  }

  Widget _buildDatePickerField(String label, String key) {
    return Padding(
      padding: const EdgeInsets.symmetric(vertical: 8.0),
      child: InkWell(
        onTap: () async {
          final DateTime? pickedDate = await showDatePicker(
            context: context,
            initialDate: editedProfile[key] != null
                ? DateTime.parse(editedProfile[key])
                : DateTime.now(),
            firstDate: DateTime(1900),
            lastDate: DateTime.now(),
          );

          if (pickedDate != null) {
            setState(() {
              editedProfile[key] = pickedDate.toIso8601String();
            });
          }
        },
        child: InputDecorator(
          decoration: InputDecoration(
            labelText: label,
            border: const OutlineInputBorder(),
          ),
          child: Text(
            editedProfile[key] != null
                ? formatDate(editedProfile[key])
                : "Odaberite datum",
            style: const TextStyle(fontSize: 16),
          ),
        ),
      ),
    );
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
        appBar: AppBar(
          title: const Text("Uredi profil"),
          backgroundColor: Colors.blueGrey[900],
          iconTheme: const IconThemeData(
            color: Colors.blueAccent,
          ),
          actions: [
            TextButton.icon(
              icon: Icon(
                Icons.save,
                color: isSaveButtonDisabled
                    ? Colors.grey
                    : Colors.blueAccent, // Siva ako je disabled
              ),
              label: Text(
                'Sačuvaj',
                style: TextStyle(
                  color: isSaveButtonDisabled
                      ? Colors.grey
                      : Colors.blueAccent, // Siva ako je disabled
                ),
              ),
              onPressed: isSaveButtonDisabled ? null : _saveChanges,
            ),
          ],
        ),
        body: isLoadingCities
            ? const Center(child: CircularProgressIndicator())
            : SingleChildScrollView(
                padding: const EdgeInsets.all(16.0),
                child: Form(
                  key: _formKey,
                  child: Column(
                    children: [
                      _buildProfileImage(),
                      _buildEditableField("Ime", "firstName"),
                      _buildEditableField("Prezime", "lastName"),
                      _buildEditableField("Email", "email", isEmail: true),
                      _buildEditableField("Telefon", "phoneNumber",
                          isPhone: true),
                      _buildEditableField("Adresa", "adress"),
                      _buildDatePickerField("Datum rođenja", "dateOfBirth"),
                      const SizedBox(height: 16),
                      _buildCityDropdown(),
                    ],
                  ),
                ),
              ));
  }

  Widget _buildProfileImage() {
    return Center(
      child: Column(
        children: [
          CircleAvatar(
            radius: 50,
            backgroundImage: profileImagePath != null
                ? (isLocalImage
                    ? FileImage(File(profileImagePath!))
                    : NetworkImage("$baseUrl$profileImagePath")
                        as ImageProvider<Object>)
                : const AssetImage('assets/default_avatar.png')
                    as ImageProvider<Object>,
          ),
          TextButton.icon(
            onPressed: pickProfileImage,
            icon: const Icon(Icons.camera_alt),
            label: const Text("Promijeni sliku"),
          ),
        ],
      ),
    );
  }

  Widget _buildEditableField(String label, String key,
      {bool isEmail = false, bool isPhone = false}) {
    return Padding(
      padding: const EdgeInsets.symmetric(vertical: 8.0),
      child: TextFormField(
        decoration: InputDecoration(
          labelText: label,
          border: const OutlineInputBorder(),
        ),
        initialValue: editedProfile[key],
        validator: (value) {
          if (value == null || value.isEmpty) {
            return '$label je obavezno polje';
          }
          if (isEmail &&
              !RegExp(r'^[^@\s]+@[^@\s]+\.[^@\s]+').hasMatch(value)) {
            return 'Unesite validan email';
          }
          if (isPhone && !RegExp(r'^\+387[0-9]{8,12}$').hasMatch(value)) {
            return 'Unesite validan broj telefona u formatu +387XXXXXXXX\n(Min 8 - Max 12 cifara nakon +387)';
          }

          return null;
        },
        onChanged: (value) {
          editedProfile[key] = value;
          _checkIfChangesMade();
        },
      ),
    );
  }

  Widget _buildCityDropdown() {
    return Padding(
      padding: const EdgeInsets.symmetric(vertical: 8.0),
      child: DropdownButtonHideUnderline(
        // Hides the default underline
        child: DropdownButtonFormField<City>(
          value: selectedCity,
          isExpanded: true,
          decoration: const InputDecoration(
            labelText: "Grad",
            border: OutlineInputBorder(),
          ),
          items: cities.map((city) {
            return DropdownMenuItem<City>(
              value: city,
              child: Text(city.title),
            );
          }).toList(),
          onChanged: (City? newCity) {
            setState(() {
              selectedCity = newCity;
              _checkIfChangesMade();
            });
          },
          validator: (value) => value == null ? "Grad je obavezan" : null,
          menuMaxHeight: 400, // Limits the dropdown menu height
        ),
      ),
    );
  }
}
