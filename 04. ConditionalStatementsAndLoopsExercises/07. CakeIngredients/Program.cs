﻿using System;

namespace _07._CakeIngredients
{
    class Program
    {
        static void Main()
        {
            string ingredient = Console.ReadLine();
            int counter = 0;

            while (ingredient != "Bake!")
            {
                counter++;
                Console.WriteLine($"Adding ingredient {ingredient}.");
                ingredient = Console.ReadLine();

            }

            Console.WriteLine($"Preparing cake with {counter} ingredients.");

        }
    }
}
