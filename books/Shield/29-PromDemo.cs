// Сюрприз в результате продвижения типов!

using System;

class PromDemo {
  public static void Main() {
    byte b;
    b = 10;
    b = (byte) (b * b); // необходимо приведение типов!!

    Console.WriteLine("b: " + b);
  }
}

