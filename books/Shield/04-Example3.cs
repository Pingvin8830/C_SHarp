/*
  Эта программа иллюстрирует различие между
  типами int и double.
*/

using System;

class Example3 {
  public static void Main() {
    int ivar;     // Объявляем переменную типа int.
    double dvar;  // Объявляем переменную типа double.

    ivar = 100;   // Присваиваем переменной ivar
                  // значение 100.

    dvar = 100.0; // Присваиваем переменной dvar
                  // значение 100.0

    Console.WriteLine(
      "Исходное значение переменной ivar: " + ivar
    );
    Console.WriteLine(
      "Исходное значение переменной dvar: " + dvar
    );

    Console.WriteLine();  // Выводим пустую строку.

    // Теперь делим оба значения на 3.
    ivar = ivar / 3;
    dvar = dvar / 3.0;

    Console.WriteLine("ivar после деления: " + ivar);
    Console.WriteLine("dvar после деления: " + dvar);
  }
}

