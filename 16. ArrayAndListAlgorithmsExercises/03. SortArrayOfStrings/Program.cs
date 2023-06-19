using System;
using System.Collections.Generic;
using System.Linq;


namespace _03._SortArrayOfStrings
{
    class Program
    {
        static void Main()
        {
            List<string> input = Console.ReadLine().Split(' ').ToList();

            for (int i = 0; i < input.Count - 1; i++)
            {
                for (int a = i; a >= 0; a--)
                {
                    if (input[a].CompareTo(input[a + 1]) == 1)
                    {
                        string swappedElement = input[a + 1];
                        input[a + 1] = input[a];
                        input[a] = swappedElement;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
