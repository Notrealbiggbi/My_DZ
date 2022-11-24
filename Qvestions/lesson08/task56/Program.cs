// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


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

int[] SumMatrixRowsArray(int[,] matrix)
{
    int[] sumArray = new int[matrix.GetLength(0)];
    int sum = sumArray[0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sumArray[i] = sum;
        sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i, j];
        }
        sumArray[i] = sum;
    }
    return sumArray;
}

void PrintArray(int[] array) // создаём метод с выводом прошлого метода
{
    Console.Write("Сумма каждой строки:[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1) Console.Write("|");
    }
    Console.WriteLine("]");
}

int ComparisonElementsOfArray(int[] array)
{
    int min = array[0];
    // int count = 0;
    int minind = 0;
    for (int i = 0; i < array.Length; i++)
    {
        
        if (min > array[i])
        {
            min = array[i];
            minind =i; 

        }
        
        
    }
    return minind+1;
}

Console.WriteLine("Введите размер строк массива: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер столбцов массива: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] mat = CreateMatrixRndInt(number1, number2, 1, 10);
PrintMatrix(mat);
Console.WriteLine();
int[] sum = SumMatrixRowsArray(mat);
PrintArray(sum);
int res = ComparisonElementsOfArray(sum);
Console.WriteLine($"Самая маленькая сумма в строке  {res}");
