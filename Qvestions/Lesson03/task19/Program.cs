//  Напишите программу, которая 
// 1. принимает на вход пятизначное число и 
// 2. проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int Num = Convert.ToInt32(Console.ReadLine());

void DigitPal(int num)
{
    if (num > 9999)
    {
        int a = num % 10;
        int b = num / 10000;
        int d = num / 10 % 10;
        int e = num / 1000 % 10;

        if (a == b && d == e)
        {
            Console.WriteLine($"{num} -> да");
        }
        else 
        {
            Console.WriteLine($"{num} -> нет");
        }
    }
    else
    {
        Console.WriteLine($"Введено не пятизначное число");
    }
}
DigitPal(Num);

