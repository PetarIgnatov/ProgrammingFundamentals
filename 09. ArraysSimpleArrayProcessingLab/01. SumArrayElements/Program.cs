using System;

namespace _01._SumArrayElements
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] num = new int[n];
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
                sum += num[i];
            }

            Console.WriteLine(sum);
        }
    }
}
