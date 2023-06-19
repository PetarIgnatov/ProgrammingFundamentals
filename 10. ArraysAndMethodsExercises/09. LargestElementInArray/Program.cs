using System;

namespace _09._LargestElementInArray
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            int maxValue = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                

                if (maxValue < arr[i])
                {
                    maxValue = arr[i];
                }
            }

            Console.WriteLine(maxValue);
        }
    }
}
