// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 2 3
// 4 2 4
// 2 6 7


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


int[] NewArray(int[,] matrix)
{
    int min = matrix[0, 0];
    int[] minIndex = new int[2];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
                minIndex[0] = i;
                minIndex[1] = j;
            }

        }
    }
    return minIndex;
}

void PrintArray(int[] array) // создаём метод с выводом прошлого метода
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1) Console.Write(",");
    }
    Console.WriteLine("]");
}

int[,] NewMatrix(int[] NewArray, int[,] matrix)
{
    int count =0;
    int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (i != NewArray[0])
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (j != NewArray[1])
                {
                    newMatrix[i, j] = matrix[i, j];
                }
                count++;

            }
        }
    }
    return newMatrix;
}




int[,] mat = CreateMatrixRndInt(3, 3, 0, 10);
PrintMatrix(mat);
Console.WriteLine();
int[] newArr = NewArray(mat);
PrintArray(newArr);
int[] newMat = NewMatrix(newArr,mat);
PrintMatrix(newMat);



// int[] MinElemArray(int[,] matrix)
// {
//     int horizont = 0;
//     int vertical = 0;
//     int min = matrix[horizont,vertical];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//            if (min > matrix[i,j] ) 
//            {
//                 min = matrix[i,j];
//                 horizont = i;
//                 vertical = j;
//            }
//         }   
//     }
//     return new int[] {horizont, vertical};
// }
// int[,] CreateMatrixMax(int[,] matrix, int m, int n)
// {
//     int[,] matrixMax = new int[matrix.GetLength(0)-1, matrix.GetLength(1)-1];
//     int countHor=0;
//     int countVer=0;
//     for (int i = 0; i < matrixMax.GetLength(0); i++)
//     {
//         if (countHor==m) countHor ++;
//         for (int j = 0; j < matrixMax.GetLength(1); j++)
//         {
//             if (countVer==n) countVer ++;
//             {
//                 matrixMax[i, j] = matrix[countHor, countVer]; 
//             }
//             countVer ++;               
//         }
//         countVer = 0; 
//         countHor ++;
//     } 
//     return matrixMax;
// }
// int[,] newMatrixRndInt = CreateMatrixRndInt(m, n, 1, 10);
// Console.WriteLine("массив заполненный случайными целыми числами");
// PrintMatrix(newMatrixRndInt);
// Console.WriteLine();
// int[] newMinElemArray = MinElemArray(newMatrixRndInt);
// Console.WriteLine("одномерный массив , позиции ");
// PrintArray(newMinElemArray);
// Console.WriteLine();
// int[,] newMatrixMax = CreateMatrixMax(newMatrixRndInt, newMinElemArray[0], newMinElemArray[1]);
// Console.WriteLine("массив в которой удален строки и столбцы, на пересечении которых расположен наименьший элемент массива.");
// PrintMatrix(newMatrixMax);


// int[,,] CreateMatrixRndInt(int rows, int columns, int depth, int min, int max)
// {
//     int[,,] matrix = new int[rows, columns, depth];
//     Random rnd = new Random();

//     for (int i = 0; i < matrix.GetLength(0); i++) // 2
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++) // 
//         {
//             for (int k = 0; k < matrix.GetLength(2); k++)
//             {
//                 matrix[i, j, k] = rnd.Next(min, max + 1); // 2 - 3
//             }
            
//         }
//     }
//     return matrix;
// }
