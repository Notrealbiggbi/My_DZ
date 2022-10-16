Console.Write("Введите первое целое число: ");
int number1 = Convert.ToInt32 (Console.ReadLine());
Console.Write("Введите второе целое число: ");
int number2 = Convert.ToInt32 (Console.ReadLine());

int square = number2 * number2;

if (square==number1)
{
   Console.WriteLine($"Квадрат числа {number2} равен числу {number1}"); 
}
else
{
   Console.WriteLine($"Квадрат числа {number2} не равен числу {number1}"); 
}