// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите размер массива:  ");
int size = Convert.ToInt32(Console.ReadLine());

int[] CreateArrayInt(int sizearr)
{
    int[] array = new int[sizearr];
    Console.WriteLine("Введите числа через Enter ");
    for (int i = 0; i < sizearr; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1) Console.Write(",");
    }
    Console.WriteLine("]");
}

int CountElements(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

int[] res = CreateArrayInt(size);
PrintArray(res);
int result = CountElements(res);
Console.WriteLine($"Чисел больше нуля = {result}.");