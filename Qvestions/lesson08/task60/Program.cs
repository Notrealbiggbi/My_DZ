// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

int[,,] CreateMatrixRndInt(int rows, int columns, int depth, int min, int max)
{
    int[,,] matrix = new int[rows, columns, depth];
    Random rnd = new Random();
    int[] arrayRandom = new int[matrix.GetLength(0) * matrix.GetLength(1) * matrix.GetLength(2)];
    int number;
    for (int i = 0; i < arrayRandom.GetLength(0); i++)
    {
        arrayRandom[i] = rnd.Next(min, max);
        number = arrayRandom[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (arrayRandom[i] == arrayRandom[j])
                {
                    arrayRandom[i] = rnd.Next(min, max);
                    j = 0;
                    number = arrayRandom[i];
                }
                number = arrayRandom[i];
            }
        }
    }
    int count = 0;
    for (int x = 0; x < matrix.GetLength(0); x++) // высота
    {
        for (int y = 0; y < matrix.GetLength(1); y++) // ширина
        {
            for (int z = 0; z < matrix.GetLength(2); z++) //глубина
            {
                matrix[x, y, z] = arrayRandom[count];
                count++;
            }

        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)// создаём метод с выводом прошлого метода
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if (k < matrix.GetLength(2) - 1) Console.Write($"|{matrix[i, j, k],5}({i},{j},{k})  |");
                else Console.Write($"{matrix[i, j, k],5}({i},{j},{k}) ");
            }

        }
        Console.WriteLine("  |");
    }

}

int[,,] mat = CreateMatrixRndInt(2, 2, 2, 10, 100);
PrintMatrix(mat);