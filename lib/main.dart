import 'package:flutter/material.dart';

import 'package:ahaan/core/routes/routes.dart';
import 'package:ahaan/core/themes/light.dart';
import 'package:ahaan/core/themes/dark.dart';

void main() {
  runApp(const MyApp());
}

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
