using System;

namespace ShowCurrentMonth
{
    class ShowCurrentMonth
    {
        enum Month
        {
            January = 1, //Первый месяц у любого человека идентифицируется с цифрой "1", а не с "0"
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }

        static void Main()
        {
            int numberOfMonth = Input("Введите порядковый номер текущего месяца: ");
            switch (numberOfMonth)
            {
                case 1:
                    Console.WriteLine($"{Month.January}");
                    Console.ReadKey();
                    return;
                case 2:
                    Console.WriteLine($"{Month.February}");
                    Console.ReadKey();
                    return;
                case 3:
                    Console.WriteLine($"{Month.March}");
                    Console.ReadKey();
                    return;
                case 4:
                    Console.WriteLine($"{Month.April}");
                    Console.ReadKey();
                    return;
                case 5:
                    Console.WriteLine($"{Month.May}");
                    Console.ReadKey();
                    return;
                case 6:
                    Console.WriteLine($"{Month.June}");
                    Console.ReadKey();
                    return;
                case 7:
                    Console.WriteLine($"{Month.July}");
                    Console.ReadKey();
                    return;
                case 8:
                    Console.WriteLine($"{Month.August}");
                    Console.ReadKey();
                    return;
                case 9:
                    Console.WriteLine($"{Month.September}");
                    Console.ReadKey();
                    return;
                case 10:
                    Console.WriteLine($"{Month.October}");
                    Console.ReadKey();
                    return;
                case 11:
                    Console.WriteLine($"{Month.November}");
                    Console.ReadKey();
                    return;
                case 12:
                    Console.WriteLine($"{Month.December}");
                    Console.ReadKey();
                    return;
                default:
                    Console.WriteLine("Something is wrong...");
                    return;
            }
        }

        //Метод для проверки пользовательского ввода. Пользователь не должен вводить крокозябру
        //Число месяца не может быть меньше 1 или больше 12.
        static private int Input(string message)
        {
            bool isInt;
            int result;
            do
            {
                Console.WriteLine(message);
                string userInput = Console.ReadLine();
                isInt = int.TryParse(userInput, out result) && result >= 1 && result <= 12;
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
