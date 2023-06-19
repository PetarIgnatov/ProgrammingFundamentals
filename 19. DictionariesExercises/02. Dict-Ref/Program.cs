using System;
using System.Collections.Generic;

namespace _02._Dict_Ref
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ', '=' },
                StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> result = new Dictionary<string, int>();

            while (input[0] != "end")
            {
                try
                {
                    if (!result.ContainsKey(input[0]))
                    {
                        result.Add(input[0], int.Parse(input[1]));
                    }
                    else
                    {
                        result[input[0]] = int.Parse(input[1]);
                    }
                }
                catch (Exception)
                {
                    if (result.ContainsKey(input[1]))
                    {
                        result[input[0]] = result[input[1]];
                    }
                    
                }

                input = Console.ReadLine().Split(new char[] { ' ', '=' },
                    StringSplitOptions.RemoveEmptyEntries);
            }


            foreach (KeyValuePair<string, int> pair in result)
            {
                Console.WriteLine($"{pair.Key} === {pair.Value}");
            }
        }
    }
}
