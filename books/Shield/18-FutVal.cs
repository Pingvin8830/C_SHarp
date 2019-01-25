/*
  Использование типа decimal для вычисления будущей
  стоимости капиталовложений.
*/

using System;

class FutVal {
  public static void Main() {
    decimal amount;
    decimal rate_of_return;
    int years, i;

    amount = 1000.0M;
    rate_of_return = 0.07M;
    years = 10;

    Console.WriteLine("Исходный вклад: $" + amount);
    Console.WriteLine("Норма прибыли: " + rate_of_return);
    Console.WriteLine("Через " + years + " лет");

    for(i = 0; i < years; i++)
      amount = amount + (amount * rate_of_return);

    Console.WriteLine("Будущая стоимость равна $" + amount);
  }
}

