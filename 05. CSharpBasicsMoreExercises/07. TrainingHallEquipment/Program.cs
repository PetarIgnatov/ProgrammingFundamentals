using System;

namespace _07._TrainingHallEquipment
{
    class Program
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            int numberOfItems = int.Parse(Console.ReadLine());

            double subTotal = 0.0;

            for (int i = 0; i < numberOfItems; i++)
            {            
                string item = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());
                int count = int.Parse(Console.ReadLine());

                if (count > 1)
                {
                    item += "s";
                }

                subTotal += price * count;
                Console.WriteLine($"Adding {count} {item} to cart.");

            }

            Console.WriteLine($"Subtotal: ${subTotal:f2}");

            if (budget >= subTotal)
            {
                double moneyLeft = budget - subTotal;
                Console.WriteLine($"Money left: ${moneyLeft:f2}");
            }
            else
            {
                double moneyNeeded = subTotal - budget;
                Console.WriteLine($"Not enough. We need ${moneyNeeded:f2} more.");
            }

        }
    }
}
