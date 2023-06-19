using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._DistinctList
{
    class Program
    {
        static void Main()
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < input.Count; i++)
            {
                for (int a = i + 1; a < input.Count; a++)
                {
                    if (input[i] == input[a])
                    {
                        input.RemoveAt(a);                       
                        a--;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
