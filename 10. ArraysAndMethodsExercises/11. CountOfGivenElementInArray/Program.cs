using System;
using System.Linq;

namespace _11._CountOfGivenElementInArray
{
    class Program
    {
        static void Main()
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
           
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                
                if (arr[i] == n)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
