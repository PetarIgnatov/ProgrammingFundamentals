using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._UnunionLists
{
    class Program
    {
        static void Main()
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int n = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                List<int> token = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

                for (int a = 0; a < token.Count; a++)
                {
                    if (!input.Contains(token[a]))
                    {
                        input.Add(token[a]);                   
                    }    
                    else
                    {
                        input.RemoveAll(x => x == token[a]);
                    }
                }
            }

            input.Sort();

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
