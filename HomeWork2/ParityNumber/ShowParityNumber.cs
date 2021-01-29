using System;

namespace ShowParityNumber
{
    class ShowParityNumber
    {
        static void Main()
        {
            int userNumber = Input("Введите целое число для проверки на чётность: ");
            if (userNumber % 2 == 0)
            {
                Console.Write($"Введённое число ({userNumber}) является чётным.");
                Console.ReadKey();
            }
            else
            {
                Console.Write($"Введённое число ({userNumber}) не является чётным.");
                Console.ReadKey();
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
                if (!isInt)
                {
                    Console.WriteLine("Неккоректный ввод. Повторите ещё раз");
                }
            }
            while (!isInt);
            return result;
        }
    }
}
