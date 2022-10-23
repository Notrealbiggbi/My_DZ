// Напишите программу, которая 
//1.принимает на вход трёхзначное число и 
//2.на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.WriteLine("Введите трёхзначное число: ");
int Num = Convert.ToInt32(Console.ReadLine());


//    МОЁ  НЕОПТИМАЛЬНОЕ РЕШЕНИЕ
// if (num > 99 && num < 1000)
// {
// int SecondDigit = num / 10 % 10; //   456 % 10 = 6     456 / 10 = 45 /10 = 4 / 10 = 0
// Console.WriteLine($"Второй цифрой числа {num} является {Digit}");
// }
// else Console.WriteLine("Введено некоректное число");

//    МОЁ ОПТИМАЛЬНОЕ РЕШЕНИЕ

int SecondDigit (int Num)
{
   if (Num > 99 && Num < 1000) return Num / 10 % 10;
   return 0; 
}
int Result = SecondDigit (Num);
string Final = Num > 99 && Num < 1000
                    ? $"Второй  цифрой числа {Num} является {Result}" 
                    : "Третьей цифры нет";
Console.WriteLine(Final);
