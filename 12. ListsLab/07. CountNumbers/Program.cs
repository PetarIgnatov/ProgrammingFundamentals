using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._CountNumbers
{
    class Program
    {
        static void Main()
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            list.Sort();
            List<int> counting = new List<int>();
            List<int> result = new List<int>();
            int count = 1;

            for (int i = 0; i < list.Count - 1; i++)
            {

                if (list[i].Equals(list[i + 1]))
                {
                    count++;
                }
                else
                {
                    counting.Add(count);
                    result.Add(list[i]);
                    count = 1;

                }

            }

            counting.Add(count);
            result.Add(list[list.Count - 1]);

            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine($"{result[i]} -> {counting[i]}");
            }
        }
    }
}
