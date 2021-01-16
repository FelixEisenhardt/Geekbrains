using System;

namespace ConsoleAppForHomework1
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите своё имя: ");
            string username = Console.ReadLine();
            Console.WriteLine($"Привет, {username}, сегодня {DateTime.Now}");
        }

    }
}
