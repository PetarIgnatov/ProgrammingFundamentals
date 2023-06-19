using System;

namespace _12._TestNumbers
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int maxNum = int.Parse(Console.ReadLine());

            int combination = 0;
            int sum = 0;

            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= m; j++)
                {
                    combination++;
                    sum += 3 * (i * j);

                    if (sum >= maxNum)
                    {
                        Console.WriteLine($"{combination} combinations");
                        Console.WriteLine($"Sum: {sum} >= {maxNum}");
                        return;
                    }
                }
            }

            Console.WriteLine($"{combination} combinations");
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
