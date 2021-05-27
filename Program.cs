using System;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int fibonacciLength;
            int f1 = 0, f2 = 1, f3;

            Console.WriteLine("Enter how many fibonacci numbers you want : ");
            fibonacciLength = int.Parse(Console.ReadLine());
            Console.Write(f1 + " " + f2 + " ");

            for (int i = 2; i < fibonacciLength; ++i)
            {
                f3 = f1 + f2;
                Console.Write(f3 + " ");
                f1 = f2;
                f2 = f3;

            }
            Console.WriteLine(" ");
        }
    }
}
