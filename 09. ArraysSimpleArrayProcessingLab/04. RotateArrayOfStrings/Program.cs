using System;

namespace _04._RotateArrayOfStrings
{
    class Program
    {
        static void Main()
        {
            string[] arr = Console.ReadLine().Split(' ');
            string[] rotated = new string [arr.Length];
            
            string firstChar = arr[arr.Length - 1];
         
            for (int i = 1; i < arr.Length; i++)
            {
                rotated[i] = arr[i-1];
            }

            rotated[0] = firstChar;

            Console.WriteLine(string.Join(" ", rotated));

        }
    }
}
