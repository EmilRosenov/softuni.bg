﻿using System;

namespace ConditionalStatementsAdvanced_Lab
{
    class FruitOrVegetable
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            switch (name)
            {
                //:  , , , , lemon и grapes , ,  и 

                case "banana":
                case "apple":
                case "kiwi":
                case "cherry":
                case "lemon":
                case "grapes":
                    Console.WriteLine("fruit");
                    break;
                case "tomato":
                case "cucumber":
                case "pepper":
                case "carrot":
                    Console.WriteLine("vegetable");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}