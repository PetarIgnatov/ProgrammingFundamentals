using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._SortNumbers
{
    class Program
    {
        static void Main()
        {
            List<double> listArr = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            listArr.Sort();

            Console.WriteLine(string.Join(" <= ", listArr));
        }
    }
}
