/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5

78 -> третьей цифры нет

32679 -> 6    */
class Program
{
    static void Main(string[] args)
    {
    Console.WriteLine("Введите число:");
    int n = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(n>99 ? n.ToString()[2] : '-');
    Console.ReadKey(true);
    }
}