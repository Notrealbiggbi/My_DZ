// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] StreamlineElementsOfRowsMatrix(int[,] matrix, int[,] matrix2)
{
    int[,] thirdMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
    int streamline = 0;
    int sumMatrix = 0;
    for (int x = 0; x < matrix.GetLength(1); x++)
    {
        thirdMatrix[0, x] = sumMatrix;
        for (int y = 0; y < matrix.GetLength(0); y++)
        {
            thirdMatrix[y, 0] = sumMatrix;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                thirdMatrix[i, x] = sumMatrix;

                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    streamline = matrix[0, j] * matrix2[i, 0];
                    sumMatrix = sumMatrix + streamline;

                }

            }
            y++;
        }
        x++;
    }
    return thirdMatrix;
}

Console.WriteLine("Введите размер строк первой матрицы: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер столбцов первой матрицы: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер строк второй матрицы: ");
int number3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер столбцов второй матрицы: ");
int number4 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] mat = CreateMatrixRndInt(number1, number2, 1, 10);
int[,] newMat = CreateMatrixRndInt(number3, number4, 1, 10);
PrintMatrix(mat);
Console.WriteLine();
PrintMatrix(newMat);
Console.WriteLine();
int[,] res = StreamlineElementsOfRowsMatrix(mat, newMat);
PrintMatrix(res);