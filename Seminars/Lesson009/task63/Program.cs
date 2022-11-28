// Задача 63: Задайте значение N. Задайте программу, которая выдаёт все натуральные числа от 1 до N.

// N = 5 -> "1, 2, 3, 4, 5." 

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

void NaturalNumbers (int num)
{
    if(num==0) return;
    NaturalNumbers(num -1);
    Console.Write($"{num} ");
}
NaturalNumbers(number);