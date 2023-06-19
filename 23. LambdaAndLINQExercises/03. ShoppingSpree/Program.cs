using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._ShoppingSpree
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, double> result = new Dictionary<string, double>();
            double budget = double.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(' ').ToArray();

            while (input[0] != "end")
            {
                string product = input[0];
                double price = double.Parse(input[1]);

                if (!result.ContainsKey(product))
                {
                    result[product] = price;
                }
                else
                {
                    if (result[product] > price)
                    {
                        result[product] = price;
                    }
                }



                input = Console.ReadLine().Split(' ').ToArray();
            }

            double sum = result.Values.Sum();

            if (sum > budget)
            {
                Console.WriteLine("Need more money... Just buy banichka");
            }
            else
            {
                foreach (var item in result.OrderByDescending(a => a.Value).ThenBy(a => a.Key.Length))
                {
                    Console.WriteLine($"{item.Key} costs {item.Value:f2}");
                }
            }


        }
    }
}
