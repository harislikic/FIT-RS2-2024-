
const String apiHost = String.fromEnvironment('API_HOST', defaultValue: 'http://localhost');
const String apiPort = String.fromEnvironment('API_PORT', defaultValue: '5194');


final String baseUrl = '$apiHost:$apiPort';

void printConfig() {
  print('✅ API_HOST: $apiHost');
  print('✅ API_PORT: $apiPort');
  print('✅ BASE_URL: $baseUrl');
}


// Pokretanje aplikacije lokalno
// flutter run -d macos\
//   --dart-define=API_HOST_IOS=http://localhost \
//   --dart-define=API_PORT=5194

