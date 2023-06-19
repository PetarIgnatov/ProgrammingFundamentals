using System;

namespace _06._IntervalOfNumbers
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int bigger = Math.Max(a, b);
            int smaller = Math.Min(a, b);

            for (int i = smaller; i <= bigger; i++)
            {
                Console.WriteLine(i);
            }


        }
    }
}
