import 'dart:io';

const String apiHostAndroid = String.fromEnvironment('API_HOST_ANDROID', defaultValue: 'http://10.0.2.2');
const String apiHostIOS = String.fromEnvironment('API_HOST_IOS', defaultValue: 'http://localhost');
const String apiPort = String.fromEnvironment('API_PORT', defaultValue: '5194');

final String apiHost = Platform.isAndroid ? apiHostAndroid : apiHostIOS;
final String baseUrl = '$apiHost:$apiPort';

void printConfig() {
  print('✅ API_HOST: $apiHost');
  print('✅ API_PORT: $apiPort');
  print('✅ BASE_URL: $baseUrl');
}


// Pokretanje aplikacije lokalno
// flutter build apk \
//   --dart-define=API_HOST_IOS=http://localhost \
//   --dart-define=API_PORT=5194

// Stripe keys
//  --dart-define=STRIPE_SECRET_KEY=sk_test_... \
//   --dart-define=STRIPE_PUBLISHABLE_KEY=pk_test_...

//Gradnja za Android

// flutter run \
//   --dart-define=API_HOST_ANDROID=http://10.0.2.2 \
//   --dart-define=API_PORT=5194


//Gradnja za iOS
// flutter run  \
//   --dart-define=API_HOST_IOS=http://localhost \
//   --dart-define=API_PORT=5194


//Pravi uredjaj
// flutter run \
//   --dart-define=API_HOST_ANDROID=http://192.168.1.24 \
//   --dart-define=API_PORT=5194

// flutter build apk \
//   --dart-define=API_HOST_IOS=http://localhost \
//   --dart-define=API_PORT=5194 \
//   --dart-define=STRIPE_SECRET_KEY=sk_test_... \
//   --dart-define=STRIPE_PUBLISHABLE_KEY=pk_test_...