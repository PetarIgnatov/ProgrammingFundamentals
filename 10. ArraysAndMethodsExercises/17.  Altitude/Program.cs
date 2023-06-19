using System;

namespace _17.__Altitude
{
    class Program
    {
        static void Main()
        {
            string[] arr = Console.ReadLine().Split(' ');
            int altitude = int.Parse(arr[0]);

            for (int i = 1; i < arr.Length; i += 2)
            { 

                if (arr[i] == "up")
                {
                    altitude += int.Parse(arr[i + 1]);
                }
                else
                {
                    altitude -= int.Parse(arr[i + 1]);

                    if (altitude <= 0)
                    {
                        Console.WriteLine("crashed");
                        return;
                    }
                }

            }

            Console.WriteLine($"got through safely. current altitude: {altitude}m");

        }

    }
}






