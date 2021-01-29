using System;

namespace ShowTemperature
{
    class ShowTemperature
    {
        static void Main()
        {
            //Значение температуры может быть не только целым, поэтому используем float
            float minValueOfTemperature;
            float maxValueOfTemperature;
            float averageValueOfTemperature;  

            minValueOfTemperature = Input("Введите минимальную температуру за последние сутки: ");
            maxValueOfTemperature = Input("\nВведите максимальную температуру за последние сутки: ");
            averageValueOfTemperature = (minValueOfTemperature + maxValueOfTemperature) / 2;
            Console.WriteLine($"\nСреднесуточная температура: {averageValueOfTemperature}");
            Console.ReadKey();
        }

        //Метод для проверки пользовательского ввода
        static private float Input(string message)
        {
            bool isFloat;
            float result;
            do
            {
                Console.WriteLine(message);
                string userInput = Console.ReadLine();
                isFloat = float.TryParse(userInput, out result);
                if (!isFloat)
                {
                    Console.Write("Неккоректный ввод. Повторите ещё раз");
                }
            }
            while (!isFloat);
            return result;
        }
    }
}
