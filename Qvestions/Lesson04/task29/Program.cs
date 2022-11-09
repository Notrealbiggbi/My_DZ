// Напишите программу, 
// 1. которая задаёт массив из 8 элементов и 
// 2. выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int num = 8;

int[] RandommArray(int size)
{
    int[] array = new int[size]; 
    Random rnd = new Random();
    for (int num1 = 0; num1 < array.Length; num1++)
    {
        array[num1]  = rnd.Next(0, 100);
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

int[] res = RandommArray(num);
PrintArray(res);

