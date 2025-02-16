class DateHelper {
  static String getMonthName(String key) {
    List<String> months = [
      'Januar',
      'Februar',
      'Mart',
      'April',
      'Maj',
      'Juni',
      'Juli',
      'August',
      'Septembar',
      'Oktobar',
      'Novembar',
      'Decembar'
    ];

    List<String> parts = key.split('/');
    int monthIndex = int.tryParse(parts[0]) ?? 1;

    return months[monthIndex - 1];
  }
}
