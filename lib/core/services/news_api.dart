import 'package:ahaan/core/services/api.dart';
import 'package:ahaan/data/model/news/news.dart';

class NewsApi {
  final Api _api = Api();
  Future<List<News>> fetchNews() async {
    final response = await _api.fetchData("/News");
    return (response.data as List)
        .map((value) => News.fromJson(value))
        .toList();
  }
}
