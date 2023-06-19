using System;
using System.Linq;

namespace _12._CountOccurrencesOfLargerNumbersInArray
{
    class Program
    {
        static void Main()
        {
            double[] arr = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double n = double.Parse(Console.ReadLine());

            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] > n)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
