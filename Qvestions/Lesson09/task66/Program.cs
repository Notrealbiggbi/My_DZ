// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число M: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int numN = Convert.ToInt32(Console.ReadLine());

int SumElements(int n)
{
 // 1! = 1
 // 0! = 1
 if(n == 0) return 0;
 else return n + SumElements(n-1);
}
for (int i = numM; i <= numN; i++)
{
 Console.WriteLine($"{i}! = {SumElements(i)}");
}
int res = SumElements(numN);