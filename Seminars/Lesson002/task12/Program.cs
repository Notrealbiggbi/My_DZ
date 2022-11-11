// Условие: Написать программу, которая 
// 1. на входе принимает два числа и 
// 2. выводить является ли второе число кратным первому.
// 3. Если число 1 не кратно числу 2, то выводит остаток от деления


Console.WriteLine("Введите первое число ");
int FirstDigit = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int SecondDigit = Convert.ToInt32(Console.ReadLine());



// if (FirstDigit % SecondDigit == 0)
// {
//     Console.WriteLine("Кратно");
// }
// else Console.WriteLine($"Не кратно остаток {FirstDigit % SecondDigit}");

bool Krat (int num1,int num2)
{
    int result = num1 % num2;
    if (result  == 0 ) return true;
    return false;
}
bool Result = Krat (FirstDigit , SecondDigit);
if (Result)
{
    Console.WriteLine("Кратно"); 
}
else Console.WriteLine($"Не кратно, остаток {FirstDigit % SecondDigit}");