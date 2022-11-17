// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10


Console.WriteLine("Введите число:  ");
int number = Convert.ToInt32(Console.ReadLine());

int ConvertToBin(int num)
{
    int result = 0;
    while (num > 0)
    {
        result += num % 2;
        result *= 10;
        num /= 2;
    }
    return result;
}

int ReverseNum(int num2)
{
    int result = 0;
    while (num2 > 9 || num2 > 0)
    {
        result += num2 % 10;
        result *= 10;
        num2 /= 10;
    }
    result += num2 % 10;
    return result;
}

int res = ConvertToBin(number);
int result = ReverseNum(res);
Console.Write(result);

//Другое решение
// int d10 = 1;
//             int result = 0;
//             int number = 46;
//             while (number != 0)
//             {
//                 result = result + number % 2 * d10;
//                 number = number / 2;
//                 d10 = d10 * 10;
//             }
//             Console.WriteLine($"{result}");
