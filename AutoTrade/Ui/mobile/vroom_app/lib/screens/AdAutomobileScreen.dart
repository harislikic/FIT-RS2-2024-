import 'package:flutter/material.dart';
import 'package:flutter/services.dart';
import 'package:image_picker/image_picker.dart';
import 'package:vroom_app/components/ImagePicker.dart';
import 'package:vroom_app/components/LoginButton.dart';
import 'package:vroom_app/components/shared/DatePicker.dart';
import 'package:vroom_app/components/shared/ToastUtils.dart';
import 'package:vroom_app/screens/MyAutomobileAdsScreen.dart';
import 'package:vroom_app/services/AutmobileDropDownService.dart';
import 'package:vroom_app/services/AutomobileAdService.dart';
import 'package:vroom_app/models/carBrand.dart';
import 'package:vroom_app/models/carCategory.dart';
import 'package:vroom_app/models/carModel.dart';
import 'package:vroom_app/models/fuelType.dart';
import 'package:vroom_app/models/transmissionType.dart';
import 'package:vroom_app/models/vehicleCondition.dart';

import '../models/equipment.dart';
import '../services/AuthService.dart';

class AddAutomobileScreen extends StatefulWidget {
  const AddAutomobileScreen({Key? key}) : super(key: key);

  @override
  _AddAutomobileScreenState createState() => _AddAutomobileScreenState();
}

class _AddAutomobileScreenState extends State<AddAutomobileScreen> {
  bool _isLoading = false;
  final _formKey = GlobalKey<FormState>();
  bool _isLoggedIn = false;

  String? _title;
  String? _description;
  double? _price;
  int? _mileage;
  int? _yearOfManufacture;
  bool _isRegistered = false;
  DateTime? _registrationExpirationDate;
  DateTime? _lastSmallService;
  DateTime? _lastBigService;
  String? _carBrandId;
  String? _carCategoryId;
  String? _carModelId;
  String? _fuelTypeId;
  String? _transmissionTypeId;
  List<int> _equipmentIds = [];
  List<String> _selectedEquipmentNames = [];
  int? _enginePower;
  int? _numberOfDoors;
  double? _cubicCapacity;
  int? _horsePower;
  String? _color;
  String? _vehicleConditionId;

  List<Equipment> _equipment = [];
  List<CarBrand> _carBrands = [];
  List<CarCategory> _carCategories = [];
  List<CarModel> _carModels = [];
  List<FuelType> _fuelTypes = [];
  List<TransmissionType> _transmissionTypes = [];
  List<VehicleCondition> _vehicleConditions = [];
  List<XFile> _imageFiles = [];
  final AutomobileDropDownService _dropDownService =
      AutomobileDropDownService();

  Future<void> _fetchAutomobileDropDownData() async {
    try {
      final carBrands = await _dropDownService.fetchCarBrands();
      final carCategories = await _dropDownService.fetchCarCategories();
      final carModels = await _dropDownService.fetchCarModels();
      final fuelTypes = await _dropDownService.fetchFuelTypes();
      final transmissionTypes = await _dropDownService.fetchTransmissionTypes();
      final vehicleConditions = await _dropDownService.fetchVehicleConditions();
      final equipments = await _dropDownService.fetchEquipments();

      setState(() {
        _carBrands = carBrands;
        _carCategories = carCategories;
        _carModels = carModels;
        _fuelTypes = fuelTypes;
        _transmissionTypes = transmissionTypes;
        _vehicleConditions = vehicleConditions;
        _equipment = equipments;
      });
    } catch (e) {
      print('Failed to fetch dropDowns data: $e');
    }
  }

  @override
  void initState() {
    super.initState();
    _checkLoginState();
    _fetchAutomobileDropDownData();
  }

  Future<void> _checkLoginState() async {
    final bool result = await AuthService.checkIfUserIsLoggedIn();
    setState(() {
      _isLoggedIn = result;
    });
  }

