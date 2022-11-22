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



int[,] ReplaceRowsToColumns(int[,] matrix)
{
    int[,] newMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            newMatrix[i, j] = matrix[j, i];
        }
    }
    return newMatrix;
}


//Другой способ изменения не создавая новый массив
// int[,] ReplaceRowsToColumns(int[,] matrix)
// {
    
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = i; j < matrix.GetLength(1); j++)
//         {
//             int temp = matrix[i,j];
//             matrix[i, j] = matrix[j, i];
//             matrix[j, i] = temp;
//         }
//     }
//     return matrix;
// }

Console.WriteLine("Введите размер строк массива: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер столбцов массива: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int[,] mat = CreateMatrixRndInt(number1,number2 , 0, 10);
if (mat.GetLength(0)==mat.GetLength(1))
{
    Console.WriteLine("массив заполненный случайными целыми числами");
    PrintMatrix(mat);
Console.WriteLine("массив заполненный случайными целыми числами в котором поменяны строуки и столбцы");
int[,] res = ReplaceRowsToColumns(mat);
PrintMatrix(res);
}
else Console.WriteLine("невозможно заменить строки на столбцы");

