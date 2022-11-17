// Задача 48: Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: Amn = m+n.
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5


int[,] CreateMatrixInt(int rows, int colums) // создаём метод где используем расчёт двумерного массива с случайными числами
{
    
    int[,] matrix = new int[rows, colums];
    for (int i = 0; i < matrix.GetLength(0); i++) // строки
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // столбцы
        {
            matrix[i, j] = i + j;
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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i,j], 5}   |");
            else Console.Write($"{matrix[i,j], 5} ");
        }
        Console.WriteLine("  |");
    }
}

int[,] mat = CreateMatrixInt(3, 4); // создаём переменную для запроса метода
PrintMatrix(mat); // печатаем метод