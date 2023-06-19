using System;

namespace _04._Hotel
{
    class Program
    {
        static void Main()
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double totalPrice = 0.0;
            double studio = 0.0;
            double roomPerTow = 0.0;
            double suite = 0.0;


            if (month == "May" || month == "October")
            {
                studio = 50;
                roomPerTow = 65;
                suite = 75;

                if (nights > 7)
                {
                    studio = 50 * 0.95;
                }
                else if (nights > 7 && month == "October")
                {
                    nights--;
                }
            }
            else if (month == "June" || month == "September")
            {
                studio = 60;
                roomPerTow = 72;
                suite = 82;

                if (nights > 14)
                {
                    roomPerTow = 72 * 0.90;
                }
                else if (nights > 7 && month == "September")
                {
                    nights--;
                }
            }
            else if (month == "July" || month == "August " || month == "December ")
            {
                studio = 68;
                roomPerTow = 77;
                suite = 89;

                if (nights > 14)
                {
                    suite = 89 * 0.85;
                }


            }
            Console.WriteLine($"Studio: {studio * nights:f2} lv.");
            Console.WriteLine($"Double: {roomPerTow * nights:f2} lv.");
            Console.WriteLine($"Suite: {suite * nights:f2} lv.");
        }
    }
}
