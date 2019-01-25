// Использование поразрядного оператора И для
// "превращения" любого числа в чётное.

using System;

class MakeEven {
  public static void Main() {
    ushort num;
    ushort i;

    for(i = 1; i <= 10; i++) {
      num = i;

      Console.WriteLine("num: " + num);

      num = (ushort) (num & 0xFFFE); // num & 1111 1110

      Console.WriteLine("num после сброса младшего бита: " + num + "\n");
    }
  }
}

