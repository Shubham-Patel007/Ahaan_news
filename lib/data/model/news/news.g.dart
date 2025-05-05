// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'news.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

News _$NewsFromJson(Map<String, dynamic> json) => News(
      newsId: json['newsId'] as String,
      headline: json['headline'] as String?,
      title: json['title'] as String,
      description: json['description'] as String,
      imageUrl: json['imageUrl'] as String?,
      category: json['category'] as String,
      likeCount: (json['likeCount'] as num).toInt(),
      isActive: json['isActive'] as bool,
      publishedAt: DateTime.parse(json['publishedAt'] as String),
    );

Map<String, dynamic> _$NewsToJson(News instance) => <String, dynamic>{
      'newsId': instance.newsId,
      'headline': instance.headline,
      'title': instance.title,
      'description': instance.description,
      'imageUrl': instance.imageUrl,
      'category': instance.category,
      'likeCount': instance.likeCount,
      'isActive': instance.isActive,
      'publishedAt': instance.publishedAt.toIso8601String(),
    };
