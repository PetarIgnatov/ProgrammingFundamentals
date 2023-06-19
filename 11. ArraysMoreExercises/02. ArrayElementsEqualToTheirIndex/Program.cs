using System;
using System.Linq;

namespace _02._ArrayElementsEqualToTheirIndex
{
    class Program
    {
        static void Main()
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string arrToPrint = string.Empty;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == i)
                {

                    Console.Write(arr[i] + " ");
                }
            }

            
        }
    }
}
