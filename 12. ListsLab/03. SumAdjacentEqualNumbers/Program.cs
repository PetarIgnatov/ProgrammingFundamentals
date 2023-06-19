using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main()
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < list.Count - 1; i++)
            {
                int sumOfNums = 0;
                if (list[i] == list[i + 1])
                {
                    sumOfNums = list[i] + list[i + 1];
                    list[i + 1] = sumOfNums;
                    list.RemoveAt(i);
                    i=-1;

                }

            }
            Console.WriteLine(string.Join(' ',list));
        }
    }
}
