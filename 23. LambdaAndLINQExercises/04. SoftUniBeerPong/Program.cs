using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._SoftUniBeerPong
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, int>> data = new Dictionary<string, Dictionary<string, int>>();
            string[] input = Console.ReadLine().Split(new char[] { '|', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            while (input[0] != "stop")
            {
                string player = input[0];
                string team = input[1];
                int score = int.Parse(input[2]);

                if (!data.ContainsKey(team))
                {
                    data.Add(team, new Dictionary<string, int>());
                }

                if (data[team].Count < 3)
                {
                    data[team].Add(player, score);
                }

                input = Console.ReadLine().Split(new char[] { '|', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            }
           
            int position = 1;

            foreach (var pair in data.Where(a => a.Value.Count() == 3).OrderByDescending(a => a.Value.Sum(a => a.Value)))
            {
                Console.WriteLine($"{position}. {pair.Key}; Players:");
                position++;
                foreach (var item in pair.Value.OrderByDescending(a => a.Value))
                {
                    Console.WriteLine($"###{item.Key}: {item.Value}");
                }
            }
        }
    }
}
