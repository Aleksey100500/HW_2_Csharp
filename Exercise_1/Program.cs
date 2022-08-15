/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1*/
class Program
{
    static void Main(string[] args)
    {
    Console.WriteLine("Введите число:");
    int n = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(n>99 ? n.ToString()[1] : '-');
    Console.ReadKey(true);
    }
}