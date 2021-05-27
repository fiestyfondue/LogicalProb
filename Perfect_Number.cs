using System;

namespace Perfect_Number
{
    class Program
    {
        public static int Find_Factor(int input)
        {
            int sum = 0;
            for (int i = 1; i < input; i++)
            {
                if (input % i == 0)
                {
                    sum = sum + i;
                }

            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter input value");
            int input = int.Parse(Console.ReadLine());
            int result = Find_Factor(input);
            if (input == result)
            {
                Console.WriteLine("Input is a Perfect number ");

            }
            else
            {
                Console.WriteLine("Input is not a perfect number ");

            }
            Console.ReadLine();



        }

    }


}