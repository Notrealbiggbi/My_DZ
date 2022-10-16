// Условие: Написать программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите первое  число: ");
double number1 = Convert.ToDouble (Console.ReadLine());
Console.Write("Введите второе число: ");
double number2 = Convert.ToDouble (Console.ReadLine());
Console.Write("Введите третье  число: ");
double number3 = Convert.ToDouble (Console.ReadLine());

// double a = number1, b = number2, c = number3; 

// double max = a;

// if(a > max) max = a;
// if(b > max) max = b;
// if(c > max) max = c;
// Console.Write($"Максимальное число {max}");
// Более оптимальное решение

if (number1 > number2 && number3 < number1)
{
   Console.WriteLine($"Число {number1} максимальное"); 
}
else if (number2 > number3 && number3 < number2 )
{
   Console.WriteLine($"Число {number2} максимальное"); 
}
else if (number3 > number2 && number1 < number3)
{
   Console.WriteLine($"Число {number3} максимальное");
}
