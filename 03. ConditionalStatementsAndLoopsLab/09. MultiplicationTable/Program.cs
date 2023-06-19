using System;

namespace _09._MultiplicationTable
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int n = 1;

            while (n <= 10)
            {
                Console.WriteLine($"{num} X {n} = {num * n}");
                n++;
            }
        }
    }
}
