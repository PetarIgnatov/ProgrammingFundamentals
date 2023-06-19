using System;
using System.Collections.Generic;

namespace _03._RecordUniqueNames
{
    class Program
    {
        static void Main()
        {
            HashSet<string> data = new HashSet<string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                data.Add(input);
            }

            foreach (string item in data)
            {
                Console.WriteLine(item);
            }
        }
    }
}
