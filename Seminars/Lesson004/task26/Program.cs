// Задача 26: Напишите программу, которая принимает
// 1. на вход число и 
// 2. выдаёт количество цифр в числе.

// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());


int ColDig(int num)
{
    num = Math.Abs(num);
    // Цикл WHILE
    int count = 0;
    while (num > 0)
    {
        // num = num / 10;
        count++;
        num /= 10;

    }
    return count > 0 ? count : 1;

    // Цикл FOR
    // int count = 0;

    // for (int i = num; i > 0; i /= 10)
    // {
    //     count++;
    // }
    // return count > 0 ? count : 1;


}


int result = ColDig(number);
Console.WriteLine($"колличество цифр в {number} -> {result}");

