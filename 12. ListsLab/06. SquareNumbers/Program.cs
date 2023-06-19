using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._SquareNumbers
{
    class Program
    {
        static void Main()
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> result = new List<int>();
            foreach (var num in list)
            {

                if (Math.Sqrt(num) == (int)Math.Sqrt(num))
                {
                    result.Add(num);
                }
            }

            result.Sort();
            result.Reverse();
            Console.WriteLine(string.Join(' ', result));
        }
    }
}
