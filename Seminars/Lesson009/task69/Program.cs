// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.WriteLine("Введите натуральное число A: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число B: ");
int numB = Convert.ToInt32(Console.ReadLine());

int Exponetion(int a, int b)
{
    if (b == 0) return 1;
    return a * Exponetion(a, b - 1);
}

if (numB < 0)
{
    Console.WriteLine("Введено отрицательное число или 0! ");
    Console.WriteLine("Введите положительное число B: ");
    numB = Convert.ToInt32(Console.ReadLine());
}

int result = Exponetion(numA, numB);
Console.WriteLine($"возводит число {numA} в целую степень {numB} с помощью рекурсии {result} ");
