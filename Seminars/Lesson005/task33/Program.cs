// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да


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

bool FindNUmArray(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num) return true;
    }

    return false;
}


int[] arr = CreateArrayRndInt(12, -9, 9);
PrintArray(arr);
Console.WriteLine("Введите искомое число");
int number = Convert.ToInt32(Console.ReadLine());
// if (FindNUmArray(arr, number)) 
// {
//     Console.WriteLine("Да");
// }
// else 
// {
//     Console.WriteLine("Нет");
// }

Console.WriteLine(FindNUmArray(arr, number)?"Да": "Нет");