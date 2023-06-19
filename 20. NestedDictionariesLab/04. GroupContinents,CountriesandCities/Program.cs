using System;
using System.Collections.Generic;

namespace _04._GroupContinents_CountriesandCities
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            SortedDictionary<string, SortedDictionary<string, SortedSet<string>>> result = new SortedDictionary<string, SortedDictionary<string, SortedSet<string>>>();

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(' ');

                string continent = tokens[0];
                string country = tokens[1];
                string city = tokens[2];

                if (!result.ContainsKey(continent))
                {
                    result[continent] = new SortedDictionary<string, SortedSet<string>>();
                }
                if (!result[continent].ContainsKey(country))
                {
                    result[continent][country] = new SortedSet<string>();
                }

                result[continent][country].Add(city);
            }

            foreach (var data in result)
            {
                Console.WriteLine($"{data.Key}:");

                var countries = data.Value;

                foreach (KeyValuePair<string, SortedSet<string>> countyAndCities in countries)
                {
                    string country = countyAndCities.Key;
                    SortedSet<string> cities = countyAndCities.Value;

                    Console.Write($"  {country} -> ");
                    Console.WriteLine(string.Join(", ", cities));
                }


            }
        }
    }
}
