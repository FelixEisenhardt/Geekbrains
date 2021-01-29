using System;

namespace ShowMassive
{
    class ShowMassive
    {
        static void Main()
        {
            int[,] massive = new int[5, 5];
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    massive[i, j] = random.Next(0, 10);
                    if (i == j)
                    {
                        Console.Write($"{massive[i, j]}\t");
                    }
                    else
                    {
                        Console.Write("-\t");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
