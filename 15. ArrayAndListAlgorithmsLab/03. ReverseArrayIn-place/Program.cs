using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._ReverseArrayIn_place
{
    class Program
    {
        static void Main()
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < input.Count / 2; i++)
            {
                int lastElement = input[i];
                input[i] = input[input.Count - 1 - i];
                input[input.Count - 1 - i] = lastElement;

            }

            Console.WriteLine(String.Join(" ", input));
        }
    }
}
