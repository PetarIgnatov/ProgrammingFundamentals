using System;
using System.Linq;

namespace _13._IncreasingSequenceOfElements
{
    class Program
    {
        static void Main()
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string result = string.Empty;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] < arr[i + 1])
                {
                    result = "Yes";
                }
                else
                {
                    result = "No";
                    break;
                }
            }

            Console.WriteLine(result);

        }
    }
}
