// Демонстрирует использование методов Math.Sin(),
// Vath.Cos() и Math.Tan()

using System;

class Trigonometry {
  public static void Main() {
    double theta; // Угол задан в радианах.

    for(theta = 0.1; theta <= 1.0; theta = theta + 0.1) {
      Console.WriteLine("Синус угла "   + theta + " равен " + Math.Sin(theta));
      Console.WriteLine("Косинус угла " + theta + " равен " + Math.Cos(theta));
      Console.WriteLine("Тангенс угла " + theta + " равен " + Math.Tan(theta));
      Console.WriteLine();
    }
  }
}

