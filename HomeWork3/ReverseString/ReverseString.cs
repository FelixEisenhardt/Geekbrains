using System;

namespace ReverseString
{
    class ReverseString
    {
        static void Main()
        {
            Console.WriteLine("Введите выражение для его реверсирования: ");
            string userString = Console.ReadLine();
            char[] userStringReverse = userString.ToCharArray();
            Array.Reverse(userStringReverse);
            userString = new string(userStringReverse);
            Console.WriteLine($"Реверсированное выражение: {userString}");
            Console.ReadKey();
        }
    }
}
