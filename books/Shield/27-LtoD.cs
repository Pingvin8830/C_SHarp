// Демонстрация автоматического преобразования типов
// из long в double.

using System;

class LtoD {
  public static void Main() {
    long L;
    double D;

    L = 100123285L;
    D = L;

    Console.WriteLine("L и D: " + L + " " + D);
  }
}

