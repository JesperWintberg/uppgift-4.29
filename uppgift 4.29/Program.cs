using System;

namespace ____
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur hög vill du ha din rätvinkliga triangel");
            string höjd = Console.ReadLine();

            int höjd2 = int.Parse(höjd);

            for (int i = 0; i < höjd2; i++)
            {
                Console.WriteLine();

                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
            }
            Console.WriteLine();
        }
    }
}

