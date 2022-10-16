// Напишите программу,которая 
// 1.на вход принимает число и 
// 2.выдаёт его квадрат(число умнеоженное на само себя)
// например: 4-> 16
//         -3 -> 9
//         -7 -> 49


Console.Write("Введите целое число: ");
int number = Convert.ToInt32 (Console.ReadLine());

// string str = Console.ReadLine();
// int num = Convert.ToInt32(str);

int square = number * number;
Console.WriteLine($"Квадрат числа {number} = {square}");