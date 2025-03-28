import 'dart:io';
import 'package:flutter/material.dart';
import 'package:image_picker/image_picker.dart';

class ImagePickerWidget extends StatefulWidget {
  final Function(List<XFile>) onImagesPicked;

  const ImagePickerWidget({Key? key, required this.onImagesPicked})
      : super(key: key);

  @override
  _ImagePickerWidgetState createState() => _ImagePickerWidgetState();
}

class _ImagePickerWidgetState extends State<ImagePickerWidget> {
  final ImagePicker _picker = ImagePicker();
  List<XFile> _imageFiles = [];

  Future<void> _pickImage() async {
    final pickedFiles = await _picker.pickMultiImage();
    if (pickedFiles != null) {
      setState(() {
        _imageFiles = pickedFiles;
      });
      widget.onImagesPicked(_imageFiles);
    }
  }

  void _removeImage(int index) {
    setState(() {
      _imageFiles.removeAt(index);
    });
    widget.onImagesPicked(_imageFiles);
  }

  void _selectFirstImage(int index) {
    setState(() {
      final selectedImage = _imageFiles.removeAt(index);
      _imageFiles.insert(0, selectedImage);
    });
    widget.onImagesPicked(_imageFiles);
  }

  @override
  Widget build(BuildContext context) {
    return Column(
      crossAxisAlignment: CrossAxisAlignment.center,
      children: [
        Center(
          child: ElevatedButton(
            onPressed: _pickImage,
            style: ElevatedButton.styleFrom(
              side: const BorderSide(color: Colors.grey),
              padding: const EdgeInsets.symmetric(horizontal: 16, vertical: 10),
            ),
            child: const Text(
              'Učitaj slike',
              style: TextStyle(color: Colors.black),
            ),
          ),
        ),
        if (_imageFiles.isNotEmpty)
          Padding(
            padding: const EdgeInsets.only(top: 16),
            child: Wrap(
              spacing: 10,
              runSpacing: 10,
              children: _imageFiles
                  .asMap()
                  .map((index, file) {
                    return MapEntry(
                      index,
                      GestureDetector(
                        onTap: () => _selectFirstImage(index),
                        child: Stack(
                          clipBehavior: Clip.none,
                          children: [
                            Padding(
                              padding: const EdgeInsets.all(4.0),
                              child: Container(
                                decoration: BoxDecoration(
                                  borderRadius: BorderRadius.circular(10),
                                  boxShadow: const [
                                    BoxShadow(
                                      color: Colors.black26,
                                      offset: Offset(0, 2),
                                      blurRadius: 6,
                                    ),
                                  ],
                                ),
                                child: ClipRRect(
                                  borderRadius: BorderRadius.circular(10),
                                  child: Image.file(
                                    File(file.path),
                                    width: 100,
                                    height: 100,
                                    fit: BoxFit.cover,
                                  ),
                                ),
                              ),
                            ),
                            Positioned(
                              top: 5,
                              right: 5,
                              child: GestureDetector(
                                onTap: () => _removeImage(index),
                                child: Container(
                                  decoration: BoxDecoration(
                                    color: Colors.white.withOpacity(0.6),
                                    borderRadius: BorderRadius.circular(20),
                                  ),
                                  child: const Icon(
                                    Icons.delete,
                                    color: Colors.red,
                                    size: 20,
                                  ),
                                ),
                              ),
                            ),
                          ],
                        ),
                      ),
                    );
                  })
                  .values
                  .toList(),
            ),
          ),
      ],
    );
  }
}
