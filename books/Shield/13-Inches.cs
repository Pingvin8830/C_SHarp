// Вычисляем расстояние от Земли до Солнца в дюймах.

using System;

class Inches {
  public static void Main() {
    long inches;
    long miles;

    miles = 93000000; // 93 000 000 миль до Солнца

    // 5 280 футов в миле, 12 дюёмов в футе
    inches = miles * 5280 * 12;

    Console.WriteLine("Расстояние от Земли до Солнца: " +
                      inches + " дюймов.");
  }
}

