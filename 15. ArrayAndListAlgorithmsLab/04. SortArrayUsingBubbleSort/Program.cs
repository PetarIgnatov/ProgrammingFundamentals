using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._SortArrayUsingBubbleSort
{
    class Program
    {
        static void Main()
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            bool swapped = false;

            do
            {
                swapped = false;

                for (int i = 1; i < input.Count; i++)
                {
                    int leftElement = input[i - 1];
                    int rightElement = input[i];

                    if (leftElement > rightElement)
                    {
                        int swappedElement = leftElement;
                        input[i - 1] = rightElement;
                        input[i] = swappedElement;
                        swapped = true;
                    }
                }

            } while (swapped);

            Console.WriteLine(string.Join(" ", input));

        }

        
    }
}
