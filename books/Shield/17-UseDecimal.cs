// Использование типа decimal для вычисления скидки.

using System;

class UseDecimal {
  public static void Main() {
    decimal price;
    decimal discount;
    decimal discounted_price;

    // Вычисляем цену со скидкой.
    price = 19.95m;
    discount = 0.15m; // Ставка дисконта равна 15%.

    discounted_price = price - (price * discount);

    Console.WriteLine("Цена со скидкой: $" + discounted_price);
  }
}

