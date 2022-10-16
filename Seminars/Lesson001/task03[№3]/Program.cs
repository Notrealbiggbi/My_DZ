// Условие: Написать программу, которая будет выдавать название дня недели по заданному номеру.

Console.Write("Введите номер дня недели: ");
int num = Convert.ToInt32 (Console.ReadLine());


if (num == 1)
{
    Console.WriteLine("Сегодня Понедельник");
}
if (num == 2) //else if
{
    Console.WriteLine("Сегодня Вторник");
}
if (num == 3) //else if

{
    Console.WriteLine("Сегодня Среда");
}
if (num == 4) //else if
{
    Console.WriteLine("Сегодня Четверг");
}
if (num == 5) //else if

{
    Console.WriteLine("Сегодня Пятница");
}
if (num == 6) //else if

{
    Console.WriteLine("Сегодня Суббота");
}
if (num == 7) //else if
{
    Console.WriteLine("Сегодня Воскресенье");
}
if (num > 7) // else: Я увидел только после решения 
{
    Console.WriteLine("Такого дня недели не существует!");
}