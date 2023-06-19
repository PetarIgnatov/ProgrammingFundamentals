using System;

namespace _03._RestaurantDiscount
{
    class Program
    {
        static void Main()
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            string hall = string.Empty;
            int hallPrice = 0;
            double totalPrice = 0.0;

            if (groupSize <= 50)
            {
                hall = "Small hall";
                hallPrice = 2500;
            }
            else if (groupSize <= 100)
            {
                hall = "Teracce";
                hallPrice = 5000;
            }
            else if (groupSize <= 120)
            {
                hall = "Great Hall";
                hallPrice = 7500;
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }

            if (package == "Normal")
            {
                totalPrice = (hallPrice + 500) * 0.95;
            }
            else if (package == "Gold")
            {
                totalPrice = (hallPrice + 750) * 0.90;
            }
            else if (package == "Platinum")
            {
                totalPrice = (hallPrice + 1000) * 0.85;
            }

            double pricePerPerson = totalPrice / groupSize;

            Console.WriteLine($"We can offer you the {hall}");
            Console.WriteLine($"The price per person is {pricePerPerson:F2}$");

        }
    }
}
