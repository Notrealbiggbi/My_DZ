// Условие: Написать программу, которая 
// 1. выводит случайное трёхзначное число и 
// 2. удаляет вторую цифру этого числа
// 456->46
// 782->72
// 918->98


int num = new Random().Next(100,1000);
Console.WriteLine($"Сгенерировано число {num}");

int DelDig (int number)
{
    int FirstDigit = number / 100;
    int ThirtDigit = number % 10;
    return FirstDigit*10+ThirtDigit;
}
int result = DelDig(num);
Console.WriteLine($"Получено число {result}");