// Условие: Написаать программу, которая 
// 1. на вход принимает два числа и 
// 2. проверяет, является ли одно число квадратом другого.

//5,25 -> yes
//25,5 -> yes
// 8,9 -> no
// -4,16 -> yes

Console.WriteLine("Введите первое число ");
int FirstDigit = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int SecondDigit = Convert.ToInt32(Console.ReadLine());


bool Krat(int num1, int num2)
{
    int result1 = num1 * num1;
    int result2 = num2 * num2;
    if (result1 == num2 || result2 == num1) return true;
    return false;
}
bool Result = Krat(FirstDigit, SecondDigit);

if (Result)
{
    Console.WriteLine("Да");
}
else Console.WriteLine("Нет");