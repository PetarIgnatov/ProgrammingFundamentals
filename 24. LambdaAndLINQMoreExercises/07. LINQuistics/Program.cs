using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._LINQuistics
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, HashSet<string>> result = new Dictionary<string, HashSet<string>>();

            string[] input = Console.ReadLine().Split(new char[] { '.', '(', ')' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            while (input[0] != "exit")
            {
                string collectionName = input[0];

                if (!result.ContainsKey(collectionName))
                {
                    result[collectionName] = new HashSet<string>();
                }

                for (int i = 1; i < input.Length; i++)
                {
                    result[collectionName].Add(input[i]);
                }

                input = Console.ReadLine().Split(new char[] { '.', '(', ')' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (result.ContainsKey(input[0]) & input.Length == 1)
                {
                    var orderedData = result[input[0]].OrderByDescending(a => a.Length).ThenByDescending(b => b.Distinct().Count());

                    PrintMethods(orderedData);
                }

                else if (int.TryParse(input[0], out int number))
                {
                    if (result.Count > 0)
                    {
                        var collectionWithMostMethods = result.OrderByDescending(a => a.Value.Count).First();

                        var methodsToPrint = collectionWithMostMethods.Value.OrderBy(a => a.Length).Take(number);

                        PrintMethods(methodsToPrint);

                    }
                }
            }

            string[] lastLine = Console.ReadLine().Split(' ').ToArray();

            string method = lastLine[0];
            string selection = lastLine[1];

            var collectionsToPrint = result.Where(a => a.Value.Contains(method)).OrderByDescending(a => a.Value.Count).ThenByDescending(b => b.Value.OrderBy(x => x.Length).First().Length);

            foreach (var item in collectionsToPrint)
            {
                string collection = item.Key;
                HashSet<string> methods = item.Value;

                var orderedMethods = methods.OrderByDescending(v => v.Length);

                Console.WriteLine(collection);

                if (selection == "all")
                {
                    PrintMethods(orderedMethods);
                }
            }
        }

        static void PrintMethods(IEnumerable<string> data)
        {
            foreach (var method in data)
            {
                Console.WriteLine($"* {method}");
            }
        }
    }
}