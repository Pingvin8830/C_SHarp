// Использование поразрядного оператора ИЛИ для
// "превращения" любого числа в нечётное.

using System;

class MakeOdd {
  public static void Main() {
    ushort num;
    ushort i;

    for(i = 1; i <= 10; i++) {
      num = i;

      Console.WriteLine("num: " + num);

      num = (ushort) (num | 1); // num | 0000 0001

      Console.WriteLine("num после установки младшего бита: " + num + "\n");
    }
  }
}

