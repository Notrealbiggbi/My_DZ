// Задача 28: Напишите программу, которая
// 1. принимает на вход число N и 
// 2. выдаёт произведение чисел от 1 до N.

// 4 -> 24
// 5 -> 120


Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

int MultNumbers(int num)
{
    int mult = 1;
    for (int i = 1; i <= num; i++)
    {
        //sum = sum * i;
        mult *= i;
    }
    return mult;
}
if (number > 0)
{
int MultRes = MultNumbers(number);
Console.WriteLine($"Произведение чисел от 1 до {number} -> {MultRes}");
}
else Console.WriteLine($"Вы ввели неправильное число, требуется положительное число");