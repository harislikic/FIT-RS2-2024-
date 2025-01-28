import 'package:flutter/material.dart';

class TooltipIconButton extends StatelessWidget {
  final String message;
  final IconData icon;
  final VoidCallback onPressed;
  final Color iconColor;

  const TooltipIconButton({
    Key? key,
    required this.message,
    required this.icon,
    required this.onPressed,
    this.iconColor = Colors.black,
  }) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Tooltip(
      message: message,
      child: IconButton(
        icon: Icon(icon, color: iconColor),
        onPressed: onPressed,
      ),
    );
  }
}
