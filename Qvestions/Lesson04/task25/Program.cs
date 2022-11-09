// // Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16


Console.WriteLine("Введите положительное число число А: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите положительное число В: ");
int num2 = Convert.ToInt32(Console.ReadLine());

//ВАРИАНТ ЧЕРЕЗ Math.
// double Expon(int number1, int number2)
// {
//     int a = number1;
//     int b = number2;
//     double exponentiation = Math.Pow(a, b); 
//     return exponentiation;
// }
// double Res = Expon(num1,num2);
// Console.Write($"{num1},{num2} -> {Res}");

// ВАРИАНТ ЧЕРЕЗ FOR
int Expon(int number1, int number2)
{
    int exponetinetion = 1;
    for (int i = 0; i < number2; i++)
    {
       exponetinetion *= number1;
    }
    return exponetinetion;
}

if (num1 > 0 && num2 > 0)
{
double Res = Expon(num1, num2);
Console.Write($"{num1},{num2} -> {Res}");
}
else Console.WriteLine("Введено некоректное число ");
