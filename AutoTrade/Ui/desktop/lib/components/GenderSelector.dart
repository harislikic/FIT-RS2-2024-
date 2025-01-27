import 'package:flutter/material.dart';

class GenderSelector extends StatefulWidget {
  final String? selectedGender;
  final ValueChanged<String> onGenderSelected;

  const GenderSelector({
    Key? key,
    required this.selectedGender,
    required this.onGenderSelected,
  }) : super(key: key);

  @override
  State<GenderSelector> createState() => _GenderSelectorState();
}

class _GenderSelectorState extends State<GenderSelector> {
  String? _selectedGender;

  @override
  void initState() {
    super.initState();
    _selectedGender = widget.selectedGender; 
  }

  void _onGenderChanged(String gender) {
    setState(() {
      _selectedGender = gender;
    });
    widget.onGenderSelected(gender); 
  }

  @override
  Widget build(BuildContext context) {
    return Row(
      mainAxisAlignment: MainAxisAlignment.start,
      children: [
        Row(
          children: [
            Checkbox(
              value: _selectedGender == 'M',
              onChanged: (value) {
                if (value == true) _onGenderChanged('M');
              },
            ),
            const Text('Muški'),
          ],
        ),
        const SizedBox(width: 16),
        Row(
          children: [
            Checkbox(
              value: _selectedGender == 'Z',
              onChanged: (value) {
                if (value == true) _onGenderChanged('Z');
              },
            ),
            const Text('Ženski'),
          ],
        ),
      ],
    );
  }
}
