using System;

namespace _02._PMCounter
{
    class Program
    {
        static void Main()
        {
            int beatsPerMin = int.Parse(Console.ReadLine());
            int numberOfBeats = int.Parse(Console.ReadLine());

            double bars = numberOfBeats / 4.0;

            double beatsPerSec = (beatsPerMin / 60.0);
            double beats = Math.Truncate(numberOfBeats / beatsPerSec);

            double min = 0;
            double sec = 0;

            if (beats >= 60)
            {
                min += Math.Truncate(beats / 60);
                sec = (int)(beats % 60);
            }
            else
            {
                sec = beats;
            }


            Console.WriteLine($"{Math.Round(bars,1)} bars - {min}m {sec}s");
        }
    }
}
