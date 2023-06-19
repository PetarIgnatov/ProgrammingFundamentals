using System;
using System.Collections.Generic;

namespace _05._UserLogins
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ', '-', '>' },
                StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, string> result = new Dictionary<string, string>();

            while (input[0] != "login")
            {
                if (!result.ContainsKey(input[0]))
                {
                    result.Add(input[0], input[1]);
                }

                result[input[0]] = input[1];

                input = Console.ReadLine().Split(new char[] { ' ', '-', '>' },
            StringSplitOptions.RemoveEmptyEntries);

            }

            input = Console.ReadLine().Split(new char[] { ' ', '-', '>' },
                StringSplitOptions.RemoveEmptyEntries);

            int count = 0;

            while (input[0] != "end")
            {
                if (!result.ContainsKey(input[0]))
                {
                    Console.WriteLine($"{input[0]}: login failed");
                    count++;
                }
                else if (result.ContainsKey(input[0]) & result[input[0]].Contains(input[1]))
                {
                    Console.WriteLine($"{input[0]}: logged in successfully");
                }
                else
                {
                    Console.WriteLine($"{input[0]}: login failed");
                    count++;
                }

                input = Console.ReadLine().Split(new char[] { ' ', '-', '>' },
                StringSplitOptions.RemoveEmptyEntries);
            }

            Console.WriteLine($"unsuccessful login attempts: {count}");
        }
    }
}
