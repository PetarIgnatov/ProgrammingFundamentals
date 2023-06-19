using System;
using System.Linq;

namespace _02._Largest_3_Numbers
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(string.Join(" ", Console.ReadLine().Split(' ').Select(int.Parse).OrderByDescending(n => n).Take(3)));
        }
    }
}
