using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Shellbound
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, HashSet<int>> result = new Dictionary<string, HashSet<int>>();
            string[] input = Console.ReadLine().Split(' ').ToArray();
           

            while (input[0] != "Aggregate")
            {
                string region = input[0];
                int size = int.Parse(input[1]);

                if (!result.ContainsKey(region))
                {
                    result[region] = new HashSet<int>();
                }
                result[region].Add(size);
                input = Console.ReadLine().Split(' ').ToArray();
            }

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} -> {string.Join(", ", item.Value)} ({item.Value.Sum() - (item.Value.Sum()/item.Value.Count())})");


            }
        }
    }
}
