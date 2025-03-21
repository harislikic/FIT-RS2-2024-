import 'package:desktop_app/services/CarCategoryService.dart';
import 'package:flutter/material.dart';
import 'package:desktop_app/models/carCategory.dart';
import 'package:desktop_app/components/shared/SnackbarHelper.dart';

class CarCategoryList extends StatefulWidget {
  const CarCategoryList({super.key});

  @override
  State<CarCategoryList> createState() => _CarCategoryListState();
}

class _CarCategoryListState extends State<CarCategoryList> {
  final CarCategoryService _carCategoryService = CarCategoryService();
  final TextEditingController _newCategoryController = TextEditingController();

  List<CarCategory> _carCategories = [];
  final Map<int, TextEditingController> _editControllers = {};
  final Map<int, String?> _editErrors = {};
  final Set<int> _editingIds = {};
  String? _newCategoryError;
  bool _isLoading = false;

  @override
  void initState() {
    super.initState();
    _newCategoryController.addListener(() => setState(() {}));
    _loadCarCategories();
  }

  Future<void> _loadCarCategories() async {
    setState(() => _isLoading = true);
    try {
      final categories = await _carCategoryService.fetchCarCategories();
      setState(() {
        _carCategories = categories;
        _editControllers.clear();
        _editErrors.clear();
        _editingIds.clear();
        for (var category in categories) {
          _editControllers[category.id] =
              TextEditingController(text: category.name);
          _editErrors[category.id] = null;
        }
      });
    } catch (e) {
      SnackbarHelper.showSnackbar(context, 'Greška pri učitavanju: $e');
    } finally {
      setState(() => _isLoading = false);
    }
  }

  Future<void> _addCarCategory() async {
    final name = _newCategoryController.text.trim();
    if (name.isEmpty) {
      setState(() => _newCategoryError = 'Naziv kategorije je obavezan.');
      return;
    }

    try {
      await _carCategoryService.addCarCategory(name);
      _newCategoryController.clear();
      _newCategoryError = null;
      _loadCarCategories();
      SnackbarHelper.showSnackbar(
        context,
        'Kategorija dodana!',
        backgroundColor: Colors.green,
      );
    } catch (e) {
      SnackbarHelper.showSnackbar(context, 'Greška: $e');
    }
  }

  Future<void> _updateCarCategory(int id) async {
    final name = _editControllers[id]?.text.trim();
    final original = _carCategories.firstWhere((e) => e.id == id).name;

    if (name == null || name.isEmpty) {
      setState(() => _editErrors[id] = 'Naziv kategorije je obavezan.');
      return;
    }

    if (name == original) {
      // Ništa nije promenjeno
      return;
    }

    try {
      await _carCategoryService.updateCarCategory(id, name);
      _editErrors[id] = null;
      _editingIds.remove(id);
      _loadCarCategories();
      SnackbarHelper.showSnackbar(
        context,
        'Kategorija ažurirana!',
        backgroundColor: Colors.blue,
      );
    } catch (e) {
      SnackbarHelper.showSnackbar(context, 'Greška: $e');
    }
  }

  void _cancelEdit(int id) {
    final original = _carCategories.firstWhere((e) => e.id == id).name;
    _editControllers[id]?.text = original;
    setState(() {
      _editingIds.remove(id);
      _editErrors[id] = null;
    });
  }

  @override
  void dispose() {
    _newCategoryController.dispose();
    for (final controller in _editControllers.values) {
      controller.dispose();
    }
    super.dispose();
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(title: const Text('Kategorije automobila')),
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
                        controller: _newCategoryController,
                        decoration: InputDecoration(
                          labelText: 'Nova kategorija',
                          border: const OutlineInputBorder(),
                          errorText: _newCategoryError,
                        ),
                        onChanged: (_) {
                          if (_newCategoryError != null) {
                            setState(() => _newCategoryError = null);
                          }
                        },
                      ),
                    ),
                    const SizedBox(width: 8),
                    ElevatedButton(
                      style: ElevatedButton.styleFrom(
                        minimumSize:
                            const Size(100, 56), // matchuje visinu TextFielda
                      ),
                      onPressed: _newCategoryController.text.trim().isEmpty
                          ? null
                          : _addCarCategory,
                      child: const Text('Dodaj'),
                    ),
                  ],
                ),
                const SizedBox(height: 16),
                Expanded(
                  child: _isLoading
                      ? const Center(child: CircularProgressIndicator())
                      : ListView.builder(
                          itemCount: _carCategories.length,
                          itemBuilder: (context, index) {
                            final category = _carCategories[index];
                            final controller = _editControllers[category.id]!;
                            final error = _editErrors[category.id];
                            final isEditing = _editingIds.contains(category.id);
                            final originalValue = category.name;
                            final hasChanges =
                                controller.text.trim() != originalValue;

                            return ListTile(
                              leading: Text('${category.id}'),
                              title: Column(
                                crossAxisAlignment: CrossAxisAlignment.start,
                                children: [
                                  TextField(
                                    controller: controller,
                                    readOnly: !isEditing,
                                    enableInteractiveSelection: isEditing,
                                    decoration: InputDecoration(
                                      border: const OutlineInputBorder(),
                                      labelText: 'Naziv kategorije',
                                      errorText: error,
                                    ),
                                    onChanged: (_) {
                                      if (error != null) {
                                        setState(() =>
                                            _editErrors[category.id] = null);
                                      }
                                      setState(() {}); // Refresh Save button
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
                                          _editingIds.add(category.id);
                                        });
                                      },
                                    ),
                                  if (isEditing) ...[
                                    if (hasChanges)
                                      IconButton(
                                        icon: const Icon(Icons.save,
                                            color: Colors.blue),
                                        onPressed: () =>
                                            _updateCarCategory(category.id),
                                      ),
                                    IconButton(
                                      icon: const Icon(Icons.close,
                                          color: Colors.grey),
                                      onPressed: () => _cancelEdit(category.id),
                                    ),
                                  ],
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
