using System;
using System.Collections.Generic;

namespace _06._FilterBase
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ', '-', '>' },
                 StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> ageResult = new Dictionary<string, int>();
            Dictionary<string, double> salaryResult = new Dictionary<string, double>();
            Dictionary<string, string> positionResult = new Dictionary<string, string>();

            while (input[0] != "filter")
            {
                if (int.TryParse(input[1], out int age))
                {
                    ageResult.Add(input[0], age);
                }
                else if (double.TryParse(input[1], out double salary))
                {
                    salaryResult.Add(input[0], salary);
                }
                else
                {
                    positionResult.Add(input[0], input[1]);
                }

                input = Console.ReadLine().Split(new char[] { ' ', '-', '>' },
                 StringSplitOptions.RemoveEmptyEntries);
            }

            string printWord = Console.ReadLine();

            if (printWord == "Age")
            {
                foreach (KeyValuePair<string, int> pair in ageResult)
                {
                    Console.WriteLine($"Name: {pair.Key}");
                    Console.WriteLine($"Age: {pair.Value}");
                    Console.WriteLine(new string('=', 20));
                }
            }
            else if (printWord == "Salary")
            {
                foreach (KeyValuePair<string, double> pair in salaryResult)
                {
                    Console.WriteLine($"Name: {pair.Key}");
                    Console.WriteLine($"Salary: {pair.Value:f2}");
                    Console.WriteLine(new string('=', 20));
                }
            }
            else
            {
                foreach (KeyValuePair<string, string> pair in positionResult)
                {
                    Console.WriteLine($"Name: {pair.Key}");
                    Console.WriteLine($"Position: {pair.Value}");
                    Console.WriteLine(new string('=', 20));
                }

            }
        }
    }
}
