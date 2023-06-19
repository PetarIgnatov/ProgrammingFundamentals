using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._ArrayHistogram
{
    class Program
    {
        static void Main()
        {
            List<string> input = Console.ReadLine().Split(' ').ToList();

            List<string> tokens = new List<string>();
            List<int> counterTokens = new List<int>();

            for (int i = 0; i < input.Count; i++)
            {
                if (!tokens.Contains(input[i]))
                {
                    tokens.Add(input[i]);
                    counterTokens.Add(1);
                }
                else
                {
                    for (int a = 0; a < tokens.Count; a++)
                    {
                        if (input[i] == tokens[a])
                        {
                            counterTokens[a]++;
                        }
                    }
                }
            }

            Sort(tokens, counterTokens);


            for (int i = 0; i < tokens.Count; i++)
            {
                double currentElement = counterTokens[i];
                double sumOfAllElements = counterTokens.Sum();
                double percent = (currentElement / sumOfAllElements) * 100;

                Console.WriteLine($"{tokens[i]} -> {counterTokens[i]} times ({percent:F2}%)");
            }

        }

        static void Sort(List<string> tokens, List<int> counter)
        {
            for (int i = 0; i < tokens.Count - 1; i++)
            {
                for (int a = i; a >= 0; a--)
                {
                    if (counter[a] < counter[a + 1])
                    {
                        string swappedElement = tokens[a + 1];
                        tokens[a + 1] = tokens[a];
                        tokens[a] = swappedElement;

                        int swappedCounter = counter[a + 1];
                        counter[a + 1] = counter[a];
                        counter[a] = swappedCounter;

                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
    }
}
