// Демонстрация буквальных строковых литералов.

using System;

class Verbatim {
  public static void Main() {
    Console.WriteLine(@"Это буквальный
строковый литерал,
который занимает несколько строк.
");

  Console.WriteLine(@"А теперь воспользуемся табуляцией:
1 2   3     4
5 6   7     8
");

  Console.WriteLine(@"Отзыв программиста: ""Мне нравится C#.""");
  }
}

