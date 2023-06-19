using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fold_and_Sum
{
    class Program
    {
        static void Main()
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int k = input.Length / 4;

            List<int> leftPart = input.Take(k).Reverse().ToList();
            List<int> rightPart = input.Reverse().Take(k).ToList();

            int[] downArr = input.Skip(k).Take(2 * k).ToArray();
            int[] upperArr = leftPart.Concat(rightPart).ToArray();

            for (int i = 0; i < downArr.Length; i++)
            {
                downArr[i] += upperArr[i];
            }

            Console.WriteLine(string.Join(" ", downArr));


        }
    }
}
