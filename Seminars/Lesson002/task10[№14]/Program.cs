// Условие: Написать программу, которая 
// 1. принимает на вход число и 
// 2. проверяет кратно оно одновременно 7 и 23.

bool DivNum(int digit,int num1, int num2 )
{
    int result1 = digit % num1;
    int result2 = digit % num2;
    if (result1 == 0 && result2 == 0 ) return true;
    return false;
}


Console.WriteLine("Введите  число ");
int num = Convert.ToInt32(Console.ReadLine());

int number1 = 7;
int number2 = 23;

bool result = DivNum (num, number1, number2);
if (result)
{
    Console.WriteLine("Кратно");
}
else Console.WriteLine("Не кратно");