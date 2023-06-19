using System;

namespace _16._ArraySymmetry
{
    class Program
    {
        static void Main()
        {
            string[] arr = Console.ReadLine().Split(' ');
            string result = "Yes";

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != arr[arr.Length - 1 - i])
                {
                    result = "No";
                    break;
                }
            }

            Console.WriteLine(result);

            //if (arr[0] == arr[arr.Length - 1])
            //{
            //    for (int i = 1; i < arr.Length - 2; i++)
            //    {
            //        if (arr[i] != arr[i + 1])
            //        {
            //            result = "No";
            //            break;
            //        }
            //    }
            //}
            //else
            //{
            //    result = "No";
            //}

            //Console.WriteLine(result);
        }
    }
}

