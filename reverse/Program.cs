﻿using System;

namespace reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int num = 1234;
                int result = 0;
                int rem;

                while (num != 0)
                {
                    rem = num % 10;
                    result = result * 10 + num;
                    num = num / 10;
                }
                Console.WriteLine(result);
                Console.ReadLine();

            }
        }
    }