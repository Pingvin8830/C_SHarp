// Демонстрация использования значений типа bool.

using System;

class BoolDemo {
  public static void Main() {
    bool b;

    b = false;
    Console.WriteLine("b содержит " + b);

    b = true;
    Console.WriteLine("b содержит " + b);

    // Значение типа bool может управлять if-инструкцией.
    if(b) Console.WriteLine("Эта инструкция выполняется.");

    b = false;
    if(b) Console.WriteLine("Эта инструкция не выполняется.");

    // Оператор отношения возвращает результат типа bool.
    Console.WriteLine("10 > 9 равно " + (10 > 9));
  }
}

