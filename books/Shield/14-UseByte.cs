// Использование типа byte

using System;

class UseByte {
  public static void Main() {
    byte x;
    int sum;

    sum = 0;

    for(x = 1; x <= 100; x++)
      sum = sum + x;

    Console.WriteLine("Сумма чисел от 1 до 100 равна " + sum);
  }
}

