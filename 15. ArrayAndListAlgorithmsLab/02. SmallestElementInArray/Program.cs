using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._SmallestElementInArray
{
    class Program
    {
        static void Main()
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int smallest = int.MaxValue;

            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] < smallest)
                {
                    smallest = input[i];
                }
            }

            Console.WriteLine(smallest);
        }
    }
}
