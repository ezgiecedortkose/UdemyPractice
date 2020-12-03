using System;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            if (IsPrimeNumber(7))
            {
                Console.WriteLine("This is a Prime Number");
            }
            else
            {
                Console.WriteLine("This is not a Prime Number");
            }
            Console.ReadLine();
        }

        private static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for (int i = 2; i < number - 1; i++)
            {
                if (number % i == 0)
                {
                    result = false;
                    i = number;
                }
            }
            return result;
        }
    }
    }
}
