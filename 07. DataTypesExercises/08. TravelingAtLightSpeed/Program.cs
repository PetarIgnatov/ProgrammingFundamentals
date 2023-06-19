using System;

namespace _08._TravelingAtLightSpeed
{
    class Program
    {
        static void Main()
        {
            decimal lightYear = decimal.Parse(Console.ReadLine());
            decimal kmPerSec = 300000;
            decimal seconds = (lightYear * 9450000000000) / kmPerSec;

            int minutes = (int)(seconds / 60);
            seconds %= 60;
            int hours = minutes / 60;
            minutes %= 60;
            int days = hours / 24;
            hours %= 24;
            int weeks = days / 7;
            days %= 7;

            Console.WriteLine($"{weeks} weeks");
            Console.WriteLine($"{days} days");
            Console.WriteLine($"{hours} hours");
            Console.WriteLine($"{minutes} minutes");
            Console.WriteLine($"{Math.Floor(seconds)} seconds");

        


           

        }
    }
}
