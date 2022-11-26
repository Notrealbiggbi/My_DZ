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
    int num1 = matrix.GetLength(0);
    int num2 = matrix2.GetLength(1);
    int[,] thirdMatrix = new int[num1, num2];
    for (int i = 0; i < thirdMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < thirdMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                sum += matrix[i, k] * matrix2[k, j];

            }
            thirdMatrix[i, j] = sum;
        }
    }
    return thirdMatrix;
}

Console.WriteLine("Введите размер строк первой матрицы: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер столбцов первой матрицы(и строк 2): ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер столбцов второй матрицы: ");
int number3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
int[,] mat = CreateMatrixRndInt(number1, number2, 1, 4);
int[,] newMat = CreateMatrixRndInt(number2, number3, 1, 4);
PrintMatrix(mat);
Console.WriteLine();
PrintMatrix(newMat);
Console.WriteLine("произведение двух матриц");
int[,] res = StreamlineElementsOfRowsMatrix(mat, newMat);
PrintMatrix(res);