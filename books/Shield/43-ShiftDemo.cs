// Демонстрация использования операторов сдвига << и >>.

using System;

class ShiftDemo {
  public static void Main() {
    int val = 1;
    int t;
    int i;

    for(i = 0; i < 8; i++) {
      for(t=128; t > 0; t = t / 2) {
        if((val & t) != 0) Console.Write("1 ");
        if((val & t) == 0) Console.Write("0 ");
      }
      Console.WriteLine();
      val = val << 1; // Сдвиг влево.
    }
    Console.WriteLine();

    val = 128;
    for(i = 0; i < 8; i++) {
      for(t=128; t > 0; t = t / 2) {
        if((val & t) != 0) Console.Write("1 ");
        if((val & t) == 0) Console.Write("0 ");
      }
      Console.WriteLine();
      val = val >> 1; // Сдвиг вправо.
    }
    Console.WriteLine();
  }
}

