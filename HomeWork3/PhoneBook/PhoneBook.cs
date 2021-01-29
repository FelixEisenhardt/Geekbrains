using System;

namespace PhoneBook
{
    class PhoneBook
    {
        static void Main()
        {
            Console.WriteLine("Желаете просмотреть телефонную книгу с готовыми данными или заполнить её самостоятельно? (y/n):");
            Console.WriteLine("'y' - просмотреть готовый вариант; 'n' - заполнить её вручную и вывести на консоль");
            string userChoice = Console.ReadLine();

            string[,] contacts = new string[5, 2];

            switch (userChoice)
            {
                case "y":
                    contacts[0, 0] = "Петров Пётр Петрович";
                    contacts[0, 1] = "+7(926)999-99-99";
                    contacts[1, 0] = "Баранова Людмила Николаевна";
                    contacts[1, 1] = "sometest@email.com";
                    contacts[2, 0] = "Алексеев Алексей Алексеевич";
                    contacts[2, 1] = "+8(865)1234-345-35";
                    contacts[3, 0] = "Bill Gates";
                    contacts[3, 1] = "bill.gates@microsoft.com";
                    contacts[4, 0] = "Аноним";
                    contacts[4, 1] = "+8(800)555-35-35";
                    Console.WriteLine("------------------------\nТелефонная книга:\n");

                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 2; j++)
                        {
                            Console.Write($"{contacts[i, j]}\t");
                        }
                        Console.WriteLine();
                    }
                    Console.ReadKey();
                    break;

                case "n":
                    contacts[0, 0] = Input("Введите имя для первого контакта: ");
                    contacts[0, 1] = Input("Напишите номер/e-mail для введённого Вами контакта: ");

                    contacts[1, 0] = Input("Введите имя для второго контакта: ");
                    contacts[1, 1] = Input("Напишите номер/e-mail для введённого Вами контакта: ");

                    contacts[2, 0] = Input("Введите имя для третьего контакта: ");
                    contacts[2, 1] = Input("Напишите номер/e-mail для введённого Вами контакта: ");

                    contacts[3, 0] = Input("Введите имя четвёртого контакта: ");
                    contacts[3, 1] = Input("Напишите номер/e-mail для введённого Вами контакта: ");

                    contacts[4, 0] = Input("Введите имя пятого контакта: ");
                    contacts[4, 1] = Input("Напишите номер/e-mail для введённого Вами контакта: ");
                    Console.WriteLine("------------------------\nТелефонная книга:\n");

                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 2; j++)
                        {
                            Console.Write($"{contacts[i, j]}\t");
                        }
                        Console.WriteLine();
                    }

                    Console.ReadKey();
                    break;

                default:
                    Console.WriteLine("Некорректный ввод. ");
                    break;
            }
        }

        //Метод для ввода с консоли строковых значений, дабы сократить количество лишних строк кода
        static private string Input(string message)
        {
            Console.WriteLine(message);
            string userInput = Console.ReadLine();
            return userInput; 
        }
    }
}
