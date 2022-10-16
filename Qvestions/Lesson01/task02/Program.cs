// Условие: Написать программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее. 
Console.Write("Введите первое целое число: ");
int number1 = Convert.ToInt32 (Console.ReadLine());
Console.Write("Введите второе целое число: ");
int number2 = Convert.ToInt32 (Console.ReadLine());

// if (number1 == number2)
// {
//    Console.WriteLine($"Число {number1} равно числу {number2}"); 
// }
// а если числа равные? Как прекратить выполнение программы? 

if (number1 > number2)
{
   Console.WriteLine($"Число {number1} больше чем число {number2}"); 
}
else
{
   Console.WriteLine($"Число {number1} меньше чем число {number2}"); 
}
