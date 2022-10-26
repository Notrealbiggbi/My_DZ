﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125
Console.WriteLine("Введите число ");
int Number = Convert.ToInt32(Console.ReadLine());

void Kub(int number)
{
    if (number > 0)
    {
        for (int a = 1; a <= number; a++)
        {
            Console.WriteLine($"{a}  {a * a * a}");
        }
    }
    else
    {
        Console.WriteLine("Введите число больше 0");
    }
}
Kub(Number);