using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._TearListInHalf
{
    class Program
    {
        static void Main()
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> left = input.Take(input.Count / 2).ToList();
            List<int> right = input.Skip(input.Count / 2).ToList();

            int index = 0;

            for (int i = 0; i < input.Count / 2; i++)
            {
                int firstDigit = right[i] / 10;
                int lastDigit = right[i] % 10;

                left.Insert(index, firstDigit);
                left.Insert(index + 2, lastDigit);

                index += 3;
            }

            Console.WriteLine(string.Join(" ", left));
        }
    }
}