  Future<void> _selectDate(BuildContext context, DateTime? initialDate,
      Function(DateTime?) onDatePicked) async {
    final DateTime? picked = await showDatePicker(
      context: context,
      initialDate: initialDate ?? DateTime.now(),
      firstDate: DateTime(2000),
      lastDate: DateTime(2101),
    );
    if (picked != null && picked != initialDate) {
      onDatePicked(picked);
    }
  }

  String? formatDateAds(DateTime? date) {
    if (date == null) return null;
    return "${date.year}-${date.month.toString().padLeft(2, '0')}-${date.day.toString().padLeft(2, '0')}";
  }

  void _submitForm() async {
    if (_formKey.currentState?.validate() ?? false) {
      _formKey.currentState?.save();

      setState(() {
        _isLoading = true;
      });

      final userId = await AuthService.getUserId();
      final authHeaders = await AuthService.getAuthHeaders();

      Map<String, dynamic> adData = {
        'Title': _title,
        'Description': _description,
        'Price': _price,
        'Milage': _mileage,
        'YearOfManufacture': _yearOfManufacture,
        'Registered': _isRegistered,
        'RegistrationExpirationDate':
            formatDateAds(_registrationExpirationDate),
        'Last_Small_Service': formatDateAds(_lastSmallService),
        'Last_Big_Service': formatDateAds(_lastBigService),
        'UserId': userId,
        'CarBrandId': _carBrandId,
        'CarCategoryId': _carCategoryId,
        'CarModelId': _carModelId,
        'FuelTypeId': _fuelTypeId,
        'TransmissionTypeId': _transmissionTypeId,
        'EnginePower': _enginePower,
        'NumberOfDoors': _numberOfDoors,
        'CubicCapacity': _cubicCapacity,
        'HorsePower': _horsePower,
        'Color': _color,
        'VehicleConditionId': _vehicleConditionId,
      };

      for (int i = 0; i < _equipmentIds.length; i++) {
        adData['EquipmentIds[$i]'] = _equipmentIds[i];
      }

      try {
        bool success = await AutomobileAdService()
            .createAutomobileAd(adData, authHeaders, _imageFiles);

        if (success) {
          ToastUtils.showToast(
              message:
                  "Vaš oglas je uspješno kreiran i poslan na pregled. Administratori će ga pregledati i odobriti prije objave.");

          Navigator.pushReplacement(
            context,
            MaterialPageRoute(builder: (context) => MyAutomobileAdsScreen()),
          );
        } else {
          ToastUtils.showErrorToast(
              message: "Greška prilikom kreiranja oglasa:");
        }
      } catch (e) {
        print('Error creating ad: $e');
        ToastUtils.showErrorToast(message: "Greška prilikom kreiranja oglasa:");
      } finally {
        setState(() {
          _isLoading = false;
        });
      }
    }
  }

  Future<void> _openEquipmentSelectionModal(BuildContext context) async {
    final selected = await showDialog<List<int>>(
      context: context,
      builder: (context) {
        return AlertDialog(
          title: Text('Odaberi opremu'),
          content: StatefulBuilder(
            builder: (context, setState) {
              return SingleChildScrollView(
                child: Column(
                  children: _equipment.map((equipment) {
                    return CheckboxListTile(
                      title: Text(equipment.name),
                      value: _equipmentIds.contains(equipment.id),
                      onChanged: (bool? selected) {
                        setState(() {
                          if (selected ?? false) {
                            _equipmentIds.add(equipment.id);
                          } else {
                            _equipmentIds.remove(equipment.id);
                          }
                        });
                      },
                    );
                  }).toList(),
                ),
              );
            },
          ),
          actions: [
            TextButton(
              onPressed: () {
                Navigator.of(context).pop(_equipmentIds);
              },
              child: Text('Završi'),
            ),
          ],
        );
      },
    );

    if (selected != null) {
      setState(() {
        _equipmentIds = selected;

        _selectedEquipmentNames = _equipment
            .where((equipment) => _equipmentIds.contains(equipment.id))
            .map((e) => e.name)
            .toList();
      });
    }
  }

