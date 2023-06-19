using System;

namespace _08._CaloriesCounter
{
    class Program
    {
        static void Main()
        {
            int numberOfIngredients = int.Parse(Console.ReadLine());
            int cheese = 500;
            int tomatoSauce = 150;
            int salami = 600;
            int pepper = 50;
            int totalCalories = 0;

            for (int i = 0; i < numberOfIngredients; i++)
            {
                string ingredients = Console.ReadLine().ToLower();

                if (ingredients == "cheese")
                {
                    totalCalories += cheese;
                }
                else if (ingredients == "tomato sauce")
                {
                    totalCalories += tomatoSauce;
                }
                else if (ingredients == "salami")
                {
                    totalCalories += salami;
                }
                else if (ingredients == "pepper")
                {
                    totalCalories += pepper;
                }
            }

            Console.WriteLine($"Total calories: {totalCalories}");
        }
    }
}
