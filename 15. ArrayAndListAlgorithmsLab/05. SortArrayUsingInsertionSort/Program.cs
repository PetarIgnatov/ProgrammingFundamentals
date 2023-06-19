using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._SortArrayUsingInsertionSort
{
    class Program
    {
        static void Main()
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < input.Count - 1; i++)
            {
                for (int a = i; a >= 0; a--)
                {
                    if (input[a] > input[a + 1])
                    {
                        int swappedElement = input[a + 1];
                        input[a + 1] = input[a];
                        input[a] = swappedElement;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
