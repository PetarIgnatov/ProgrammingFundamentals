using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._TravelCompany
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, int>> result = new Dictionary<string, Dictionary<string, int>>();
            string[] input = Console.ReadLine().Split(':').ToArray();

            while (input[0] != "ready")
            {
                string city = input[0];
                string[] tokens = input[1].Split(new char[] { ',', '-' }).ToArray();

                if (!result.ContainsKey(city))
                { 
                    result[city] = new Dictionary<string, int>();
                    AddCitiesAndTransport(result, city, tokens);
                }
                else
                {
                    AddCitiesAndTransport(result, city, tokens);
                }

                input = Console.ReadLine().Split(':').ToArray();
            }

            string[] groups = Console.ReadLine().Split(' ').ToArray();

            while (groups[0] != "travel")
            {
                string city = groups[0];
                int peopleCount = int.Parse(groups[1]);

                if (result.ContainsKey(city))
                {
                    int transportCapacities = result[city].Values.Sum();

                    if (peopleCount <= transportCapacities)
                    {
                        Console.WriteLine($"{city} -> all {peopleCount} accommodated");
                    }
                    else
                    {
                        Console.WriteLine($"{city} -> all except {peopleCount - transportCapacities} accommodated");
                    }
                }

                groups = Console.ReadLine().Split(' ').ToArray();
            }
        }

        static void AddCitiesAndTransport(Dictionary<string, Dictionary<string, int>> result, string city, string[] tokens)
        {
            for (int i = 0; i < tokens.Length - 1; i += 2)
            {
                string vehicle = tokens[i];
                int capacity = int.Parse(tokens[i + 1]);
                result[city][vehicle] = capacity;
            }
        }
    }
}
