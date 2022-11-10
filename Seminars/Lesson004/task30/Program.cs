// Задача 30: Напишите программу, которая
// 1. выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.


// [1,0,1,1,0,1,0,0]

// int[] array = new int [8]; // 000000000
// for (int i = 0; i < array.Length; i++)
// {
//     int num = new Random().Next(0,2);
//     Console.Write("[",num,",","]");
// }



Console.Write("Введите количество элементов массива : ");
int num = Convert.ToInt32(Console.ReadLine());

int[] NameArray(int size)
{
    Random rnd =new Random();
    int[] array = new int[size]; // 
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 2);
    }
    return array;
}

void PrintArray(int[] array)
{   
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i<array.Length-1) Console.Write(",");
    }
    Console.Write("]");
}

int[] namearray = NameArray(num);
PrintArray(namearray);
