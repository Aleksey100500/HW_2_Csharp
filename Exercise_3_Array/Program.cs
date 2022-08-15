// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*6 -> да
7 -> да
1 -> нет*/
class Programm
{
    static void Main(string[] args)
    {
        string[] days = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};


        Console.WriteLine("Введите число");
        int i = Convert.ToInt32(Console.ReadLine());

        if (i > 7)
        {
            Console.WriteLine($"Число {i} не подходит для данной задачи");
            Console.ReadKey();
        }
        if (i < 1)
        {
            Console.WriteLine($"Число {i} не подходит для данной задачи");
            Console.ReadKey();
        }
        else
        {
            i--;

            if(i < 5)
                {
                    Console.Write($"Нет это {days[i]}");
                }
            if(i >= 5)
                {
                    Console.Write($"Это {days[i]}");
                }
        }
        
    }
}