// Использование операторов сдвига для
// умножения и деления на 2.

using System;

class MultDiv {
  public static void Main() {
    int n;

    n = 10;

    Console.WriteLine("Значение переменной n: " + n);

    // Умножаем на 2.
    n = n << 1;
    Console.WriteLine("Значение переменной n после n = n * 2: " + n);

    // Умножаем на 4.
    n = n << 2;
    Console.WriteLine("Значение переменной n после n = n * 4: " + n);

    // Делим на 2.
    n = n >> 1;
    Console.WriteLine("Значение переменной n после n = n / 2: " + n);

    // Делим на 4.
    n = n >> 2;
    Console.WriteLine("Значение переменнной n после n = n / 4: " + n);

    Console.WriteLine();

    // Устанавливаем n в исходное состояние.
    n = 10;
    Console.WriteLine("Значение переменной n: " + n);

    // Умножаем на 2, причём 30 раз.
    n = n << 30; // Увы, данные потеряны.
    Console.WriteLine("Значение n после сдвига влево на 30 разрядов: " + n);
  }
}

