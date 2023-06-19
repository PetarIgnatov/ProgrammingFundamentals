using System;
using System.Linq;

namespace _14._EqualSequenceOfElementsInArray
{
    class Program
    {
        static void Main()
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string result = string.Empty;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] != arr[i + 1])
                { 
                    result = "No";
                    break;
                }
                else
                {
                    result = "Yes";
                    break;
                }
            }

            Console.WriteLine(result);
        }
    }
}
