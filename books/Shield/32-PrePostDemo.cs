/*
  Демонстрация различия между префиксной и
  постфиксной формами оператора ++
*/

using System;

class PrePostDemo {
  public static void Main() {
    int x, y;
    int i;

    x = 1;
    Console.WriteLine("Ряд, построенный с помощью инструкции y = x + x++;");
    for(i = 0; i < 10; i++) {
      y = x + x++; // постфиксная форма оператора ++
      Console.WriteLine(y + " ");
    }
    Console.WriteLine();

    x = 1;
    Console.WriteLine("Ряд, построенный с помощью инструкции y = y + ++x");
    for(i = 0; i < 10; i++) {
      y = x + ++x; // префиксная форма оператора ++
      Console.WriteLine(y + " ");
    }
    Console.WriteLine();
  }
}

