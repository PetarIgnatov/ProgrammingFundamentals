using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._AppendLists
{
    class Program
    {
        static void Main()
        {
            List<string> list = Console.ReadLine().Split('|').ToList();
            List<string> result = new List<string>();

            for (int i = 0; i < list.Count; i++)
            {
                string partsToAdd = string.Empty;
                string partsOfList = list[i];

                for (int a = 0; a < partsOfList.Length; a++)
                {
                    if (partsOfList[a] >= '0' && partsOfList[a] <= '9')
                    {
                        partsToAdd += partsOfList[a] + " ";
                       
                    }
                }
               
                result.Add(partsToAdd.TrimEnd());

                partsToAdd = string.Empty;
            }

            result.Reverse();

            Console.WriteLine(string.Join(' ', result));
        }

    }
}
