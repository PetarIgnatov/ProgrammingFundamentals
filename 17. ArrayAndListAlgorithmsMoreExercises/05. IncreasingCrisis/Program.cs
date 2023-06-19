using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._IncreasingCrisis
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<int> result = new List<int>();
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            result.AddRange(input);

            for (int i = 0; i < n - 1; i++)
            {
                input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

                AddToResult(input, result);
                CheckIncreasing(result);
            }


            Console.WriteLine(string.Join(" ", result));

        }

        static void CheckIncreasing(List<int> result)
        {
            for (int i = 0; i < result.Count - 1; i++)
            {
                if (IsIncreasing(result[i], result[i + 1]))
                {
                    continue;
                }
                else
                {
                    int count = result.Count - i;
                    result.RemoveRange(i + 1, count - 1);
                    break;
                }
            }
        }
        static void AddToResult(List<int> input, List<int> result)
        {
            for (int i = 0; i < result.Count; i++)
            {
                if ((input[0] < result[i]))
                {
                    result.InsertRange(i, input);
                    break;
                }
                else if (input[0] == result[i])
                {
                    continue;
                }
            }

            result.InsertRange(result.Count, input);
        }
        
        static bool IsIncreasing(int next, int previous)
        {
            if (previous >= next)
            {
                return true;
            }

            return false;
        }
    }

}

