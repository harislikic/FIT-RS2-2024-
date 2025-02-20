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
class Statistics {
  final int totalAutomobileAds;
  final int totalUsers;
  final int usersRegisteredLastFiveYear; 
  final int totalComments;
  final int highlightedCars;
  final int totalAutomobileViews;
  final List<AutomobilePerCity> automobilesPerCity;
  final List<MostFavoritedCar> mostFavoritedCars;

  Statistics({
    required this.totalAutomobileAds,
    required this.totalUsers,
    required this.usersRegisteredLastFiveYear,
    required this.totalComments,
    required this.highlightedCars,
    required this.totalAutomobileViews,
    required this.automobilesPerCity,
    required this.mostFavoritedCars,
  });

  factory Statistics.fromJson(Map<String, dynamic> json) {
    return Statistics(
      totalAutomobileAds: json['totalAutomobileAds'] ?? 0,
      totalUsers: json['totalUsers'] ?? 0,
      usersRegisteredLastFiveYear: json['usersRegisteredLastFiveYear'] ?? 0,
      totalComments: json['totalComments'] ?? 0,
      highlightedCars: json['highlightedCars'] ?? 0,
      totalAutomobileViews: json['totalAutomobileViews'] ?? 0,
      automobilesPerCity: (json['automobilesPerCity'] as List? ?? [])
          .map((city) => AutomobilePerCity.fromJson(city))
          .toList(),
      mostFavoritedCars: (json['mostFavoritedCars'] as List? ?? [])
          .map((car) => MostFavoritedCar.fromJson(car))
          .toList(),
    );
  }
}

class MostFavoritedCar {
  final int automobileAdId;
  final int favoriteCount;
  final String title;
  final double price;
  final String carBrand;

  MostFavoritedCar({
    required this.automobileAdId,
    required this.favoriteCount,
    required this.title,
    required this.price,
    required this.carBrand,
  });

  factory MostFavoritedCar.fromJson(Map<String, dynamic> json) {
    return MostFavoritedCar(
      automobileAdId: json['automobileAdId'] ?? 0,
      favoriteCount: json['favoriteCount'] ?? 0,
      title: json['details']?['title'] ?? "Nepoznato",
      price: (json['details']?['price'] as num?)?.toDouble() ?? 0.0,
      carBrand: json['details']?['carBrand']?['name'] ?? "Nepoznato",
    );
  }
}
