import 'package:desktop_app/services/EquipmentService.dart';
import 'package:flutter/material.dart';
import 'package:desktop_app/models/equipment.dart';

import 'package:desktop_app/components/shared/SnackbarHelper.dart';

class EquipmentList extends StatefulWidget {
  const EquipmentList({super.key});

  @override
  State<EquipmentList> createState() => _EquipmentListState();
}

class _EquipmentListState extends State<EquipmentList> {
  final EquipmentService _equipmentService = EquipmentService();
  final TextEditingController _newEquipmentController = TextEditingController();
  final Map<int, TextEditingController> _editControllers = {};
  final Map<int, String?> _editErrors = {};
  final Set<int> _editingIds = {};
  String? _newEquipmentError;

  List<Equipment> _equipments = [];
  bool _isLoading = false;

  @override
  void initState() {
    super.initState();
    _newEquipmentController.addListener(() => setState(() {}));
    _loadEquipments();
  }

  Future<void> _loadEquipments() async {
    setState(() => _isLoading = true);
    try {
      final equipmentList = await _equipmentService.fetchEquipments();
      setState(() {
        _equipments = equipmentList;
        _editControllers.clear();
        _editErrors.clear();
        _editingIds.clear();
        for (var item in equipmentList) {
          _editControllers[item.id] = TextEditingController(text: item.name);
          _editErrors[item.id] = null;
        }
      });
    } catch (e) {
      SnackbarHelper.showSnackbar(context, 'Greška pri učitavanju: $e');
    } finally {
      setState(() => _isLoading = false);
    }
  }

  Future<void> _addEquipment() async {
    final name = _newEquipmentController.text.trim();
    if (name.isEmpty) {
      setState(() => _newEquipmentError = 'Naziv opreme je obavezan.');
      return;
    }

    try {
      await _equipmentService.addEquipment(name);
      _newEquipmentController.clear();
      _newEquipmentError = null;
      _loadEquipments();
      SnackbarHelper.showSnackbar(
        context,
        'Oprema dodata!',
        backgroundColor: Colors.green,
      );
    } catch (e) {
      SnackbarHelper.showSnackbar(context, 'Greška: $e');
    }
  }

  Future<void> _updateEquipment(int id) async {
    final name = _editControllers[id]?.text.trim();
    final original = _equipments.firstWhere((e) => e.id == id).name;

    if (name == null || name.isEmpty) {
      setState(() => _editErrors[id] = 'Naziv opreme je obavezan.');
      return;
    }

    if (name == original) return;

    try {
      await _equipmentService.updateEquipment(id, name);
      _editErrors[id] = null;
      _editingIds.remove(id);
      _loadEquipments();
      SnackbarHelper.showSnackbar(
        context,
        'Oprema ažurirana!',
        backgroundColor: Colors.blue,
      );
    } catch (e) {
      SnackbarHelper.showSnackbar(context, 'Greška: $e');
    }
  }

  Future<void> _deleteEquipment(int equipmentId) async {
    try {
      await _equipmentService.deleteEquipment(equipmentId);
      _newEquipmentController.clear();
      _newEquipmentError = null;
      _loadEquipments();
      SnackbarHelper.showSnackbar(
        context,
        'Oprema obrisana!',
        backgroundColor: Colors.green,
      );
    } catch (e) {
      SnackbarHelper.showSnackbar(context, 'Greška: $e');
    }
  }

  Future<void> _showDeleteConfirmationDialog(int equipmentId) async {
    final shouldDelete = await showDialog<bool>(
      context: context,
      builder: (context) => AlertDialog(
        title: const Text('Potvrda brisanja'),
        content:
            const Text('Da li ste sigurni da želite da obrišete ovu opremu?'),
        actions: [
          TextButton(
            onPressed: () => Navigator.of(context).pop(false),
            child: const Text('Otkaži'),
          ),
          ElevatedButton(
            style: ElevatedButton.styleFrom(
              backgroundColor: Colors.white,
            ),
            onPressed: () => Navigator.of(context).pop(true),
            child: const Text('Obriši'),
          ),
        ],
      ),
    );

    if (shouldDelete == true) {
      _deleteEquipment(equipmentId);
    }
  }

  void _cancelEdit(int id) {
    final original = _equipments.firstWhere((e) => e.id == id).name;
    _editControllers[id]?.text = original;
    setState(() {
      _editingIds.remove(id);
      _editErrors[id] = null;
    });
  }

  @override
  void dispose() {
    _newEquipmentController.dispose();
    for (final controller in _editControllers.values) {
      controller.dispose();
    }
    super.dispose();
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(title: const Text('Lista opreme')),
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
                        controller: _newEquipmentController,
                        decoration: InputDecoration(
                          labelText: 'Nova oprema',
                          border: const OutlineInputBorder(),
                          errorText: _newEquipmentError,
                        ),
                        onChanged: (_) {
                          if (_newEquipmentError != null) {
                            setState(() => _newEquipmentError = null);
                          }
                        },
                      ),
                    ),
                    const SizedBox(width: 8),
                    Align(
                      alignment: Alignment.center,
                      child: ElevatedButton(
                        onPressed: _newEquipmentController.text.trim().isEmpty
                            ? null
                            : _addEquipment,
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
                          itemCount: _equipments.length,
                          itemBuilder: (context, index) {
                            final equipment = _equipments[index];
                            final controller = _editControllers[equipment.id]!;
                            final error = _editErrors[equipment.id];
                            final isEditing =
                                _editingIds.contains(equipment.id);
                            final originalValue = equipment.name;
                            final hasChanges =
                                controller.text.trim() != originalValue;

                            return ListTile(
                              leading: Text('${equipment.id}'),
                              title: Column(
                                crossAxisAlignment: CrossAxisAlignment.start,
                                children: [
                                  TextField(
                                    controller: controller,
                                    readOnly: !isEditing,
                                    enableInteractiveSelection: isEditing,
                                    decoration: InputDecoration(
                                      border: const OutlineInputBorder(),
                                      labelText: 'Naziv opreme',
                                      errorText: error,
                                    ),
                                    onChanged: (_) {
                                      if (error != null) {
                                        setState(() =>
                                            _editErrors[equipment.id] = null);
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
                                          _editingIds.add(equipment.id);
                                        });
                                      },
                                    ),
                                  if (isEditing) ...[
                                    if (hasChanges)
                                      IconButton(
                                        icon: const Icon(Icons.save,
                                            color: Colors.blue),
                                        onPressed: () =>
                                            _updateEquipment(equipment.id),
                                      ),
                                    IconButton(
                                      icon: const Icon(Icons.close,
                                          color: Colors.grey),
                                      onPressed: () =>
                                          _cancelEdit(equipment.id),
                                    ),
                                  ],
                                  IconButton(
                                    icon: const Icon(Icons.delete,
                                        color: Colors.red),
                                    onPressed: () =>
                                        _showDeleteConfirmationDialog(
                                            equipment.id),
                                  ),
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
