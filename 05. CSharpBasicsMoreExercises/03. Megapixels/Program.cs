using System;

namespace _03._Megapixels
{
    class Program
    {
        static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double resolution = (width * height) / 1000000;

            Console.WriteLine($"{width}x{height} => {Math.Round(resolution, 1)}MP");
        }
    }
}
