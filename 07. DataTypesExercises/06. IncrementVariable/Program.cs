using System;

namespace _06._IncrementVariable
{
    class Program
    {
        static void Main()
        {

            int n = int.Parse(Console.ReadLine());
            int over = n / 256;
            int lastNum = n % 256;

            Console.WriteLine(lastNum);

            if (n > 255)
            {
                Console.WriteLine($"Overflowed {over} times");

            }
            



        }
    }
}
