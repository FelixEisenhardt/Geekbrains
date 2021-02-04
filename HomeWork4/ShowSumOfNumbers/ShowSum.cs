using System;

namespace ShowSumOfNumbers
{
    class ShowSum
    {
        static void Main()
        {
            
            GetSumOfNumbersFromString(null);
            Console.ReadKey();
        }

        static int GetSumOfNumbersFromString(string stringNumbers)
        {
            Console.WriteLine("Введите числа ЧЕРЕЗ ПРОБЕЛ: ");
            stringNumbers = Console.ReadLine();
            int[] intNumbers = Array.ConvertAll(stringNumbers.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries), x => Int32.Parse(x));
            int summary = 0;
            for (int i = 0; i < intNumbers.Length; i++)
            {
                summary += intNumbers[i];
            }
            Console.WriteLine($"Сумма чисел: {summary}");
            return summary;
        }
    }
}
