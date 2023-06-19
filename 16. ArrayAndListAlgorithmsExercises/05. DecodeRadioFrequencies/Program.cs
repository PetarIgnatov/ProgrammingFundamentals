using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._DecodeRadioFrequencies
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            List<char> result = new List<char>();

            for (int i = 0; i < input.Length; i++)
            {
                string[] tokens = input[i].Split('.');
                int firstFreq = int.Parse(tokens[0]);
                int secondFreq = int.Parse(tokens[1]);

                char firstLetter = (char)firstFreq;
                char secondLetter = (char)secondFreq;

                if (firstFreq != 0)
                {
                    result.Insert(i, firstLetter);
                }
                if (secondFreq != 0)
                {
                    result.Insert(result.Count - 1 - i, secondLetter);
                }
            }

            result.Reverse();

            Console.WriteLine(string.Join("", result));
        }
    }
}
