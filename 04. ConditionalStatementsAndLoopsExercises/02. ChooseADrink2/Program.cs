using System;

namespace _02._ChooseADrink2
{
    class Program
    {
        static void Main()
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            switch (profession)
            {
                case "Athlete":
                    Console.WriteLine("Water");
                    Console.WriteLine($"The {profession} has to pay {quantity * 0.70:f2}");
                    break;

                case "Businessman":
                    Console.WriteLine("Coffee");
                    Console.WriteLine($"The {profession} has to pay {quantity * 1.00:f2}"); 
                    break;

                case "Businesswoman":
                    Console.WriteLine("Coffee");
                    Console.WriteLine($"The {profession} has to pay {quantity * 1.00:f2}"); 
                    break;

                case "SoftUni Student":
                    Console.WriteLine("Beer");
                    Console.WriteLine($"The {profession} has to pay {quantity * 1.70:f2}"); 
                    break;

                default:
                    Console.WriteLine("Tea");
                    Console.WriteLine($"The {profession} has to pay {quantity * 1.20:f2}"); break;
            }
        }
    }
}
