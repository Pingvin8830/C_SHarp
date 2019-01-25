// Использование поразрядного оператора И для
// определения, является ли число нечётным.

using System;

class IsOdd {
  public static void Main() {
    ushort num;

    num = 10;

    if((num & 1) == 1)
      Console.WriteLine("Этот текст не будет отображён.");

    num = 11;

    if((num & 1) == 1)
      Console.WriteLine(num + " -- нечётное число.");
  }
}

