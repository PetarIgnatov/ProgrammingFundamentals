using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._MixedPhones
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, long> result = new Dictionary<string, long>();

            while (input[0] != "Over")
            {
                try
                {
                    if (long.Parse(input[1]) >= 0)
                    {
                        result.Add(input[0], long.Parse(input[1]));
                    }
                }
                catch (Exception)
                {
                    result.Add(input[1], long.Parse(input[0]));
                }


                input = Console.ReadLine().Split(new char[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (KeyValuePair<string, long> pair in result.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
