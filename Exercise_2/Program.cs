/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5

78 -> третьей цифры нет

32679 -> 6    */

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

int number = n / 10;

if (number < 100)
{
    Console.WriteLine("Третья цифра этого числа : {0}",  number.ToString().ToCharArray()[2]);
}

if (number < 10)
{
    Console.WriteLine("2");
}

if (number < 10000)
{
    Console.WriteLine("Третья цифра этого числа : {0}", number.ToString().ToCharArray()[2]);
}

Console.WriteLine(new string('=', 50));
Console.WriteLine("READY!");