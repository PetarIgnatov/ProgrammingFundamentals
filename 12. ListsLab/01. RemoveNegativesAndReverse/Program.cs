using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._RemoveNegativesAndReverse
{
    class Program
    {
        static void Main()
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> resultList = new List<int>();

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > 0)
                {
                    resultList.Add(list[i]);
                }
            }

            if (resultList.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                resultList.Reverse();
                Console.WriteLine(string.Join(' ', resultList));

            }

        }
    }
}
