// Условие: Написать программу, которая 
// 1. принимает на вход (N) и 
// 2. выдаёт таблицу увадратов чисел от 1 до N.

// 5 -> 1, 4, 9, 15, 25
//2 -> 1, 4

Console.WriteLine("Введите число ");
int Number = Convert.ToInt32(Console.ReadLine());

void SquareT(int num)
{
    if (num > 0)
    {
        for (int X = 1; X <= num; X++)
        {
            Console.WriteLine($"{X,4}  {X * X,4}");
        }
    }
    else
    {
        Console.WriteLine("Введите число больше 0");
    }
}
SquareT(Number);