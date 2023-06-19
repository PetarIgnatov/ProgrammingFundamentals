using System;
using System.Collections.Generic;

namespace _01._LetterRepetition
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            Dictionary<char, int> result = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!result.ContainsKey(input[i]))
                {
                    result.Add(input[i], 0);
                }

                result[input[i]]++;
            }

            foreach (KeyValuePair<char, int> pair in result)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
