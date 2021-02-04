using System;

namespace FibonacciProject
{
    class Fibonacci
    {
        static void Main()
        {
            int userInput = Input("Введите порядковый номер числа Фибоначчи: ");
            Console.WriteLine($"{userInput}-е число Фибоначчи: {FiboCalc(userInput)}"); // Нулевой член ряда чисел Фибоначчи - 0, первый - 1, второй - 1
            Console.ReadKey();
        }

        static int FiboCalc(int n)
        {
            if ( n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                return FiboCalc(n - 1) + FiboCalc(n - 2);
            }
        }

        //Метод для проверки пользовательского ввода
        static private int Input(string message)
        {
            bool isInt;
            int result;
            do
            {
                Console.WriteLine(message);
                string userInput = Console.ReadLine();
                isInt = int.TryParse(userInput, out result);
                if (!isInt || result < 0)
                {
                    Console.WriteLine("Некорректный ввод, порядковый номер должен быть от 0 и больше. Введите ещё раз.");
                }
            }
            while (!isInt || result < 0);
            return result;
        }
    }
}
