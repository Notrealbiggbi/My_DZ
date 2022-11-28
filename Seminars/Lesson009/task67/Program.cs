// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9


Console.WriteLine("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());


int SumElements(int n)
{
    // 1! = 1
    // 0! = 1
    if (n == 0) return n;
    return n % 10 + SumElements(n / 10);

}

int res = SumElements(number);
Console.WriteLine($"Суммой всех эллементов в числе {number} является {res}");