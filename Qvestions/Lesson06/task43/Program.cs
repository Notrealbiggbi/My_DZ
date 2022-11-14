// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите число b1:  ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число k1:  ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b2:  ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число k2:  ");
int k2 = Convert.ToInt32(Console.ReadLine());


void lineIntersection(int B1, int K1, int B2, int K2)
{
    double num1 = K1 - K2;
    double num2 = -B1 + B2;
    double x = num2 / num1;
    double y = K2 * x + B2;
    Console.WriteLine($"b1 = {B1}, k1 = {K1}, b2 = {B2}, k2 = {K2} ->({Math.Round(x ,2, MidpointRounding.ToZero)}), ({Math.Round(y ,2, MidpointRounding.ToZero)}) ");
}

lineIntersection(b1, k1, b2, k2);
