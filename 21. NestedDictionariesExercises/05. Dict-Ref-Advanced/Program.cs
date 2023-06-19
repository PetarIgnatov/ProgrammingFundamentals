using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Dict_Ref_Advanced
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(new string[] {" -> "}, StringSplitOptions.RemoveEmptyEntries).ToArray();

            Dictionary<string, List<int>> result = new Dictionary<string, List<int>>();

            while (input[0] != "end")
            {
                try
                {
                    int[] tokens = input[1].Split(new string[] { ", " },StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                    if (!result.ContainsKey(input[0]))
                    {
                        result[input[0]] = new List<int>();
                    }

                    result[input[0]].AddRange(tokens);

                }
                catch (Exception)
                {
                    if (result.ContainsKey(input[1]))
                    {
                        if (!result.ContainsKey(input[0]))
                        {
                            result.Add(input[0], new List<int>());
                        }

                        result[input[0]].AddRange(result[input[1]]);
                    }
                    
                }

                input = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            }

            foreach (KeyValuePair<string, List<int>> pair in result)
            {
                Console.WriteLine($"{pair.Key} === {string.Join(", ", pair.Value)}");
            }
        }
    }
}
