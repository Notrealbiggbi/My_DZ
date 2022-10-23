// Напишите программу, которая 
//1. принимает на вход цифру, обозначающую день недели, и 
//2. проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет



Console.Write("Введите номер дня недели: ");
int Num = Convert.ToInt32 (Console.ReadLine());

//     МОЁ НЕОПТИМАЛЬНОЕ РЕШЕНИЕ
// if (num < 6)
// {
//     Console.WriteLine("Нет, сегодня будний день");
// }
// else if (num > 5 )
// {
//     Console.WriteLine("Да, сегодня выхоной");
// }
// else if(num > 7)
// {
//      Console.WriteLine("Такого дня недели нет");
// }

// МОЁ ОПТИМАЛЬНОЕ РЕШЕНИЕ

int DaysOfTheWeek (int Number)
{
   if (Number < 6) return 1;
   if (Number > 5 ) return 2;
   return 0;
}
int Result = DaysOfTheWeek(Num);
string Final = Num > 0 && Num < 6 
                    ? $"Нет, сегодня будний день" 
                    : "Да, сегодня выхоной";
Console.WriteLine(Final);