  @override
  Widget build(BuildContext context) {
    if (!_isLoggedIn) {
      return Scaffold(
        appBar: AppBar(
          title: const Text('Dodaj oglas'),
          iconTheme: const IconThemeData(
            color: Colors.blue,
          ),
        ),
        body: Center(
          child: Column(
            mainAxisSize: MainAxisSize.min,
            children: [
              const Text(
                "Morate se prijaviti da biste dodali oglas.",
                style: TextStyle(
                  fontSize: 18,
                  fontWeight: FontWeight.bold,
                  color: Colors.black54,
                ),
                textAlign: TextAlign.center,
              ),
              const SizedBox(height: 16),
              LoginButton(
                onPressed: () {
                  Navigator.pushReplacementNamed(context, '/login');
                },
              ),
            ],
          ),
        ),
      );
    }
    return Scaffold(
      appBar: AppBar(
        title: const Text('Dodaj oglas'),
        iconTheme: const IconThemeData(
          color: Colors.blue,
        ),
      ),
      body: SingleChildScrollView(
        padding: const EdgeInsets.all(16.0),
        child: Form(
          key: _formKey,
          child: Column(
            children: [
              TextFormField(
                decoration: const InputDecoration(labelText: 'Naziv'),
                onSaved: (value) => _title = value,
                validator: (value) =>
                    value?.isEmpty ?? true ? 'Unesite naziv' : null,
              ),
              TextFormField(
                decoration: const InputDecoration(labelText: 'Detaljan opis'),
                onSaved: (value) => _description = value,
                validator: (value) =>
                    value?.isEmpty ?? true ? 'Unesite opis' : null,
                maxLines: null,
                keyboardType: TextInputType.multiline,
                textInputAction: TextInputAction.newline,
              ),
              TextFormField(
                decoration: const InputDecoration(labelText: 'Cijena'),
                onSaved: (value) => _price = double.tryParse(value ?? ''),
                validator: (value) =>
                    value?.isEmpty ?? true ? 'Unesite cijenu' : null,
                keyboardType: TextInputType.number,
              ),
              TextFormField(
                decoration: const InputDecoration(labelText: 'Kilometraža'),
                onSaved: (value) => _mileage = int.tryParse(value ?? ''),
                validator: (value) =>
                    value?.isEmpty ?? true ? 'Unesite kilometražu' : null,
                keyboardType: TextInputType.number,
              ),
              TextFormField(
                decoration:
                    const InputDecoration(labelText: 'Godina proizvodnje'),
                keyboardType: TextInputType.number,
                inputFormatters: [
                  FilteringTextInputFormatter.digitsOnly,
                  LengthLimitingTextInputFormatter(4),
                ],
                onSaved: (value) =>
                    _yearOfManufacture = int.tryParse(value ?? ''),
                validator: (value) {
                  if (value == null || value.isEmpty) {
                    return 'Unesite godinu proizvodnje';
                  }
                  if (int.tryParse(value) == null) {
                    return 'Unesite ispravan broj';
                  }
                  return null;
                },
              ),
              TextFormField(
                decoration: const InputDecoration(labelText: 'Snaga motora'),
                onSaved: (value) => _enginePower = int.tryParse(value ?? ''),
                validator: (value) =>
                    value?.isEmpty ?? true ? 'Unesite snagu motora' : null,
                keyboardType: TextInputType.number,
              ),
              TextFormField(
                decoration: const InputDecoration(labelText: 'Broj vrata'),
                onSaved: (value) => _numberOfDoors = int.tryParse(value ?? ''),
                keyboardType: TextInputType.number,
              ),
              TextFormField(
                decoration: const InputDecoration(labelText: 'Kubikaža'),
                onSaved: (value) {
                  if (value != null) {
                    _cubicCapacity = double.tryParse(value) ?? 0.0;
                  }
                },
                validator: (value) {
                  if (value == null || value.isEmpty) {
                    return 'Unesi kubikažu';
                  }

                  final regExp = RegExp(r'^\d+(\.\d+)?$');

                  if (!regExp.hasMatch(value)) {
                    return 'Kubikaža mora biti u formatu X.Y (npr. 1.9)';
                  }

                  return null;
                },
                keyboardType: TextInputType.numberWithOptions(decimal: true),
              ),
              TextFormField(
                decoration: const InputDecoration(labelText: 'Konjskih snaga'),
                onSaved: (value) => _horsePower = int.tryParse(value ?? ''),
                validator: (value) =>
                    value?.isEmpty ?? true ? 'Unesi konjske snage' : null,
                keyboardType: TextInputType.number,
              ),
              TextFormField(
                decoration: const InputDecoration(labelText: 'Boja'),
                onSaved: (value) => _color = value,
                keyboardType: TextInputType.text,
              ),
              Column(
                children: [
                  DatePicker(
                    label: 'Datum isteka registracije',
                    selectedDate: _registrationExpirationDate,
                    onDatePicked: (pickedDate) {
                      setState(() {
                        _registrationExpirationDate = pickedDate;
                      });
                    },
                  ),
                  DatePicker(
                    label: 'Datum malog servisa',
                    selectedDate: _lastSmallService,
                    onDatePicked: (pickedDate) {
                      setState(() {
                        _lastSmallService = pickedDate;
                      });
                    },
                  ),
                  DatePicker(
                    label: 'Datum velikog servisa',
                    selectedDate: _lastBigService,
                    onDatePicked: (pickedDate) {
                      setState(() {
                        _lastBigService = pickedDate;
                      });
                    },
                  ),
                ],
              ),
              DropdownButtonFormField<String>(
                value: _carBrandId,
                onChanged: (value) => setState(() => _carBrandId = value),
                items: _carBrands.map((brand) {
                  return DropdownMenuItem<String>(
                    value: brand.id.toString(),
                    child: Text(brand.name),
                  );
                }).toList(),
                decoration: const InputDecoration(labelText: 'Brend'),
                isExpanded: true,
                menuMaxHeight: 300,
                validator: (value) {
                  if (value == null || value.isEmpty) {
                    return 'Obavezno polje';
                  }
                  return null;
                },
              ),
              DropdownButtonFormField<String>(
                value: _carModelId,
                onChanged: (value) => setState(() => _carModelId = value),
                items: _carModels.map((model) {
                  return DropdownMenuItem<String>(
                    value: model.id.toString(),
                    child: Text(model.name),
                  );
                }).toList(),
                decoration: const InputDecoration(labelText: 'Model'),
                isExpanded: true,
                menuMaxHeight: 300,
                validator: (value) {
                  if (value == null || value.isEmpty) {
                    return 'Obavezno polje';
                  }
                  return null;
                },
              ),
              DropdownButtonFormField<String>(
                value: _carCategoryId,
                onChanged: (value) => setState(() => _carCategoryId = value),
                items: _carCategories.map((category) {
                  return DropdownMenuItem<String>(
                    value: category.id.toString(),
                    child: Text(category.name),
                  );
                }).toList(),
                decoration: const InputDecoration(labelText: 'Kateegorija'),
                isExpanded: true,
                menuMaxHeight: 300,
                validator: (value) {
                  if (value == null || value.isEmpty) {
                    return 'Obavezno polje';
                  }
                  return null;
                },
              ),
              DropdownButtonFormField<String>(
                value: _fuelTypeId,
                onChanged: (value) => setState(() => _fuelTypeId = value),
                items: _fuelTypes.map((fuel) {
                  return DropdownMenuItem<String>(
                    value: fuel.id.toString(),
                    child: Text(fuel.name),
                  );
                }).toList(),
                decoration: const InputDecoration(labelText: 'Tip goriva'),
                isExpanded: true,
                menuMaxHeight: 300,
                validator: (value) {
                  if (value == null || value.isEmpty) {
                    return 'Obavezno polje';
                  }
                  return null;
                },
              ),
              DropdownButtonFormField<String>(
                value: _transmissionTypeId,
                onChanged: (value) =>
                    setState(() => _transmissionTypeId = value),
                items: _transmissionTypes.map((transmission) {
                  return DropdownMenuItem<String>(
                    value: transmission.id.toString(),
                    child: SizedBox(
                      width: 250,
                      child: Text(
                        transmission.name,
                        overflow: TextOverflow.ellipsis,
                      ),
                    ),
                  );
                }).toList(),
                decoration:
                    const InputDecoration(labelText: 'Tip transimisije'),
                isExpanded: true,
                menuMaxHeight: 300,
                validator: (value) {
                  if (value == null || value.isEmpty) {
                    return 'Obavezno polje';
                  }
                  return null;
                },
              ),
              DropdownButtonFormField<String>(
                value: _vehicleConditionId,
                onChanged: (value) =>
                    setState(() => _vehicleConditionId = value),
                items: _vehicleConditions.map((condition) {
                  return DropdownMenuItem<String>(
                    value: condition.id.toString(),
                    child: Text(condition.name),
                  );
                }).toList(),
                decoration: const InputDecoration(labelText: 'Stanje'),
                isExpanded: true,
                menuMaxHeight: 300,
                validator: (value) {
                  if (value == null || value.isEmpty) {
                    return 'Obavezno polje';
                  }
                  return null;
                },
              ),
              CheckboxListTile(
                title: const Text('Registrovan'),
                value: _isRegistered,
                onChanged: (bool? newValue) {
                  setState(() {
                    _isRegistered = newValue ?? false;
                  });
                },
                controlAffinity: ListTileControlAffinity.leading,
                activeColor: Colors.blue,
                checkColor: Colors.white,
              ),
              Padding(
                padding: const EdgeInsets.only(top: 16.0),
                child: ElevatedButton(
                  onPressed: () {
                    _openEquipmentSelectionModal(context);
                  },
                  style: ElevatedButton.styleFrom(
                    foregroundColor: Colors.black,
                    backgroundColor: Colors.white,
                    side: const BorderSide(
                      color: Color(0xFF263238),
                      width: 2,
                    ),
                    shape: RoundedRectangleBorder(
                      borderRadius: BorderRadius.circular(8),
                    ),
                  ),
                  child: const Text('Dodaj opremu'),
                ),
              ),
              Padding(
                padding: const EdgeInsets.only(top: 16.0),
                child: _selectedEquipmentNames.isEmpty
                    ? const Text('')
                    : Wrap(
                        spacing: 8.0,
                        children: _selectedEquipmentNames.map((equipment) {
                          return Chip(
                            label: Row(
                              mainAxisSize: MainAxisSize.min,
                              children: [
                                Text(
                                  equipment,
                                  style: const TextStyle(
                                    color: Colors.black,
                                  ),
                                ),
                                const SizedBox(width: 4),
                                const Icon(
                                  Icons.check,
                                  color: Colors.black,
                                  size: 18,
                                ),
                              ],
                            ),
                            backgroundColor: Colors.white,
                            shape: const StadiumBorder(
                              side: BorderSide(
                                color: Color(0xFF263238),
                                width: 2,
                              ),
                            ),
                          );
                        }).toList(),
                      ),
              ),
              const SizedBox(
                height: 16.0,
              ),
              ImagePickerWidget(
                onImagesPicked: (images) {
                  setState(() {
                    _imageFiles = images;
                  });
                },
              ),
              const SizedBox(
                height: 16.0,
              ),
              ElevatedButton(
                onPressed: _isLoading ? null : _submitForm,
                style: ElevatedButton.styleFrom(
                  foregroundColor: Colors.black,
                  backgroundColor: Colors.white,
                  side: const BorderSide(
                    color: Color(0xFF263238),
                    width: 2,
                  ),
                  shape: RoundedRectangleBorder(
                    borderRadius: BorderRadius.circular(8),
                  ),
                  elevation: 0,
                ),
                child: _isLoading
                    ? const SizedBox(
                        width: 20,
                        height: 20,
                        child: CircularProgressIndicator(
                          color: Colors.blueGrey,
                          strokeWidth: 2,
                        ),
                      )
                    : const Text(
                        'Objavi',
                        style: TextStyle(color: Colors.black),
                      ),
              )
            ],
          ),
        ),
      ),
    );
  }
}
