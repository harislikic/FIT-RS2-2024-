import 'dart:async';
import 'dart:convert';
import 'package:http/http.dart' as http;
import 'package:image_picker/image_picker.dart';
import 'package:vroom_app/services/AuthService.dart';
import 'package:vroom_app/services/config.dart';
import '../models/automobileAd.dart';

class AutomobileAdService {
  Future<List<AutomobileAd>> fetchAutomobileAds(
      {String searchTerm = '',
      int page = 0,
      int pageSize = 25,
      String minPrice = '',
      String maxPrice = '',
      String minMileage = '',
      String maxMileage = '',
      String yearOfManufacture = '',
      bool registered = false,
      String carBrandId = '',
      String carCategoryId = '',
      String carModelId = '',
      String cityId = ''}) async {
    final queryParams = {
      'Page': page.toString(),
      'PageSize': pageSize.toString(),
      if (searchTerm.isNotEmpty) 'Title': searchTerm,
      if (minPrice.isNotEmpty) 'MinPrice': minPrice,
      if (maxPrice.isNotEmpty) 'MaxPrice': maxPrice,
      if (minMileage.isNotEmpty) 'MinMilage': minMileage,
      if (maxMileage.isNotEmpty) 'MaxMilage': maxMileage,
      if (yearOfManufacture.isNotEmpty) 'YearOfManufacture': yearOfManufacture,
      if (registered) 'Registered': registered.toString(),
      if (carBrandId.isNotEmpty) 'CarBrandId': carBrandId,
      if (carCategoryId.isNotEmpty) 'CarCategoryId': carCategoryId,
      if (carModelId.isNotEmpty) 'CarModelId': carModelId,
      if (cityId.isNotEmpty) 'CityId': cityId,
    };

    final uri = Uri.parse('$baseUrl/AutomobileAd').replace(queryParameters: {
      'Status': 'Active',
      ...queryParams,
    });

    final response = await http.get(uri);

    if (response.statusCode == 200) {
      final data = json.decode(response.body);

      if (data['data'] != null && data['data'] is List) {
        final List<dynamic> items = data['data'];
        return items.map((json) => AutomobileAd.fromJson(json)).toList();
      } else {
        return [];
      }
    } else {
      throw Exception('Failed to load automobile ads');
    }
  }

  Future<AutomobileAd> getAutomobileById(int id) async {
    final response = await http.get(Uri.parse('$baseUrl/AutomobileAd/$id'));

    if (response.statusCode == 200) {
      final data = json.decode(response.body);
      return AutomobileAd.fromJson(data);
    } else {
      throw Exception('Failed to load automobile details');
    }
  }

  Future<bool> createAutomobileAd(
      Map<String, dynamic> adData, authHeaders, List<XFile> imageFiles) async {
    try {
      authHeaders['Content-Type'] = 'multipart/form-data';

      var request =
          http.MultipartRequest('POST', Uri.parse('$baseUrl/AutomobileAd'))
            ..headers.addAll(authHeaders);

      adData.forEach((key, value) {
        if (value != null) {
          request.fields[key] = value.toString();
        }
      });

      if (imageFiles.isNotEmpty) {
        for (var imageFile in imageFiles) {
          request.files
              .add(await http.MultipartFile.fromPath('Images', imageFile.path));
        }
      }

      var response = await request.send();
      if (response.statusCode == 200) {
        return true;
      } else {
        return false;
      }
    } catch (e) {
      print('Error while creating automobile ad: $e');
      return false;
    }
  }

  Future<List<AutomobileAd>> fetchUserAutomobiles(
      {required String userId,
      int page = 0,
      int pageSize = 25,
      String? status,
      bool? IsHighlighted}) async {
    final Map<String, String> queryParams = {
      'page': page.toString(),
      'pageSize': pageSize.toString(),
    };

    if (status != null && status.isNotEmpty) {
      queryParams['status'] = status;
    }

    if (IsHighlighted == true) {
      queryParams['IsHighlighted'] = IsHighlighted.toString();
    }

    final uri = Uri.parse('$baseUrl/AutomobileAd/user-ads/$userId')
        .replace(queryParameters: queryParams);

    print("GOLASI USERA:: ${uri}");

    try {
      final response = await http.get(uri);

      if (response.statusCode == 200) {
        final Map<String, dynamic> data = json.decode(response.body);

        if (data['data'] != null && data['data'] is List) {
          final List<dynamic> items = data['data'];
          return items.map((json) => AutomobileAd.fromJson(json)).toList();
        } else {
          return [];
        }
      } else if (response.statusCode == 404) {
        return [];
      } else {
        throw Exception('Failed to load automobile ads');
      }
    } catch (e) {
      throw Exception('Error fetching user automobile ads: $e');
    }
  }

  Future<void> removeAutomobile(
      int automobileId, Map<String, String> authHeaders) async {
    authHeaders['accept'] = 'text/plain';

    final response = await http.delete(
      Uri.parse('$baseUrl/AutomobileAd/$automobileId'),
      headers: authHeaders,
    );

    if (response.statusCode != 200) {
      throw Exception('Failed to remove automobile');
    }
  }

  Future<void> markAsDone(int automobileId) async {
    final uri = Uri.parse('$baseUrl/AutomobileAd/mark-as-done/$automobileId');
    final headers = {'accept': '*/*'};

    final response = await http.put(uri, headers: headers);
    if (response.statusCode != 200) {
      throw Exception('Failed to mark automobile as done');
    }
  }

