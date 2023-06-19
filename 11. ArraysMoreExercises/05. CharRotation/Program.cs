using System;
using System.Linq;

namespace _05._CharRotation
{
    class Program
    {
        static void Main()
        {
            string arr = Console.ReadLine();
            int[] numArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string word = string.Empty;

            for (int i = 0; i < arr.Length; i++)
            {
                if (numArr[i] % 2 == 1)
                {
                    int result = arr[i] + numArr[i];
                    word += (char)result;
                }
                else
                {
                    int result = arr[i] - numArr[i];
                    word += (char)result;
                }
               
            }


            Console.WriteLine(word);
        }
    }
}
