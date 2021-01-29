using System;

namespace ShowCheck
{
    class ShowCheck
    {
        static void Main()
        {
            string nameOfLegalEntity = "ООО Союз Св. Иоанна Воина";
            string city = "г. Москва";
            string street = "Пятницкое ш.";
            int buildNumber = 43;
            int postCode = 125310;
            int checkNumber = 423;
            string checkName = "КАССОВЫЙ ЧЕК (ПРИХОД)";
            string productName1 = "Хлеб Белый";
            string productName2 = "Молоко обезжиренное";
            float priceForProductName1 = 23;
            float priceForProductName2 = 23;
            int quantity = 2;
            float totalCostForProductionName1 = quantity * priceForProductName1;
            float totalCostForProductionName2 = quantity * priceForProductName2;
            float totalCostForAll = (quantity * priceForProductName1) + (quantity * priceForProductName2);
            long articleForProductName1 = 0123456;
            long articleForProductName2 = 0987654;
            

            Console.SetWindowSize(60, 40);
            Console.SetBufferSize(80, 80);
            Console.SetCursorPosition(20, 0);
            Console.WriteLine($"{nameOfLegalEntity}");
            Console.SetCursorPosition(20, 1);
            Console.WriteLine($"{city}, {street}, {buildNumber}");
            Console.SetCursorPosition(30, 2);
            Console.WriteLine($"{postCode}");
            Console.SetCursorPosition(20, 3);
            Console.WriteLine($"{checkName} № {checkNumber}");
            Console.SetCursorPosition(15, 4);
            Console.WriteLine("--------------------------------------");
            Console.SetCursorPosition(17, 5);
            Console.WriteLine($"{articleForProductName1} {productName1}");
            Console.SetCursorPosition(40, 6);
            Console.WriteLine($"{quantity} x {priceForProductName1} = {totalCostForProductionName1}");
            Console.SetCursorPosition(17, 7);
            Console.WriteLine($"{articleForProductName2} {productName2}");
            Console.SetCursorPosition(40, 8);
            Console.WriteLine($"{quantity} x {priceForProductName2} = {totalCostForProductionName2}");
            Console.SetCursorPosition(15, 9);
            Console.WriteLine("--------------------------------------");
            Console.SetCursorPosition(40, 10);
            Console.WriteLine($"Итого:   {totalCostForAll}");
            Console.SetCursorPosition(15, 15);
            Console.WriteLine("Спасибо за покупку! :) Ждём Вас снова!");
            Console.ReadKey();
        }
    }
}
