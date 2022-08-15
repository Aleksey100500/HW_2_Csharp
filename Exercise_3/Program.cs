// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*6 -> да
7 -> да
1 -> нет*/
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите число: ");
        int d = Convert.ToInt32(Console.ReadLine());

        if (d > 7)
        {
            Console.WriteLine($"Число {d} не подходит для данной задачи");
            Console.ReadKey();
        }
        if (d < 1)
        {
            Console.WriteLine($"Число {d} не подходит для данной задачи");
            Console.ReadKey();
        }
        if (d == 1)
        {
            Console.WriteLine("Нет");
            Console.ReadKey();
        }
        if (d == 2)
        {
            Console.WriteLine("Нет");
            Console.ReadKey();
        }
        if (d == 3)
        {
            Console.WriteLine("Нет");
            Console.ReadKey();
        }
        if (d == 4)
        {
            Console.WriteLine("Нет");
            Console.ReadKey();
        }
        if (d == 5)
        {
            Console.WriteLine("Нет");
            Console.ReadKey();
        }
        if (d == 6)
        {
            Console.WriteLine("Да, это суббота");
            Console.ReadKey();
        }
        if (d == 7)
        {
            Console.WriteLine($"Да, это воскресенье");
            Console.ReadKey();
        }
    }
}