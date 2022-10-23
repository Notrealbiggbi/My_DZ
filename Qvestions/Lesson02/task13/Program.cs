﻿//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
//32679 -> 6


Console.WriteLine("Введите  число: ");
int Num = Convert.ToInt32(Console.ReadLine());
//              НЕОПТИМАЛЬНОЕ РЕШЕНИЕ
// if (num > 99 && num < 1000)
// {
// int Digit = num % 10; //   456 % 10 = 6     456 / 10 = 45 /10 = 4 / 10 = 0
// Console.WriteLine($"Третьей  цифрой числа {num} является {Digit}");
// }
// else if (num >1000 && num <10000)
// {
//     int Digit = num / 10 % 10 ;
//     Console.WriteLine($"Третьей  цифрой числа {num} является {Digit}");
// }
// else if (num >10000 && num <100000)
// {
//     int Digit = num / 100 % 10;
//     Console.WriteLine($"Третьей  цифрой числа {num} является {Digit}");
// }
// else if (num >100000 && num <1000000)
// {
//     int Digit = num / 1000 % 10;
//     Console.WriteLine($"Третьей  цифрой числа {num} является {Digit}");
// }
// else if (num >1000000 && num <10000000)
// {
//     int Digit = num / 10000 % 10;
//     Console.WriteLine($"Третьей  цифрой числа {num} является {Digit}");
// }
// else if (num >10000000 && num <100000000)
// {
//     int Digit = num / 100000 % 10;
//     Console.WriteLine($"Третьей  цифрой числа {num} является {Digit}");
// }
// else if (num >100000000 && num <1000000000)
// {
//     int Digit = num / 1000000 % 10;
//     Console.WriteLine($"Третьей  цифрой числа {num} является {Digit}");
// }
// else Console.WriteLine("Третьей цифры нет");


//              ОПТИМАЛЬНОЕ РЕШЕНИЕ
int SecondDigit(int Num )
{
    if (Num > 99 && Num < 1000) return Num % 10;
    if (Num > 1000 && Num < 10000) return Num / 10 % 10 ;
    if (Num > 10000 && Num < 100000) return Num / 100 % 10;
    if (Num > 100000 && Num < 1000000) return Num / 1000 % 10;
    return 0;
}
int Result = SecondDigit(Num);
string Final = Num > 99 && Num < 1000000 
                    ? $"Третьей  цифрой числа {Num} является {Result}" 
                    : "Третьей цифры нет";
Console.WriteLine(Final);
