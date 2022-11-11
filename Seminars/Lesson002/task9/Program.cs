//Условие: Напишите программу, которая 
//1. выводит случайное число из отрезка [10,99] и 
//2. показывает наибольшую цифру числа.

int num = new Random().Next(10,100);//10,11,12,13...99
Console.WriteLine($"Сгенерировано число {num}");

//      ИЗ МЕТОДА МОЖНО ВЫВОДИТЬ ГДЕ УГОДНО 
// int result1 = MaxDigit(45);
// Console.WriteLine($"Наибольшая цифра {45}  равна {result1}");
// int result2 = MaxDigit(76);
// Console.WriteLine($"Наибольшая цифра {76}  равна {result2}");
// int result3 = MaxDigit(81);
// Console.WriteLine($"Наибольшая цифра {81}  равна {result3}");
// int result4 = MaxDigit(42);
// Console.WriteLine($"Наибольшая цифра {42}  равна {result4}");
// int result5 = MaxDigit(27);
// Console.WriteLine($"Наибольшая цифра {27}  равна {result5}");
// int result6 = MaxDigit(62);
// Console.WriteLine($"Наибольшая цифра {62}  равна {result6}");
// int result7 = MaxDigit(85);
// Console.WriteLine($"Наибольшая цифра {85}  равна {result7}");

// int FirstDigit = num / 10;
// int SecondDigit = num % 10;

// if(FirstDigit > SecondDigit)
// {
//     Console.WriteLine($"В числе {num} наибольшая цифра {FirstDigit}");
// }
// else if(FirstDigit < SecondDigit)
// {
//     Console.WriteLine($"В числе {num} наибольшая цифра {SecondDigit}");
// }
// else if(FirstDigit == SecondDigit) 
// {
// Console.WriteLine($"В числе {num} цифры равны ");
// }

//          УСЛОВНЫЙ ОПЕРАТОР
// int result = default;
// if(FirstDigit > SecondDigit) result = FirstDigit;
// else result = SecondDigit;
// Console.WriteLine($"Наибольшая цифра {result}");

//          ТЕРНАРНЫЙ ОПЕРАТОР 1
// int maxDigit = FirstDigit > SecondDigit ? FirstDigit : SecondDigit;
// Console.WriteLine($"В числе {num} наибольшая цифра {maxDigit}");

//          ТЕРНАРНЫЙ ОПЕРАТОР 2
// Console.Write($"Наибольшая цифра {num} равна ");
// Console.WriteLine(FirstDigit > SecondDigit ? FirstDigit : SecondDigit);

//      МЕТОД
int MaxDigit (int num)
{
    int FirstDigit = num / 10;
    int SecondDigit = num % 10;
    return FirstDigit > SecondDigit ? FirstDigit : SecondDigit;
}

int result = MaxDigit(num);
Console.WriteLine($"Наибольшая цифра {num}  равна {result}");