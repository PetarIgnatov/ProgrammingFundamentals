using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._AverageStudentGrades
{
    class Program
    {
        static void Main()
        {
            int repeats = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> result = new Dictionary<string, List<double>>();

            for (int i = 0; i < repeats; i++)
            {
                string[] tokens = Console.ReadLine().Split();

                string name = tokens[0];
                double grade = double.Parse(tokens[1]);

                if (!result.ContainsKey(name))
                {
                    result[name] = new List<double>();
                }

                result[name].Add(grade);
            }

            foreach (KeyValuePair<string, List<double>> pair in result)
            {
                List<double> grades = pair.Value;
                
                Console.Write($"{pair.Key} -> ");

                foreach (double grade in grades)
                {
                    Console.Write($"{grade:f2} ");
                }

                Console.WriteLine($"(avg: {pair.Value.Average():f2})");
            }
        }
    }
}
