﻿using System;

namespace Fizzbuzz
{
    class Fizzbuzz
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 100; i ++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("Fizzbuzz");
                }

                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (i % 7 == 0)
                {
                    Console.WriteLine("Bang");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
