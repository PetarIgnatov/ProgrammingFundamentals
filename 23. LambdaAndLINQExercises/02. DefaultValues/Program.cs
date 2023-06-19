using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._DefaultValues
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            Dictionary<string, string> result = new Dictionary<string, string>();

            while (input[0] != "end")
            {
                if (!result.ContainsKey(input[0]))
                {
                    result[input[0]] = (input[1]);
                }

                result[input[0]] = input[1];


                input = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            }

            string command = Console.ReadLine();

            var nonDefaultValues = result
                .Where(r => r.Value != "null")
                .OrderByDescending(r => r.Value.Length);

            var defaultValues = result
                .Where(r => r.Value == "null")
                .Select(r => new KeyValuePair<string, string>(r.Key, command))
                .ToDictionary(r => r.Key, r => r.Value);

            foreach (var record in nonDefaultValues)
            {
                Console.WriteLine($"{record.Key} <-> {record.Value}");
            }

            foreach (var record in defaultValues)
            {
                Console.WriteLine($"{record.Key} <-> {record.Value}");
            }

        }
    }
}
