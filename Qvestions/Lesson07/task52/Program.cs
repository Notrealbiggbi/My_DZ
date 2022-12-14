// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max) // создаём метод где используем расчёт двумерного массива с случайными числами
{
    Random rnd = new Random();
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }

    }
    return matrix;
}

void PrintMatrix(int[,] matrix)// создаём метод с выводом прошлого метода
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5}   |");
            else Console.Write($"{matrix[i, j],5} ");
        }
        Console.WriteLine("  |");
    }
}


double[] AverageMatrixRndIntColums(int[,] matrix)
{
    double[] arrayAverage = new double[matrix.GetLength(1)];
    double sum = arrayAverage[0];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        arrayAverage[j]= sum / matrix.GetLength(1);
        sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        { 
            sum = sum + matrix[i, j];
        }
        arrayAverage[j]= sum / matrix.GetLength(1);
    }
    
    return arrayAverage;
}

void PrintArray(double[] array) // создаём метод с выводом прошлого метода
{
    Console.Write("Среднее арифметическое каждого столбца:[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(Math.Round(array[i], 2, MidpointRounding.ToZero));
        if (i < array.Length - 1) Console.Write("|");
    }
    Console.WriteLine("]");
}


int[,] mat = CreateMatrixRndInt(3, 3, 0, 10);
PrintMatrix(mat);
double[] result = AverageMatrixRndIntColums(mat);
PrintArray(result);
