using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int firtsNumb = int.Parse(Console.ReadLine());
            if (firtsNumb.IsNumber >= 5)
            {
                Console.WriteLine("The number is " + firtsNumb + " wow");

            }
            else
            {
                Console.WriteLine("The number is below 5");
            }

        }
    }
}
