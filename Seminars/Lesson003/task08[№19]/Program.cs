// Условие: Напишите программу которая 
//1. на входе принимает  четверти плоскости
//2. Условие Х  не равную 0 и Y не равную 0 и 
//3. выдаёт диапазон возможных координат точки (Х, Y)
Console.WriteLine("Введите номер четверти плоскости ");
int quarter = Convert.ToInt32(Console.ReadLine());


string Quarter(int quarter_xy)
{
    if (quarter_xy==1) return "x > 0 && y > 0";
    if (quarter_xy==2) return "x < 0 && y > 0";
    if (quarter_xy==3) return "x < 0 && y < 0";
    if (quarter_xy==4) return "x > 0 && y < 0";
    return "данные введены некорректно";
}

string xy = Quarter(quarter);
Console.Write($"Диапазон чертвети {quarter}: ");
Console.WriteLine(xy);
