// Находим радиус круга по его площади.

using System;

class FindRadius {
  public static void Main() {
    double r;
    double area;

    area = 10.0;

    r = Math.Sqrt(area / 3.1416);

    Console.WriteLine("Радиус равен " + r);
  }
}

