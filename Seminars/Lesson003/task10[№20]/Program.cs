// Условие: Написать программу которая принимает 
// 1. на вход координаты двух точек и 
// 2. находит расстояние между ними в 2D пространстве
// A(3,6): B(2,1)-> 5,09;
// A(7,-5): B(1,-1)-> 7,21;

Console.Write("Введите координаты точки X1:  ");
int X1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки Y1:  ");
int Y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки X2:  ");
int X2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки Y2:  ");
int Y2 = Convert.ToInt32(Console.ReadLine());

double Range(int x1, int y1, int x2, int y2)
{
    int RangeX = x1 - x2;
    int RangeY = y1 - y2;
    double RangeZ = Math.Sqrt(RangeX * RangeX + RangeY * RangeY);
    return RangeZ;
}
double Result = Range(X1, Y1, X2, Y2);
Console.WriteLine($"A({X1},{Y1}): B({X2},{Y2})-> {Math.Round(Result, 2, MidpointRounding.ToZero)}");
