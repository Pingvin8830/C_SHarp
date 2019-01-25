// Демонстрация времени существования переменной.

using System;

class VarInitDemo {
  public static void Main() {
    int x;

    for(x = 0; x < 3; x++) {
      int y = -1; // Переменная y инициализируется при
                  // каждом входе в программный блок.

      Console.WriteLine("Значение y равно: " + y);  // Здесь всегда выводится -1.

      y = 100;
      Console.WriteLine("Теперь значение y равно: " + y);
    }

  }
}

