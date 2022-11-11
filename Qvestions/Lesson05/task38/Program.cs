// Задача 38: 
// 1 . Задайте массив вещественных чисел. 
// 2. Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        array[i] = Math.Round(num, 1);
    }
    return array;
}

void PrintArray(double[] array) // создаём метод с выводом прошлого метода
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1) Console.Write(" ,");
    }
    Console.WriteLine("]");
}

double FindMinMaxNumber(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int min = 0;
        int max = 0;
        
    }
}

double DiffMinMaxNumber(int size, int min, int max)
{

}

double[] arr = CreateArrayRndDouble(5, 0, 10);
PrintArray(arr);
