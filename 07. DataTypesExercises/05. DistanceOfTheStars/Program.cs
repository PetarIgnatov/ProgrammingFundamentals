using System;

namespace _05._DistanceOfTheStars
{
    class Program
    {
        static void Main()
        {
            decimal distanceToNearestStar = 4.22m;
            decimal km = 9450000000000m;

            decimal lightYears = km * distanceToNearestStar;
            Console.WriteLine($"{lightYears:e2}");
        }
    }
}
