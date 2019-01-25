// Демонстрация цикла for.

using System;

class ForDemo {
  public static void Main() {
    int count;

    for(count = 0; count < 5; count = count + 1)
      Console.WriteLine("Это счёт: " + count);

    Console.WriteLine("Готово!");
  }
}

