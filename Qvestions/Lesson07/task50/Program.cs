// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет



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

int FindMatrixElements(int num1, int num2, int[,] matrix)
{
    int dig = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (num1 - 1 == i && num2 - 1 == j) return dig = matrix[i, j];  // Находим эллемент массива, правда для удобства 
                                                                            // я сделал чтобы программа видела индекс, а человек номер столбца и строки
        }
    }
    return dig;
}


int[,] mat = CreateMatrixRndInt(5, 2, -10, 10); // создаём переменную для запроса метода
PrintMatrix(mat); // печатаем метод

Console.Write("Введите позицию элемента в двумерном массиве через запятую :  ");
string[] tokens = Console.ReadLine().Split(',');
int number1 = int.Parse(tokens[0]);
int number2 = int.Parse(tokens[1]);

int res = FindMatrixElements(number1, number2, mat);
if (res > 0 || res < 0)
{
    Console.WriteLine($"{number1},{number2} -> эллемент равен {res}");
}
else Console.WriteLine($"{number1},{number2} -> такого элемента в массиве нет");

