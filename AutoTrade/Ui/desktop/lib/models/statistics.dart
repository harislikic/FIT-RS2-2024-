class AutomobilePerCity {
  final String city;
  final int automobileCount;

  AutomobilePerCity({required this.city, required this.automobileCount});

  factory AutomobilePerCity.fromJson(Map<String, dynamic> json) {
    return AutomobilePerCity(
      city: json['city'],
      automobileCount: json['automobileCount'],
    );
  }
}

class MostFavoritedCar {
  final int automobileAdId;
  final int favoriteCount;
  final String title;
  final double price;

  MostFavoritedCar({
    required this.automobileAdId,
    required this.favoriteCount,
    required this.title,
    required this.price,
  });

  factory MostFavoritedCar.fromJson(Map<String, dynamic> json) {
    return MostFavoritedCar(
      automobileAdId: json['automobileAdId'],
      favoriteCount: json['favoriteCount'],
      title: json['mostFavoritedCarDetails']['title'],
      price: json['mostFavoritedCarDetails']['price'].toDouble(),
    );
  }
}

class Statistics {
  final int totalAutomobileAds;
  final int totalUsers;
  final int totalComments;
  final int highlightedCars;
  final List<AutomobilePerCity> automobilesPerCity;
  final MostFavoritedCar mostFavoritedCar;

  Statistics({
    required this.totalAutomobileAds,
    required this.totalUsers,
    required this.totalComments,
    required this.highlightedCars,
    required this.automobilesPerCity,
    required this.mostFavoritedCar,
  });

  factory Statistics.fromJson(Map<String, dynamic> json) {
    return Statistics(
      totalAutomobileAds: json['totalAutomobileAds'],
      totalUsers: json['totalUsers'],
      totalComments: json['totalComments'],
      highlightedCars: json['highlightedCars'],
      automobilesPerCity: (json['automobilesPerCity'] as List)
          .map((city) => AutomobilePerCity.fromJson(city))
          .toList(),
      mostFavoritedCar: MostFavoritedCar.fromJson(json['mostFavoritedCar']),
    );
  }
}
