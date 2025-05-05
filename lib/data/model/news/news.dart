import 'package:json_annotation/json_annotation.dart';
part 'news.g.dart';

@JsonSerializable()
class News {
  final String newsId;
  final String? headline;
  final String title;
  final String description;
  final String? imageUrl;
  final String category;
  final int likeCount;
  final bool isActive;
  final DateTime publishedAt;

  News({
    required this.newsId,
    required this.headline,
    required this.title,
    required this.description,
    required this.imageUrl,
    required this.category,
    required this.likeCount,
    required this.isActive,
    required this.publishedAt,
  });

  factory News.fromJson(Map<String, dynamic> json) => _$NewsFromJson(json);
  Map<String, dynamic> toJson() => _$NewsToJson(this);
}
