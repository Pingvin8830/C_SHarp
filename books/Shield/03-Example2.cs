// Эта программа демонстрирует работу с переменными.

using System;

class Example2 {

  public static void Main() {
    int x; // Здесь объявляется переменная.
    int y; // Здесь объявляется ещё одна переменная.

    x = 100;  // Здесь переменной х присваивается 100.

    Console.WriteLine("x содержит " + x);

    y = x / 2;

    Console.Write("y содержит x / 2: ");
    Console.WriteLine(y);
  }

}

