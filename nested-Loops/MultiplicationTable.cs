﻿using System;

namespace MultiplicationTable
{
    class MultiplicationTable
    {
        static void Main(string[] args)
        {
            for (int firstMultiplier = 1; firstMultiplier <= 10; firstMultiplier++)
            {
                for (int secondMultiplier = 1; secondMultiplier <= 10; secondMultiplier++)
                {
                    int product = firstMultiplier * secondMultiplier;
                    Console.WriteLine($"{firstMultiplier} * {secondMultiplier} = {product}");
                }
            }
        }
    }
}
