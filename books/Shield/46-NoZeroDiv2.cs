// Способ обойти деление на нуль с помощью ?-оператора.

using System;

class NoZeroDiv2 {
  public static void Main() {
    int i;

    for(i = -5; i < 6; i++)
      if(i != 0 ? true : false)
        Console.WriteLine("100 / " + i + " равно " + 100 / i);
  }
}

