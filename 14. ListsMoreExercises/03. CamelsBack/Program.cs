using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._CamelsBack
{
    class Program
    {
        static void Main()
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int size = int.Parse(Console.ReadLine());
            int rounds = (input.Count - size) / 2;

            if (rounds > 0)
            {
                for (int i = 0; i < rounds; i++)
                {
                    input.RemoveAt(input.Count - 1);
                    input.RemoveAt(0);
                }

                Console.WriteLine($"{rounds} rounds");
                Console.WriteLine("remaining: " + string.Join(" ", input));
            }

            else
            {
                Console.WriteLine("already stable: " + string.Join(" ", input));
            }
        }
    }
}
