import 'package:flutter/material.dart';
import 'package:desktop_app/models/carBrand.dart';
import 'package:desktop_app/services/carBrandService.dart';
import 'package:desktop_app/components/shared/SnackbarHelper.dart';

class CarBrandList extends StatefulWidget {
  const CarBrandList({super.key});

  @override
  State<CarBrandList> createState() => _CarBrandListState();
}

class _CarBrandListState extends State<CarBrandList> {
  final CarBrandService _carBrandService = CarBrandService();
  final TextEditingController _newBrandController = TextEditingController();
  final Map<int, TextEditingController> _editControllers = {};
  final Map<int, String?> _editErrors = {};
  final Set<int> _editingIds = {};
  String? _newBrandError;

  List<CarBrand> _carBrands = [];
  bool _isLoading = false;

  @override
  void initState() {
    super.initState();
    _newBrandController.addListener(() => setState(() {}));
    _loadCarBrands();
  }

  Future<void> _loadCarBrands() async {
    setState(() => _isLoading = true);
    try {
      final brands = await _carBrandService.fetchCarBrands();
      setState(() {
        _carBrands = brands;
        _editControllers.clear();
        _editErrors.clear();
        _editingIds.clear();
        for (var brand in brands) {
          _editControllers[brand.id] = TextEditingController(text: brand.name);
          _editErrors[brand.id] = null;
        }
      });
    } catch (e) {
      SnackbarHelper.showSnackbar(context, 'Greška pri učitavanju: $e');
    } finally {
      setState(() => _isLoading = false);
    }
  }

  Future<void> _addCarBrand() async {
    final name = _newBrandController.text.trim();
    if (name.isEmpty) {
      setState(() => _newBrandError = 'Ime brenda je obavezno.');
      return;
    }

    try {
      await _carBrandService.addCarBrand(name);
      _newBrandController.clear();
      _newBrandError = null;
      _loadCarBrands();
      SnackbarHelper.showSnackbar(
        context,
        'Brend dodan!',
        backgroundColor: Colors.green,
      );
    } catch (e) {
      SnackbarHelper.showSnackbar(context, 'Greška: $e');
    }
  }

  Future<void> _updateCarBrand(int id) async {
    final name = _editControllers[id]?.text.trim();
    final original = _carBrands.firstWhere((e) => e.id == id).name;

    if (name == null || name.isEmpty) {
      setState(() => _editErrors[id] = 'Ime brenda je obavezno.');
      return;
    }

    if (name == original) return;

    try {
      await _carBrandService.updateCarBrand(id, name);
      _editErrors[id] = null;
      _editingIds.remove(id);
      _loadCarBrands();
      SnackbarHelper.showSnackbar(
        context,
        'Brend ažuriran!',
        backgroundColor: Colors.blue,
      );
    } catch (e) {
      SnackbarHelper.showSnackbar(context, 'Greška: $e');
    }
  }

  void _cancelEdit(int id) {
    final original = _carBrands.firstWhere((e) => e.id == id).name;
    _editControllers[id]?.text = original;
    setState(() {
      _editingIds.remove(id);
      _editErrors[id] = null;
    });
  }

  @override
  void dispose() {
    _newBrandController.dispose();
    for (final controller in _editControllers.values) {
      controller.dispose();
    }
    super.dispose();
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(title: const Text('Brendovi automobila')),
      body: Center(
        child: ConstrainedBox(
          constraints: const BoxConstraints(maxWidth: 800),
          child: Padding(
            padding: const EdgeInsets.all(16.0),
            child: Column(
              children: [
                Row(
                  crossAxisAlignment:
                      CrossAxisAlignment.center,
                  children: [
                    Expanded(
                      child: TextField(
                        controller: _newBrandController,
                        decoration: InputDecoration(
                          labelText: 'Novo ime brenda',
                          border: const OutlineInputBorder(),
                          errorText: _newBrandError,
                        ),
                        onChanged: (_) {
                          if (_newBrandError != null) {
                            setState(() => _newBrandError = null);
                          }
                        },
                      ),
                    ),
                    const SizedBox(width: 8),
                    Align(
                      alignment: Alignment.center,
                      child: ElevatedButton(
                        onPressed: _newBrandController.text.trim().isEmpty
                            ? null
                            : _addCarBrand,
                        child: const Text('Dodaj'),
                      ),
                    ),
                  ],
                ),
                const SizedBox(height: 16),
                Expanded(
                  child: _isLoading
                      ? const Center(child: CircularProgressIndicator())
                      : ListView.builder(
                          itemCount: _carBrands.length,
                          itemBuilder: (context, index) {
                            final brand = _carBrands[index];
                            final controller = _editControllers[brand.id]!;
                            final error = _editErrors[brand.id];
                            final isEditing = _editingIds.contains(brand.id);
                            final originalValue = brand.name;
                            final hasChanges =
                                controller.text.trim() != originalValue;

                            return ListTile(
                              leading: Text('${brand.id}'),
                              title: Column(
                                crossAxisAlignment: CrossAxisAlignment.start,
                                children: [
                                  TextField(
                                    controller: controller,
                                    readOnly: !isEditing,
                                    enableInteractiveSelection: isEditing,
                                    decoration: InputDecoration(
                                      border: const OutlineInputBorder(),
                                      labelText: 'Ime brenda',
                                      errorText: error,
                                    ),
                                    onChanged: (_) {
                                      if (error != null) {
                                        setState(
                                            () => _editErrors[brand.id] = null);
                                      }
                                      setState(() {});
                                    },
                                  ),
                                ],
                              ),
                              trailing: Row(
                                mainAxisSize: MainAxisSize.min,
                                children: [
                                  if (!isEditing)
                                    IconButton(
                                      icon: const Icon(Icons.edit),
                                      onPressed: () {
                                        setState(() {
                                          _editingIds.add(brand.id);
                                        });
                                      },
                                    ),
                                  if (isEditing) ...[
                                    if (hasChanges)
                                      IconButton(
                                        icon: const Icon(Icons.save,
                                            color: Colors.blue),
                                        onPressed: () =>
                                            _updateCarBrand(brand.id),
                                      ),
                                    IconButton(
                                      icon: const Icon(Icons.close,
                                          color: Colors.grey),
                                      onPressed: () => _cancelEdit(brand.id),
                                    ),
                                  ],
                                  // IconButton(
                                  //   icon: const Icon(Icons.delete,
                                  //       color: Colors.red),
                                  //   onPressed: () => _deleteCarBrand(brand.id),
                                  // ),
                                ],
                              ),
                            );
                          },
                        ),
                ),
              ],
            ),
          ),
        ),
      ),
    );
  }
}
