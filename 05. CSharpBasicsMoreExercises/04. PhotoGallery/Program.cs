using System;
using System.Globalization;

namespace _04._PhotoGallery
{
    class Program
    {
        static void Main()
        {
            int photoNumber = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int size = int.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            string orientation = string.Empty;

            Console.WriteLine($"Name: DSC_{photoNumber:D4}.jpg");

            Console.WriteLine($"Date Taken: {day:D2}/{month:D2}/{year:D4} {hours:D2}:{minutes:D2}");

            if (size <= 1000)
            {
                Console.WriteLine($"Size: {size}B");
            }
            else if (size <= 1000000)
            {
                Console.WriteLine($"Size: {size / 1000}KB");
            }
            else
            {
                Console.WriteLine($"Size: {(size / 1000000.0):F1}MB");
            }


            if (width > height)
            {
                orientation = "landscape";
            }
            else if (width < height)
            {
                orientation = "portrait";
            }
            else
            {
                orientation = "square";
            }

            Console.WriteLine($"Resolution: {width}x{height} ({orientation})");

        }
    }
}
