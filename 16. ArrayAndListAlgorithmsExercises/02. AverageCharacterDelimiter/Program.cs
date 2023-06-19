using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._AverageCharacterDelimiter
{
    class Program
    {
        static void Main()
        {
            List<string> input = Console.ReadLine().Split(' ').ToList();

            int sumOfElements = 0;
            int elementsCounter = 0;

            for (int i = 0; i < input.Count; i++)
            {
                for (int a = 0; a < input[i].Length; a++)
                {
                    sumOfElements += input[i][a];
                    elementsCounter++;
                }

            }

            int average = sumOfElements / elementsCounter;
            string delimiter = Convert.ToChar(average).ToString();
            
            

            Console.WriteLine(string.Join(delimiter.ToUpper(),input));
        }


    }
}
