using System;

namespace _11._5DifferentNumbers
{
    class Program
    {
        static void Main()
        {

            int min = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            int difference = max - min;

            if (difference < 4)
            {
                Console.WriteLine("No");
            }
            else
            {
                for (int first = min; first <= max - 4; first++)
                {
                    for (int second = first + 1; second <= max - 3; second++)
                    {
                        for (int third = second + 1; third <= max - 2; third++)
                        {
                            for (int fourth = third + 1; fourth <= max - 1; fourth++)
                            {
                                for (int fifth = fourth + 1; fifth <= max; fifth++)
                                {
                                    
                                        Console.WriteLine($"{first} {second} {third} {fourth} {fifth}");

                                    
                                }
                            }
                        }
                    }
                }
            }

        }
    }
}
