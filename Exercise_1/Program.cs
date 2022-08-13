/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1*/
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите трёхзначное число - ");
        int n = Convert.ToInt32(Console.ReadLine());

        int number = n / 10;

        if (number < 100)
        {
            Console.WriteLine("Вторая цифра этого числа : {0}",  number.ToString().ToCharArray()[1]);
        }
    }
}