  Future<List<AutomobileAd>> fetchRecommendAutomobiles() async {
    final userId = await AuthService.getUserId();
    if (userId == null) {
      throw Exception('User ID is not available');
    }

    final uri = Uri.parse('$baseUrl/AutomobileAd/$userId/recommend');

    try {
      final response = await http.get(uri);

      if (response.statusCode == 200) {
        final List<dynamic> items = json.decode(response.body);
        return items.map((json) => AutomobileAd.fromJson(json)).toList();
      } else {
        throw Exception('Failed to load recommended automobile ads');
      }
    } catch (e) {
      throw Exception('Error fetching recommended automobile ads: $e');
    }
  }

  Future<bool> updateAutomobileAd(
    int automobileId,
    Map<String, dynamic> updatedFields, {
    List<XFile>? newImages,
    List<int>? removedImageIds,
    List<int>? removedEquipmentIds,
  }) async {
    try {
      if (removedImageIds != null && removedImageIds.isNotEmpty) {
        final deleteImagesSuccess =
            await deleteAutomobileImages(removedImageIds);
        if (!deleteImagesSuccess) {
          print('Failed to delete images.');
          return false;
        }
      }

      if (removedEquipmentIds != null && removedEquipmentIds.isNotEmpty) {
        final deleteEquipmentSuccess =
            await deleteAutomobileEquipment(automobileId, removedEquipmentIds);
        if (!deleteEquipmentSuccess) {
          print('Failed to delete automobile equipment.');
          return false;
        }
      }

      if (updatedFields.isEmpty && (newImages == null || newImages.isEmpty)) {
        return true;
      }

      if (updatedFields.containsKey('EquipmentIds')) {
        final equipmentIds = updatedFields['EquipmentIds'];
        if (equipmentIds is List<int>) {
          final success =
              await updateAdditionalEquipment(automobileId, equipmentIds);
          if (!success) {
            print('Failed to update additional equipment.');
            return false;
          }
          updatedFields.remove('EquipmentIds');
        }
      }

      final uri = Uri.parse('$baseUrl/AutomobileAd/$automobileId');

      var request = http.MultipartRequest('PATCH', uri);

      updatedFields.forEach((key, value) {
        if (value != null) {
          request.fields[key] = value.toString();
        }
      });

      updatedFields.forEach((key, value) {
        if (value != null) {
          request.fields[key] = value.toString();
        }
      });

      if (newImages != null && newImages.isNotEmpty) {
        for (var image in newImages) {
          request.files.add(
            await http.MultipartFile.fromPath('Images', image.path),
          );
        }
      }

      final authHeaders = await AuthService.getAuthHeaders();
      request.headers.addAll(authHeaders);

      var response = await request.send();

      if (response.statusCode == 200) {
        return true;
      } else {
        print('Failed to update automobile ad. Status: ${response.statusCode}');
        return false;
      }
    } catch (e) {
      print('Error during PATCH request: $e');
      return false;
    }
  }

  Future<bool> updateAdditionalEquipment(
      int automobileAdId, List<int> equipmentIds) async {
    try {
      final uri =
          Uri.parse('$baseUrl/api/AutomobileAdEquipment/update-automobile');

      final authHeaders = await AuthService.getAuthHeaders();

      final body = json.encode({
        'newAutomobileAdId': automobileAdId,
        'equipmentIds': equipmentIds,
      });

      final headers = {
        'Content-Type': 'application/json',
        'accept': '*/*',
        ...authHeaders
      };

      final response = await http.put(uri, headers: headers, body: body);

      if (response.statusCode == 200) {
        return true;
      } else {
        print(
            'Failed to update additional equipment. Status: ${response.statusCode}');
        return false;
      }
    } catch (e) {
      print('Error during additional equipment update: $e');
      return false;
    }
  }

  Future<bool> deleteAutomobileEquipment(
      int automobileAdId, List<int> equipmentIds) async {
    try {
      final uri =
          Uri.parse('$baseUrl/api/AutomobileAdEquipment/$automobileAdId');

      final authHeaders = await AuthService.getAuthHeaders();
      final headers = {
        'Content-Type': 'application/json',
        'accept': '*/*',
        ...authHeaders
      };

      final body = json.encode(equipmentIds);

      final response = await http.delete(
        uri,
        headers: headers,
        body: body,
      );

      if (response.statusCode == 200) {
        return true;
      } else {
        print(
            'Failed to delete automobile equipment. Status: ${response.statusCode}');
        return false;
      }
    } catch (e) {
      print('Error during DELETE request for equipment: $e');
      return false;
    }
  }

  Future<bool> deleteAutomobileImages(List<int> imageIds) async {
    try {
      final uri = Uri.parse('$baseUrl/AutomobileImages/delete-images');
      final headers = {
        'Content-Type': 'application/json',
        'accept': '*/*',
      };

      final body = json.encode(imageIds);

      final response = await http.delete(
        uri,
        headers: headers,
        body: body,
      );

      print('Request Body: $body');
      print('Response Status Code: ${response.statusCode}');
      print('Response Body: ${response.body}');

      if (response.statusCode == 200) {
        return true;
      } else {
        print('Failed to delete images. Status: ${response.statusCode}');
        return false;
      }
    } catch (e) {
      print('Error during DELETE request: $e');
      return false;
    }
  }
}
