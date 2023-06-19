using System;
using System.Linq;

namespace _5._CountOfOddNumbersInArray
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int oddNum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    oddNum++;
                }
            }

            Console.WriteLine(oddNum);
        }
    }
}
