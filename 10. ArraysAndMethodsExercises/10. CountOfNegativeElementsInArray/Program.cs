using System;

namespace _10._CountOfNegativeElementsInArray
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int counter = 0;
            for (int i = 0; i < n; i++)
            {
                 arr[i] = int.Parse(Console.ReadLine());

                if (arr[i] < 0)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }


    }
}
