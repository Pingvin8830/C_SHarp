// Демонстрация использования программного блока.

using System;

class BlockDemo {
  public static void Main() {
    int i, j, d;

    i = 5;
    j = 10;

    // Эта if-инструкция управляет программным
    // блоком, а не одной инструкцией.
    if(i != 0) {
      Console.WriteLine("i не равно нулю");
      d = j / i;
      Console.WriteLine("j / i равно " + d);
    }
  }
}

