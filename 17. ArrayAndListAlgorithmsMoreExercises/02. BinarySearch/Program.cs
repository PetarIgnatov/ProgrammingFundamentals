using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._BinarySearch
{
    class Program
    {
        static void Main()
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int n = int.Parse(Console.ReadLine());
            Linear(input, n);
            Binary(input, n);
        }

        static void Binary(List<int> input, int n)
        {
            input.Sort();
            int counter = 0;
            int lowerBound = 0;
            int upperBound = input.Count - 1;
            
            while (lowerBound <= upperBound)
            {
                int mid = lowerBound + (upperBound - lowerBound) / 2;
                counter++;

                if (input[mid] == n)
                {

                    Console.WriteLine($"Binary search made {counter} iterations");
                    return;
                }
                else if (input[mid] < n)
                {
                    lowerBound = mid + 1;
                }
                else if (input[mid] > n)
                {
                    upperBound = mid - 1;
                }

            }

            Console.WriteLine($"Binary search made {counter} iterations");
        }

        static void Linear(List<int> input, int n)
        {

            for (int i = 0; i < input.Count; i++)
            {
                if (n == input[i])
                {
                    Console.WriteLine("Yes");
                    Console.WriteLine($"Linear search made {i + 1} iterations");
                    return;
                }
            }

            Console.WriteLine("No");
            Console.WriteLine($"Linear search made {input.Count} iterations");
        }
    }
}
