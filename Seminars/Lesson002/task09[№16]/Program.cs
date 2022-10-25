// Условие: Написаать программу, которая 
// 1. на вход принимает два числа и 
// 2. проверяет, является ли одно число квадратом другого.


Console.WriteLine("Введите первое число ");
int FirstDigit = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int SecondDigit = Convert.ToInt32(Console.ReadLine());



if ( FirstDigit % SecondDigit == 0)
{
    Console.WriteLine("Да");
}
else if ( SecondDigit % FirstDigit == 0)
{
    Console.WriteLine("Да");
}
else Console.WriteLine("Нет");