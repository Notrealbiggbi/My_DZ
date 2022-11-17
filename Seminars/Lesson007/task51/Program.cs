﻿// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.


int[,] CreateMatrixRndInt(int rows, int colums, int min, int max) // создаём метод где используем расчёт двумерного массива с случайными числами
{
    Random rnd = new Random();
    int[,] matrix = new int[rows, colums];
    for (int i = 0; i < matrix.GetLength(0); i++) // строки
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // столбцы
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

int SumElementsMatrix(int[,] matrix)
{
    int sum = 0;
    int minLength = matrix.GetLength(1);
    if (matrix.GetLength(0) < matrix.GetLength(1)) minLength = matrix.GetLength(0);
    for (int i = 0; i < minLength; i++) sum += matrix[i, i];
    return sum;
}



// int[,] mat = CreateMatrixRndInt(3, 4, 0, 10); // создаём переменную для запроса метода
// PrintMatrix(mat); // печатаем метод
// Console.WriteLine();
// SumElementsMatrix(mat);
// PrintMatrix(mat);

int[,] mat = CreateMatrixRndInt(3, 5, 0, 10);
PrintMatrix(mat);
int res = SumElementsMatrix(mat);
Console.WriteLine($"Сумма элементов диагонали равна: {res}");
