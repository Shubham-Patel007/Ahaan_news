import 'package:flutter/material.dart';

import 'package:templete/core/routes/routes.dart';
import 'package:templete/core/themes/light.dart';
import 'package:templete/core/themes/dark.dart';

void main() {
  runApp(const MyApp());
}

// Check for github pull request.
class MyApp extends StatelessWidget {
  const MyApp({super.key});

  @override
  Widget build(BuildContext context) {
    return MaterialApp.router(
      debugShowCheckedModeBanner: false,
      routerConfig: route,
      theme: light,
      darkTheme: dark,
    );
  }
}
