//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
//32679 -> 6


//                  РЕШЕНИЕ 1
// Console.WriteLine("Введите  число: ");
// int Num = Convert.ToInt32(Console.ReadLine());
//            МОЁ  НЕОПТИМАЛЬНОЕ РЕШЕНИЕ
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


//              РЕШЕНИЕ 2

// Console.WriteLine("Введите  число: ");
// int Num = Convert.ToInt32(Console.ReadLine());

// int Digit(int Number )
// {
//     if (Number > 99 && Number < 1000) return Number % 10;
//     if (Number > 1000 && Number < 10000) return Number / 10 % 10 ;
//     if (Number > 10000 && Number < 100000) return Number / 100 % 10;
//     if (Number > 100000 && Number < 1000000) return Number / 1000 % 10;
//     if (Number > 1000000 && Number < 10000000) return Number / 10000 % 10;
//     if (Number > 10000000 && Number < 100000000) return Number / 100000 % 10;
//     if (Number > 100000000 && Number < 1000000000) return Number / 1000000 % 10;
//     if (Number > 1000000000 && Number < 2000000000) return Number / 10000000 % 10;
//     return 0;
// }
// int Result = Digit(Num);
// if (Num > 99  )
// {
//     Console.WriteLine($"Третьей  цифрой числа {Num} является {Result}");
// }
// else 
// {
//     Console.WriteLine("Третьей цифры нет");
// }



//             РЕШЕНИЕ 3: ЧЕРЕЗ МЕТОД
Console.WriteLine("Введите  число: ");
int Num = Convert.ToInt32(Console.ReadLine());

void Digit(int x)
{
    int res = x % 10;
    Console.WriteLine($"Третьей  цифрой числа {Num} является {res}");
}
void Digit2(int z)
{
    while (z > 999)
    {
        z = z / 10;
        if (z < 1000)
        {
            z = z % 10;
            Console.WriteLine($"Третьей  цифрой числа {Num} является {z}");
        }
    }

}




if (Num > 99 && Num < 1000)
{
    Digit(Num);
}
else if (Num > 999 && Num < 1000000000)
{
    Digit2(Num);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}

