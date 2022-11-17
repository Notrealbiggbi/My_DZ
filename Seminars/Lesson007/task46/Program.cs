﻿// Задача 46: Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1




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

// void PrintMatrix(int[,] matrix) // создаём метод с выводом прошлого метода
// {

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         Console.Write("[");
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i,j]);
//             if (j < matrix.GetLength(1) - 1) Console.Write(",");
//             Console.WriteLine("]");
//         }
//     }
// }
void PrintMatrix(int[,] matrix)// создаём метод с выводом прошлого метода
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i,j], 5}   |");
            else Console.Write($"{matrix[i,j], 5} ");
        }
        Console.WriteLine("  |");
    }
}



int[,] mat = CreateMatrixRndInt(3, 4, -1000, 1000); // создаём переменную для запроса метода
PrintMatrix(mat); // печатаем метод