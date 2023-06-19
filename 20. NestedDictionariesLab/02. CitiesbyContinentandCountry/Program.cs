using System;
using System.Collections.Generic;

namespace _02._CitiesbyContinentandCountry
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, List<string>>> result = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(' ');

                string continent = tokens[0];
                string country = tokens[1];
                string city = tokens[2];

                if (!result.ContainsKey(continent))
                {
                    result[continent] = new Dictionary<string, List<string>>();
                }
                if (!result[continent].ContainsKey(country))
                {
                    result[continent][country] = new List<string>();
                }

                result[continent][country].Add(city);
            }

            foreach (var data in result)
            {
                Console.WriteLine($"{data.Key}:");

                var countries = data.Value;

                foreach (KeyValuePair<string, List<string>> countyAndCities in countries)
                {
                    string country = countyAndCities.Key;
                    List<string> cities = countyAndCities.Value;

                    Console.Write($"  {country} -> ");
                    Console.WriteLine(string.Join(", ",cities));
                }
                

            }
        }
    }
}
