// Демонстрация поразрядного оператора НЕ

using System;

class NotDemo {
  public static void Main() {
    sbyte b = -34;
    int t;

    for(t=128; t > 0; t = t / 2) {
      if((b & t) != 0) Console.Write("1 ");
      if((b & t) == 0) Console.Write("0 ");
    }
    Console.WriteLine();

    // Инвертируем все биты.
    b = (sbyte) ~b;

    for(t=128; t > 0; t = t / 2) {
      if((b & t) != 0) Console.Write("1 ");
      if((b & t) == 0) Console.Write("0 ");
    }
    Console.WriteLine();
  }
}

