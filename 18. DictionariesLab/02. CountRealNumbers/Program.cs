using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._CountRealNumbers
{
    class Program
    {
        static void Main()
        {
            double[] input = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            SortedDictionary<double, int> result = new SortedDictionary<double, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!result.ContainsKey(input[i]))
                {
                    result.Add(input[i], 0);
                }

                result[input[i]]++;
            }

            foreach (double num in result.Keys)
            {
                Console.WriteLine($"{num} -> {result[num]}");
            }
        }
    }
}
