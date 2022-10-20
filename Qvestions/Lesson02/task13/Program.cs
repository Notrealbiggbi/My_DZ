//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
//32679 -> 6


Console.WriteLine("Введите  число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 99 && num < 1000)
{
int LastDigit = num % 10; //   456 % 10 = 6     456 / 10 = 45 /10 = 4 / 10 = 0
Console.WriteLine($"Третьей  цифрой числа {num} является {LastDigit}");
}
else if (num >1000 && num <10000)
{
    int LastDigit = num / 10 % 10 ;
    Console.WriteLine($"Третьей  цифрой числа {num} является {LastDigit}");
}
else if (num >10000 && num <100000)
{
    int LastDigit = num / 10 / 10 % 10;
    Console.WriteLine($"Третьей  цифрой числа {num} является {LastDigit}");
}
else if (num >100000 && num <1000000)
{
    int LastDigit = num / 10 / 10 / 10 % 10;
    Console.WriteLine($"Третьей  цифрой числа {num} является {LastDigit}");
}
else Console.WriteLine("Третьей цифры нет");
