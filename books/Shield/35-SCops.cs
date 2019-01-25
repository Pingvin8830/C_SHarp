// Демонстрация использования сокращённых операторов.

using System;

class SCops {
  public static void Main() {
    int n, d;

    n = 10;
    d = 2;
    if(d != 0 && (n % d) == 0) Console.WriteLine(d + " -- множитель числа " + n);

    d = 0; // Теперь установим d равным нулю.

    // Поскольку d равно нулю,
    // второй операнд не вычисляется.
    if(d != 0 && (n % d) == 0) Console.WriteLine(d + " -- множитель числа " + n);

    /*  Теперь попробуем проделать то же самое без
        сокращённого оператора. Такая попытка приведёт
        к ошибке (деление на нуль). */
    if(d != 0 & (n % d) == 0) Console.WriteLine(d + " -- множитель числа " + n);
  }
}

