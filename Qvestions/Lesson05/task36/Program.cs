// Задача 36: 
// 1. Задайте одномерный массив, заполненный случайными числами. 
// 2. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] CreateArrayRndInt(int size, int min, int max) // создаём метод где используем расчёт массива с случайными числавми
{
    Random rnd = new Random();
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
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

int[] GetSumNegativeElem(int[] array)
{
    int sumNegative = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1) sumNegative += array[i];
    }
    return new int[] { sumNegative };
}

int[] arr = CreateArrayRndInt(13, 0, 10);
PrintArray(arr);
int[] countRes = GetSumNegativeElem(arr);
Console.WriteLine($"Сумма эллементов, стоящих на нечётных позициях массива  = {countRes[0]}");