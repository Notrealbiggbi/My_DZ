// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координаты точки X1:  ");
int X1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки Y1:  ");
int Y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки Z1:  ");
int Z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки X2:  ");
int X2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки Y2:  ");
int Y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки Z2:  ");
int Z2 = Convert.ToInt32(Console.ReadLine());




double Range(int x1, int y1, int z1, int x2, int y2, int z2)
{
    int RangeX = x1 - x2;
    int RangeY = y1 - y2;
    int RangeZ = z1 - z2;
    double RangeN = Math.Sqrt(RangeX * RangeX  + RangeY * RangeY + RangeZ * RangeZ);
    return RangeN;
}
double Result = Range(X1, Y1, Z1, X2, Y2, Z2);
Console.WriteLine($"A({X1},{Y1},{Z1}): B({X2},{Y2},{Z2})-> {Math.Round(Result, 2, MidpointRounding.ToZero)}");