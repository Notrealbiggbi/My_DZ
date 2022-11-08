// Задача 27: Напишите программу, которая 
// 1. принимает на вход число и 
// 2. выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());


int SumDig(int num)
{
    num = Math.Abs(num);
    int count = 0;
    // for (int i = num; i > 0; i /= 10)
    // {
    //     count = count + i % 10;
    // }
    // return count > 0 ? count : 1;

    while (num > 0)
    {
        // num = num / 10;
        int i =num;
        num /= 10;
        count = count + i % 10;

    }
    return count > 0 ? count : 1;
}


int result = SumDig(number);
Console.WriteLine($"сумма числа {number} -> {result}");


