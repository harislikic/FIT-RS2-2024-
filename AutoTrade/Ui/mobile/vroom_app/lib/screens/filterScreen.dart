import 'package:flutter/material.dart';
import 'package:vroom_app/components/FilterForm.dart';

class FilterScreen extends StatelessWidget {
  final Function(String, String, String, String, String, bool, String, String,
      String, String) onApplyFilters;
  final Function() onResetFilters;

  const FilterScreen({
    Key? key,
    required this.onApplyFilters,
    required this.onResetFilters,
  }) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text("Filteri"),
        leading: IconButton(
          icon: const Icon(
            Icons.arrow_back,
            color: Colors.lightBlueAccent,
          ),
          onPressed: () {
            Navigator.pop(context);
          },
        ),
      ),
      body: FilterForm(
        onApplyFilters: onApplyFilters,
        onResetFilters: onResetFilters,
      ),
    );
  }
}
