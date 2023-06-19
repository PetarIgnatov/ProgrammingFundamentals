using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._LargestNElements
{
    class Program
    {
        static void Main()
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < input.Count - 1; i++)
            {
                for (int a = i; a >= 0; a--)
                {
                    if (input[a] < input[a + 1])
                    {
                        int swappedElement = input[a + 1];
                        input[a + 1] = input[a];
                        input[a] = swappedElement;
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(input[i] + " ");
            }
        }
    }
}
