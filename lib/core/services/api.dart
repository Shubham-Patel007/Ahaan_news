import 'dart:developer';
import 'dart:io';

import 'package:dio/dio.dart';
import 'package:dio/io.dart';

class Api {
  // Base Url
  final Dio _dio = Dio(
    BaseOptions(
      baseUrl: "https://192.168.0.105:7064/api",
    ),
  );

  Api() {
    // ignore: deprecated_member_use
    (_dio.httpClientAdapter as IOHttpClientAdapter).onHttpClientCreate =
        (HttpClient client) {
      client.badCertificateCallback =
          (X509Certificate cert, String host, int port) {
        // Trust all certs for development
        return true;
      };
      return client;
    };
  }

  Future<Response> fetchData(String keyword) async {
    try {
      final response = await _dio.get(
        keyword,
        options: Options(
          headers: {'accept': '*/*'},
        ),
      );
      return response;
    } catch (e) {
      log('Error fetching news: $e');
      rethrow;
    }
  }
}
