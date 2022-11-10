// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].


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




int CountElements (int[]array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] <= 99) count++;
    }
    return count;
}

int[] arr = CreateArrayRndInt(123, 0, 200);
PrintArray(arr);
int countRes = CountElements(arr);
Console.WriteLine($"Колличество эллементов массива, из отрезка [10,99] = {countRes}");