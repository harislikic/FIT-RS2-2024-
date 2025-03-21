import 'package:flutter/material.dart';
import 'package:desktop_app/models/carModel.dart';
import 'package:desktop_app/services/carModelService.dart';
import 'package:desktop_app/components/shared/SnackbarHelper.dart';

class CarModelList extends StatefulWidget {
  const CarModelList({super.key});

  @override
  State<CarModelList> createState() => _CarModelListState();
}

class _CarModelListState extends State<CarModelList> {
  final CarModelService _carModelService = CarModelService();
  final TextEditingController _newModelController = TextEditingController();
  final Map<int, TextEditingController> _editControllers = {};
  final Map<int, String?> _editErrors = {};
  final Set<int> _editingIds = {};
  String? _newModelError;

  List<CarModel> _carModels = [];
  bool _isLoading = false;

  @override
  void initState() {
    super.initState();
    _newModelController.addListener(() => setState(() {}));
    _loadCarModels();
  }

  Future<void> _loadCarModels() async {
    setState(() => _isLoading = true);
    try {
      final models = await _carModelService.fetchCarModels();
      setState(() {
        _carModels = models;
        _editControllers.clear();
        _editErrors.clear();
        _editingIds.clear();
        for (var model in models) {
          _editControllers[model.id] = TextEditingController(text: model.name);
          _editErrors[model.id] = null;
        }
      });
    } catch (e) {
      SnackbarHelper.showSnackbar(context, 'Greška pri učitavanju: $e');
    } finally {
      setState(() => _isLoading = false);
    }
  }

  Future<void> _addCarModel() async {
    final name = _newModelController.text.trim();
    if (name.isEmpty) {
      setState(() => _newModelError = 'Ime modela je obavezno.');
      return;
    }

    try {
      await _carModelService.addCarModel(name);
      _newModelController.clear();
      _newModelError = null;
      _loadCarModels();
      SnackbarHelper.showSnackbar(
        context,
        'Model dodat!',
        backgroundColor: Colors.green,
      );
    } catch (e) {
      SnackbarHelper.showSnackbar(context, 'Greška: $e');
    }
  }

  Future<void> _updateCarModel(int id) async {
    final name = _editControllers[id]?.text.trim();
    final original = _carModels.firstWhere((e) => e.id == id).name;

    if (name == null || name.isEmpty) {
      setState(() => _editErrors[id] = 'Ime modela je obavezno.');
      return;
    }

    if (name == original) return;

    try {
      await _carModelService.updateCarModel(id, name);
      _editErrors[id] = null;
      _editingIds.remove(id);
      _loadCarModels();
      SnackbarHelper.showSnackbar(
        context,
        'Model ažuriran!',
        backgroundColor: Colors.blue,
      );
    } catch (e) {
      SnackbarHelper.showSnackbar(context, 'Greška: $e');
    }
  }

  void _cancelEdit(int id) {
    final original = _carModels.firstWhere((e) => e.id == id).name;
    _editControllers[id]?.text = original;
    setState(() {
      _editingIds.remove(id);
      _editErrors[id] = null;
    });
  }

  @override
  void dispose() {
    _newModelController.dispose();
    for (final controller in _editControllers.values) {
      controller.dispose();
    }
    super.dispose();
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(title: const Text('Modeli automobila')),
      body: Center(
        child: ConstrainedBox(
          constraints: const BoxConstraints(maxWidth: 800),
          child: Padding(
            padding: const EdgeInsets.all(16.0),
            child: Column(
              children: [
                Row(
                  crossAxisAlignment: CrossAxisAlignment.center,
                  children: [
                    Expanded(
                      child: TextField(
                        controller: _newModelController,
                        decoration: InputDecoration(
                          labelText: 'Novo ime modela',
                          border: const OutlineInputBorder(),
                          errorText: _newModelError,
                        ),
                        onChanged: (_) {
                          if (_newModelError != null) {
                            setState(() => _newModelError = null);
                          }
                        },
                      ),
                    ),
                    const SizedBox(width: 8),
                    Align(
                      alignment: Alignment.center,
                      child: ElevatedButton(
                        onPressed: _newModelController.text.trim().isEmpty
                            ? null
                            : _addCarModel,
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
                          itemCount: _carModels.length,
                          itemBuilder: (context, index) {
                            final model = _carModels[index];
                            final controller = _editControllers[model.id]!;
                            final error = _editErrors[model.id];
                            final isEditing = _editingIds.contains(model.id);
                            final originalValue = model.name;
                            final hasChanges =
                                controller.text.trim() != originalValue;

                            return ListTile(
                              leading: Text('${model.id}'),
                              title: Column(
                                crossAxisAlignment: CrossAxisAlignment.start,
                                children: [
                                  TextField(
                                    controller: controller,
                                    readOnly: !isEditing,
                                    enableInteractiveSelection: isEditing,
                                    decoration: InputDecoration(
                                      border: const OutlineInputBorder(),
                                      labelText: 'Ime modela',
                                      errorText: error,
                                    ),
                                    onChanged: (_) {
                                      if (error != null) {
                                        setState(
                                            () => _editErrors[model.id] = null);
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
                                          _editingIds.add(model.id);
                                        });
                                      },
                                    ),
                                  if (isEditing) ...[
                                    if (hasChanges)
                                      IconButton(
                                        icon: const Icon(Icons.save,
                                            color: Colors.blue),
                                        onPressed: () =>
                                            _updateCarModel(model.id),
                                      ),
                                    IconButton(
                                      icon: const Icon(Icons.close,
                                          color: Colors.grey),
                                      onPressed: () => _cancelEdit(model.id),
                                    ),
                                  ],
                                  // IconButton(
                                  //   icon: const Icon(Icons.delete,
                                  //       color: Colors.red),
                                  //   onPressed: () => _deleteCarModel(model.id),
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
