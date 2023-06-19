using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._CottageScraper
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            List<KeyValuePair<string, int>> data = new List<KeyValuePair<string, int>>();

            while (input != "chop chop")
            {
                string[] tokens = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                string tree = tokens[0];
                int height = int.Parse(tokens[1]);

                data.Add(new KeyValuePair<string, int>(tree, height));

                input = Console.ReadLine();
            }

            string wantedType = Console.ReadLine();
            int minHeight = int.Parse(Console.ReadLine());

            var pricePerMeter = Math.Round(data.Average(a => a.Value), 2);

            double usedLogs = data.Where(a => a.Key == wantedType && a.Value >= minHeight).Sum(a => a.Value);
            double unusedLogs = data.Where(a => a.Key != wantedType || a.Value < minHeight).Sum(a => a.Value);

            usedLogs = Math.Round(usedLogs * pricePerMeter, 2);
            unusedLogs = Math.Round(unusedLogs * pricePerMeter * 0.25, 2);

            double total = Math.Round(usedLogs + unusedLogs, 2);

            Console.WriteLine($"Price per meter: ${pricePerMeter:f2}");
            Console.WriteLine($"Used logs price: ${usedLogs:f2}");
            Console.WriteLine($"Unused logs price: ${unusedLogs:f2}");
            Console.WriteLine($"CottageScraper subtotal: ${total:f2}");


        }
    }
}
