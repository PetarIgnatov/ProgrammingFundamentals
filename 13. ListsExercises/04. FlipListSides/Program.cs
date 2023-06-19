using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._FlipListSides
{
    class Program
    {
        static void Main()
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> result = new List<int>();

            result.Add(list[0]);

            for (int i = list.Count - 2; i >= 1; i--)
            {
                result.Add(list[i]);
            }

            result.Add(list[list.Count - 1]);

            //for (int i = 1; i < = list.Count / 2; i++)
            //{
            //    var firstNum = list[i];
            //    var lastNum = list[list.Count - i - 1];

            //    list[i] = lastNum;
            //    list[list.Count - i - 1] = firstNum;
            //}

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
