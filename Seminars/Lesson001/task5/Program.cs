//Условие: Написать программу которая 
// 1.на входе принимает одно число(N), а 
// 2.на выходе показывает все целые числа в промежутке от -N до N.

// 4 -> -4,-3,-2,-1, 0, 1, 2, 3, 4
// 2 -> -2,-1, 0, 1, 2

Console.WriteLine("Введите положительное целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 0)
{
    int count = -num;

    while (count <= num)
    {
        Console.Write($"{count} ");
        count++;
    }
}
else Console.WriteLine("Вы ввели некоректное значение");