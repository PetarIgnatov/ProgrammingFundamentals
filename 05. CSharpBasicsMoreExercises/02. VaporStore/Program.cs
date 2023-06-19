using System;

namespace _02._VaporStore
{
    class Program
    {
        static void Main()
        {
            double cash = double.Parse(Console.ReadLine());
            string game = Console.ReadLine();
            double price = 0.0;
            double budget = cash;

            while (game != "Game Time")
            {
                switch (game)
                {
                    case "OutFall 4":
                        price = 39.99;
                        break;
                    case "CS: OG":
                        price = 15.99;
                        break;
                    case "Zplinter Zell":
                        price = 19.99;
                        break;
                    case "Honored 2":
                        price = 59.99;
                        break;
                    case "RoverWatch":
                        price = 29.99;                       
                        break;
                    case "RoverWatch Origins Edition":
                        price = 39.99;                        
                        break;

                    default:
                        Console.WriteLine("Not Found");                      
                        game = Console.ReadLine();
                        continue;
                       
                }

                if (cash < price)
                {
                    Console.WriteLine("Too Expensive");
                }
                else 
                {
                    Console.WriteLine($"Bought {game}");
                    cash -= price;
                }
                if (cash <= 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
                
                game = Console.ReadLine();
            }

            double remainingMoney = budget - cash;
            Console.WriteLine($"Total spent: ${remainingMoney:f2}. Remaining: ${cash:f2}");

        }
    }
}
