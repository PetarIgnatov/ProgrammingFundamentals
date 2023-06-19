using System;

namespace _03._MilesToKilometers
{
    class Program
    {
        static void Main()
        {
            double miles = double.Parse(Console.ReadLine());
            double milesToKm = 1.60934;
            double kilometers = miles * milesToKm;

            Console.WriteLine($"{kilometers:f2}");

        }

    }
}
