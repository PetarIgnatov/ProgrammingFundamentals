using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Key_Key_Value_Value
{
    class Program
    {
        static void Main()
        {
            string key = Console.ReadLine();
            string value = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> result = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(new string[] { " => " },StringSplitOptions.RemoveEmptyEntries).ToArray();
                string inputKey = input[0];

                if (inputKey.Contains(key))
                {
                    result[inputKey] = new List<string>();

                    string[] inputValue = input[1].Split(';').ToArray();

                    for (int a = 0; a < inputValue.Length; a++)
                    {
                        if (inputValue[a].Contains(value))
                        {
                            result[inputKey].Add(inputValue[a]);
                        }
                    }
                }
            }

            foreach (KeyValuePair<string, List<string>> pair in result)
            {
                Console.WriteLine($"{pair.Key}:");

                foreach (string item in pair.Value)
                {
                    Console.WriteLine($"-{item}");
                }
            }

        }
    }
}
