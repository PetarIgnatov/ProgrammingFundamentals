using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._StringDecryption
{
    class Program
    {
        static void Main()
        {
            int[] token = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            IEnumerable<char> result = input.Where(a => a >= 65 && a <= 90).Skip(token[0]).Take(token[1]).Select(a => (char)a);

            Console.WriteLine(string.Join("",result));
       }
    }
}
