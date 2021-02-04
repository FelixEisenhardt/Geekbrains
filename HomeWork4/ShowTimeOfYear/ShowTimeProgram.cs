using System;

namespace ShowTimeOfYear
{
    class ShowTimeProgram
    {
        enum TimeOfYear
        {
            Winter,
            Spring,
            Summer,
            Autumn
        }
        static void Main()
        {
            int getNumberOfMonth = Input("Введите число месяца: ");
            GetTimeOfYear(ref getNumberOfMonth, out string resultTimeOfYear);
            ShowTimeOfYear(resultTimeOfYear);
            Console.ReadKey();
        }

        private static void GetTimeOfYear(ref int numberOfMonth, out string result)
        {
            result = " ";
            switch (numberOfMonth)
            {
                case 1:
                case 2:
                    result = TimeOfYear.Winter.ToString();
                    break;
                case 3:
                case 4:
                case 5:
                    result = TimeOfYear.Spring.ToString();
                    break;
                case 6:
                case 7:
                case 8:
                    result = TimeOfYear.Summer.ToString();
                    break;
                case 9:
                case 10:
                case 11:
                    result = TimeOfYear.Autumn.ToString();
                    break;
                case 12:
                    result = TimeOfYear.Winter.ToString();
                    break;
                default:
                    Console.WriteLine("Something is wrong...");
                    break;
            }
        }

        static string ShowTimeOfYear(string getTimeOfYear)
        {
            Console.WriteLine($"{getTimeOfYear}");
            return getTimeOfYear;
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
                if (!isInt || (result < 1 || result > 12))
                {
                    Console.WriteLine("Ошибка: введите число от 1 до 12");
                }
            }
            while (!isInt || (result < 1 || result > 12));
            return result;
        }
    }
}
