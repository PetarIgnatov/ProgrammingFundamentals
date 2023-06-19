using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._FlattenDictionary
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, string>> data = new Dictionary<string, Dictionary<string, string>>();
            string[] input = Console.ReadLine().Split(' ');

            while (input[0] != "end")
            {
                if (input[0] != "flatten")
                {
                    string mainKey = input[0];
                    string innerKey = input[1];
                    string innerValue = input[2];

                    if (!data.ContainsKey(mainKey))
                    {
                        data.Add(mainKey, new Dictionary<string, string>());
                    }

                    data[mainKey][innerKey] = innerValue;
                }

                else
                {
                    string keyToFlatten = input[1];
                    data[keyToFlatten] = data[keyToFlatten].ToDictionary(r => r.Key + r.Value, r => "flattened");
                }

                input = Console.ReadLine().Split(' ');
            }

            foreach (var item in data.OrderByDescending(a => a.Key.Length))
            {
                Console.WriteLine($"{item.Key}");
                int position = 1;
                foreach (var pair in item.Value.Where(a => a.Value != "flattened").OrderBy(a => a.Key.Length))
                {                 
                   Console.WriteLine($"{position}. {pair.Key} - {pair.Value}");
                    position++;
                }

                foreach (var flat in item.Value.Where(a => a.Value == "flattened"))
                {
                    Console.WriteLine($"{position}. {flat.Key}");
                    position++;
                }

            }
        }
    }
}
