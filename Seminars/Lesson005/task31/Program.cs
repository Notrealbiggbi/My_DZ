// Задача 31: 
// 1. Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. 
// 2. Найдите сумму отрицательных и положительных элементов массива.

//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.


// Console.Write("Введите диапазон массива:  ");
// int num = Convert.ToInt32(Console.ReadLine());

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

void PrintArray(int[] array) // создаём массив с выводом прошлого метода
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1) Console.Write(",");
    }
    Console.WriteLine("]");
}

int[] GetSumPositiveNegativeElem (int[] array)
{
    int sumPositive = 0;
    int sumNegative = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>0) sumPositive += array[i];
        else sumNegative += array[i];
    }
    // int[] res = {sumPositive,sumNegative};
    // return res;                                           Можно создать переменную.
    return new int[]{sumPositive,sumNegative};
}


int[] arr = CreateArrayRndInt(12, -9, 9); // создаём переменную для запроса метода
PrintArray(arr); // печатаем метод
int[] ResultGetSumPositiveNegativeElem = GetSumPositiveNegativeElem(arr);
Console.WriteLine($"Сумма положительных эллементов равна {ResultGetSumPositiveNegativeElem[0]}"); // сначала выводим сумму положительных элементов
Console.WriteLine($"Сумма отрицательных эллементов равна {ResultGetSumPositiveNegativeElem[1]}"); // дальше выводим сумму отрицательных элементов