// Демонстрация использования инструкции if.

using System;

class IfDemo {
  public static void Main() {
    int a, b, c;

    a = 2;
    b = 3;

    if(a < b) Console.WriteLine("a меньше b");

    // Следующая инструкция ничего не отобразит на экране.
    if(a == b)  Console.WriteLine(
                  "Этого текста никто не увидит."
                );

    Console.WriteLine();

    c = a - b; // Переменная c содержит -1.

    Console.WriteLine("c содержит -1");
    if(c >= 0)  Console.WriteLine(
                  "Значение c неотрицательно"
                );

    if(c < 0) Console.WriteLine(
                "Значение c отрицательно"
              );

    Console.WriteLine();

    c = b - a; // Теперь переменная c содержит 1.
    Console.WriteLine("c содержит 1.");
    if(c >= 0)  Console.WriteLine(
                  "Значение с неотрицательно"
                );

    if(c < 0) Console.WriteLine("Значение с отрицательно");
  }
}

