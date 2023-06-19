using System;

namespace _03._BackIn30Minutes
{
    class Program
    {
        static void Main()
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes += 30;

            hours += minutes / 60;
            minutes = minutes % 60;

            if (hours >= 24)
            {
                hours = 0;
            }

            // hours = hours >= 24 ? 0 : hours;

            Console.WriteLine($"{hours:D2}:{minutes:D2}");
        }
    }
}
