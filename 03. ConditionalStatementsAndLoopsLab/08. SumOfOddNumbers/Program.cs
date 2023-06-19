using System;

namespace _08._SumOfOddNumbers
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine(i * 2 - 1);
                sum += i * 2 - 1;
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
