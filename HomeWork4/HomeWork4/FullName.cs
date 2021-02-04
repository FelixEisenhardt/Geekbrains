using System;

namespace FullNameProject
{
    class FullName
    {
        static void Main()
        {
            Console.WriteLine(GetFullName("Иосиф", "Джугашвилли", "Виссарионович"));
            Console.WriteLine(GetFullName("Аноним","Анонимов","Даркнетович"));
            Console.WriteLine(GetFullName("John","Washington","David"));
            Console.WriteLine(GetFullName("Павел", "Дуров", "Валерьевич"));
            Console.ReadKey();
        }

        static string GetFullName(string firstName, string lastName, string patronymic)
        {
            string fullName = $"{firstName} {lastName} {patronymic}";
            return fullName;
        }
    }

}
