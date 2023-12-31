﻿using System;

namespace _09._TriangleFormations
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            double sideA = Math.Pow(a,2);
            double sideB = Math.Pow(b,2);
            double sideC = Math.Pow(c,2);

            if (a + b > c && a + c > b && b + c > a)
            {
                Console.WriteLine("Triangle is valid.");
            }
            else
            {
                Console.WriteLine("Invalid Triangle.");
                return;
            }

            if (sideA + sideB == sideC)
            {
                Console.WriteLine("Triangle has a right angle between sides a and b");
            }
            else if (sideB + sideC == sideA )
            {
                Console.WriteLine("Triangle has a right angle between sides b and c");
            }
            else if (sideA + sideC == sideB)
            {
                Console.WriteLine("Triangle has a right angle between sides a and c");
            }
            else
            {
                Console.WriteLine("Triangle has no right angles");
            }


        }
    }
}
