using System;

namespace FizzBuzzApp
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(FizzBuzz.GetFizzBuzz(i, true));
            }
            Console.WriteLine();
            Console.WriteLine();
            for (int j = 100; j >= 1; j--)
            {
                Console.WriteLine(FizzBuzz.GetFizzBuzz(j, false));
            }

            Console.ReadLine();
        }

        
    }
}
