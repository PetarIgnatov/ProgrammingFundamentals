using System;

namespace _07._FromTerabytesToBits
{
    class Program
    {
        static void Main()
        {
            decimal teraBytes = decimal.Parse(Console.ReadLine()); 
            decimal bytes =  teraBytes * (1024m * 1024 * 1024 * 1024 * 8);
            Console.WriteLine(Math.Round(bytes));
        }
    }
}
