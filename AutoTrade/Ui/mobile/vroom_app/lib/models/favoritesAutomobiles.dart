import 'package:vroom_app/models/image.dart';

class FavoritesAutomobiles {
  final int id;
  final String title;
  final double price;
  final int yearOfManufacture;
  final int mileage;
  final int horsePower;
  final List<ImageModel> images;

  FavoritesAutomobiles({
    required this.id,
    required this.title,
    required this.price,
    required this.yearOfManufacture,
    required this.mileage,
    required this.horsePower,
    required this.images,
  });

  factory FavoritesAutomobiles.fromJson(Map<String, dynamic> json) {
    return FavoritesAutomobiles(
      id: json['id'],
      title: json['title'] ?? 'Unknown',
      price: json['price']?.toDouble() ?? 0.0,
      yearOfManufacture: json['yearOfManufacture'] ?? 0,
      mileage: json['milage'] ?? 0,
      horsePower: json['horsePower'] ?? 0,
      images: (json['images'] as List)
          .map((image) => ImageModel.fromJson(image))
          .toList(),
    );
  }
}
