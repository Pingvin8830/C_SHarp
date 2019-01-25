// Использование оператора XOR для шифрования
// и дешифрования сообщения.

using System;

class Encode {
  public static void Main() {
    char ch1 = 'H';
    char ch2 = 'i';
    char ch3 = '!';

    int key = 88;

    Console.WriteLine("Исходное сообщение: " + ch1 + ch2 + ch3);

    // Шифруем сообщение.
    ch1 = (char) (ch1 ^ key);
    ch2 = (char) (ch2 ^ key);
    ch3 = (char) (ch3 ^ key);

    Console.WriteLine("Зашифрованное сообщение: " + ch1 + ch2 + ch3);

    // Дешифруем сообщение.
    ch1 = (char) (ch1 ^ key);
    ch2 = (char) (ch2 ^ key);
    ch3 = (char) (ch3 ^ key);

    Console.WriteLine("Дешифрованое сообщение: " + ch1 + ch2 + ch3);
  }
}

