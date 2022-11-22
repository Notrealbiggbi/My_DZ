//Задача 53: Задайте двумерный массив. Напишите программу которая поменяет первую и последнюю строку массива.

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

void ReplaceRows(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int temp = matrix[0, i];
        matrix[0, i] = matrix[matrix.GetLength(0) - 1, i];
        matrix[matrix.GetLength(0) - 1, i] = temp;
    }
}

Console.WriteLine("массив заполненный случайными целыми числами");
int[,] mat = CreateMatrixRndInt(3, 5, 0, 10);
PrintMatrix(mat);
Console.WriteLine("массив заполненный случайными целыми числами в котором поменяны первая и последняя строки");
ReplaceRows(mat);
PrintMatrix(mat);
// Console.WriteLine($"Сумма элементов диагонали равна: {res}");

