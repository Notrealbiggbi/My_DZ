﻿// Условие: Написать программу которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 799 -> 9
// 910 -> 0

Console.WriteLine("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 99 && num < 1000)
{
int LastDigit = num % 10; //   456 % 10 = 6     456 / 10 = 45 /10 = 4 / 10 = 0
Console.WriteLine($"Последней цифрой числа {num} является {LastDigit}");
}
else Console.WriteLine("Введено некоректное число");