using System;

namespace _04._BeverageLabels
{
    class Program
    {
        static void Main()
        {
            string product = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energy = int.Parse(Console.ReadLine());
            int sugar = int.Parse(Console.ReadLine());

            double energyContent = (volume / 100.0) * energy;
            double sugarcontent = (volume / 100.0) * sugar;

            Console.WriteLine($"{volume}ml {product}:");
            Console.WriteLine($"{energyContent} kcal, {sugarcontent}g sugars");
        }
    }
}
