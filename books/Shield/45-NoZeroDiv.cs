// Способ обойти деление на нуль с помощью оператора ?.

using System;

class NoZeroDiv {
  public static void Main() {
    int result;
    int i;

    for(i = -5; i < 6; i++) {
      result = i !=0 ? 100 / i : 0;
      if(i != 0)
        Console.WriteLine("100 / " + i + " равно " + result);
    }
  }
}

