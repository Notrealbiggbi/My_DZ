// Задача 32: 
// 1. Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.


// [-4, -8, 8, 2] -> [4, 8, -8, -2]



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


int[] InversionArray(int[] array)
{
    
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * -1;
    }
    return array;
}

int[] arr = CreateArrayRndInt(4, -10, 10); // создаём переменную для запроса метода
PrintArray(arr); // печатаем метод
int[] reasultInversionArray = InversionArray(arr);
PrintArray(reasultInversionArray);