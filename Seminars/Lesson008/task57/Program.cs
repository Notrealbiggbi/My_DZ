// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

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
    int count = 0;
    int[] array = new int[matrix.GetLength(0) * matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[count] = matrix[i, j];
            count++;
        }
    }
    return array;
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

void CountElements(int[] array)
{

    int elem = array[0];
    int count = 1;
    for (int i = 1; i < array.Length; i++)
    {
        if (elem == array[i]) count++;
        else
        {
            Console.WriteLine($"элементов {elem}->{count}");
            elem = array[i];
            count = 1;
        }
    }
    Console.WriteLine($"элементов {elem}->{count}");
}

// void CountElements(int[] array)
// {
//     int elem = array[0];
//     int count = 1;
//     for (int i = 1; i < array.Length; i++)
//     {
//         if (elem == array[i]) count ++;
//         else 
//         {
//             Console.WriteLine($"Элементов {elem} => {count}");
//             elem = array[i];
//             count=1;    
//         }
//     }
//     Console.WriteLine($"Элементов {elem} => {count}");
// }



int[,] mat = CreateMatrixRndInt(3, 3, 0, 10);
PrintMatrix(mat);
int[] newArr = NewArray(mat);
Array.Sort(newArr);
PrintArray(newArr);
CountElements(newArr);

