using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._ArrayContainsElement
{
    class Program
    {
        static void Main()
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int n = int.Parse(Console.ReadLine());
            bool isFound = false;

            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] == n)
                {
                    isFound = true;
                    break;
                }
            }

            if (isFound)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }

    }
}
