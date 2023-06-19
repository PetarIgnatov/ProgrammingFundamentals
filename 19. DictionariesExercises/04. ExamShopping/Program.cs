using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._ExamShopping
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            Dictionary<string, int> result = new Dictionary<string, int>();

            while (input[0] != "shopping")
            {
                if (!result.ContainsKey(input[1]))
                {
                    result.Add(input[1], int.Parse(input[2]));
                }
                else
                {
                    result[input[1]] += int.Parse(input[2]);
                }

                input = Console.ReadLine().Split(' ');
            }

            input = Console.ReadLine().Split(' ');

            while (input[0] != "exam")
            {
                if (!result.ContainsKey(input[1]))
                {
                    Console.WriteLine($"{input[1]} doesn't exist");
                }
                else if (result[input[1]] <= 0)
                {
                    Console.WriteLine($"{input[1]} out of stock");
                }
                else
                {
                    result[input[1]] -= int.Parse(input[2]);
                }

                input = Console.ReadLine().Split(' ');
            }

            foreach (KeyValuePair<string, int> pair in result.Where(x => x.Value > 0))
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
