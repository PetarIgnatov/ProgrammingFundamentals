using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Camping
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, List<string>> campersData = new Dictionary<string, List<string>>();
            Dictionary<string, int> daysData = new Dictionary<string, int>();
            string[] input = Console.ReadLine().Split(' ');
            
            while (input[0] != "end")
            {
                string person = input[0];
                int nights = int.Parse(input[2]);
                string camperModel = input[1];

                if (!campersData.ContainsKey(person))
                {
                    campersData[person] = new List<string>();
                }

                campersData[person].Add(camperModel);

                if (!daysData.ContainsKey(person))
                {
                    daysData[person] = new int();
                }

                daysData[person] += nights;
                
                input = Console.ReadLine().Split(' ');
            }

            var orderedCampersData = campersData.OrderByDescending(a => a.Value.Count()).ThenBy(a => a.Key.Length);

            foreach (var item in orderedCampersData)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");

                foreach (var camper in item.Value)
                {
                    Console.WriteLine($"***{camper}");
                }

                Console.WriteLine($"Total stay: {daysData[item.Key]} nights");
            }
        }
    }
}
