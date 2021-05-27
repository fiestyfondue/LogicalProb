using System;
using System.Collections.Generic;
using System.Text;

namespace fibonacci
{
    class PrimeNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int number;
            number = Convert.ToInt32(Console.ReadLine());
            int divisor = 0;

            for (int i = 0; i <= number; i++)
            {
                if (number % i == 0)
                {
                    divisor++;
                }

            }
            if (divisor == 2)
            {
                Console.WriteLine("Entered number is a prime number");

            }
            else
            {
                Console.WriteLine{ "Entered number is not a prime number"};
            }
            Console.ReadLine();
        }
    }
}
