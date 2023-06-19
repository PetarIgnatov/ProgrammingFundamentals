using System;

namespace _04._NthDigit
{
    class Program
    {
        static void Main()
        {
            long number = long.Parse(Console.ReadLine());
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine(FindNthDigit(number, index));
        }


        static long FindNthDigit(long number, int index)
        {
            long checkingIndex = 1;

            while (number != 0)
            {
                if (checkingIndex == index)
                {
                    return number % 10;                 
                }
                else
                {
                    number /= 10;
                    checkingIndex++;
                }
            }

            return number % 10;

        }
    }
}
