using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._ArrayData
{
    class Program
    {
        static void Main()
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string command = Console.ReadLine();
            double average = input.Average();
            input.RemoveAll(a => a < average);

            if (command == "Min")
            {
                Console.WriteLine(input.Min());
            }
            else if (command == "Max")
            {
                Console.WriteLine(input.Max());
            }
            else
            {
                Console.WriteLine(string.Join(" ", input.OrderBy(a => a)));
            }
        }
    }
}
