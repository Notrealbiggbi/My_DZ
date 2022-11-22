//Задача 55: Задайте двумерный массив. 
// Напишите программу, которая заменит все строки на столбцы. 
// В случае если это невозможно программа должна вывести сообщение для пользователя.




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



// int[,] ReplaceRowsToColumns(int[,] matrix)
// {
//     int temp = default;

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = i; j < matrix.GetLength(1); j++)
//         {
//             temp = matrix[i, j];
//             matrix[i, j] = matrix[j, i];
//             matrix[j, i] = temp;
//         }
//     }

//     return matrix;
// }

// int[] NewArray(int[,] matrix)
// {

//     if (matrixRnd.GetLength(0) == matrixRnd.GetLength(1))
//     {
//         int[,] replaceMatrix = ReplaceRowsToColumns(matrixRnd);
//         PrintMatrix(matrixRnd);
//     }
//     else Console.WriteLine("Вводите массив с равным количеством столбцов и строк");

// }


int[,] mat = CreateMatrixRndInt(3, 5, 0, 10);
PrintMatrix(mat);
