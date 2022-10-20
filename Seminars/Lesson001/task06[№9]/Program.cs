//Условие: Напишите программу, которая 
//1. выводит случайное число из отрезка [10,99] и 
//2. показывает наибольшую цифру числа.

int num = new Random().Next(10,100);//10,11,12,13...99
Console.WriteLine($"Сгенерировано число {num}");

int FirstDigit = num / 10;
int SecondDigit = num % 10;
if(FirstDigit > SecondDigit)
{
    Console.WriteLine($"В числе {num} наибольшая цифра {FirstDigit}");
}
else if(FirstDigit < SecondDigit)
{
    Console.WriteLine($"В числе {num} наибольшая цифра {SecondDigit}");
}
else if(FirstDigit == SecondDigit) 
{
Console.WriteLine($"В числе {num} цифры равны ");
}
