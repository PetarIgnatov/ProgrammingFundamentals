using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._RemoveElementsAtOddPositions
{
    class Program
    {
        static void Main()
        {
            List<string> listArr = Console.ReadLine().Split(' ').ToList();
            List<string> result = new List<string>();

            for (int i = 1; i < listArr.Count; i+=2)
            {
                result.Add(listArr[i]);
            }

            for (int i = 0; i < result.Count; i++)
            {
                Console.Write(result[i]);
            }
        }

       
    }
}
