using System;
using System.Collections.Generic;
using System.Linq;

namespace _12._OddOccurrences
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().ToLower().Split(' ');

            Dictionary<string, int> words = new Dictionary<string, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!words.ContainsKey(input[i]))
                {
                    words.Add(input[i], 0);
                }

                words[input[i]]++;
            }
            List<string> result = new List<string>();

            foreach (KeyValuePair<string, int> pair in words)
            {
                if (pair.Value % 2 == 1)
                {
                    result.Add(pair.Key);
                }
            }

            Console.WriteLine(string.Join(", ",result));
        }
    }
}
