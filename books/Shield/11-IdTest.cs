// Демонстрирует использование @-идентификатора.

using System;

class IdTest {
  static void Main() {
    int @if; // Используем if в качестве идентификатора.

    for(@if = 0; @if < 10; @if++)
      Console.WriteLine("@if равно " + @if);
  }
}

