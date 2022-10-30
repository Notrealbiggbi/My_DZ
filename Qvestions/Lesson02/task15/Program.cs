// Напишите программу, которая 
//1. принимает на вход цифру, обозначающую день недели, и 
//2. проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет



// Console.Write("Введите номер дня недели: ");
// int num = Convert.ToInt32 (Console.ReadLine());

   
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

Console.Write("Введите номер дня недели: ");
int num = Convert.ToInt32 (Console.ReadLine());

void DayOfWeek (int x)
{
if (x > 0 && x < 6)
{
   Console.WriteLine("Будний день"); 
}
else Console.WriteLine("Выходной");
}

if (num > 0 && num < 8 )
{
    DayOfWeek(num);
}
else Console.WriteLine("Введены некоректные данные");