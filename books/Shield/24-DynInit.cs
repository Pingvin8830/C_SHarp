// Демонстрация динамической инициализации.

using System;

class DynInit {
  public static void Main() {
    double s1 = 4.0, s2 = 5.0; // Длины сторон.

    // Динамически инициализируем переменную hypot.
    double hypot = Math.Sqrt( (s1 * s1) + (s2 * s2));

    Console.Write("Гипотенуза треугольника со сторонами " + s1 + " и " + s2 + " равна ");
    Console.WriteLine("{0:#.###}.", hypot);
  }
}

