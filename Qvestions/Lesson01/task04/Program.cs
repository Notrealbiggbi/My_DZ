// Условие: Написать программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите первое целое число: ");
int number1 = Convert.ToInt32 (Console.ReadLine());
Console.Write("Введите второе целое число: ");
int number2 = Convert.ToInt32 (Console.ReadLine());
Console.Write("Введите третье целое число: ");
int number3 = Convert.ToInt32 (Console.ReadLine());

if (number1 > number2 && number3 < number1)
{
   Console.WriteLine($"Число {number1} больше чем число {number2} и больше чем число {number3}"); 
}
if (number2 > number3 && number3 < number2 )
{
   Console.WriteLine($"Число {number2} больше чем число {number1} и больше чем число {number3}"); 
}
if (number3 > number2 && number1 < number3)
{
   Console.WriteLine($"Число {number3} больше чем число {number2} и больше чем число {number1}");
}