using System;
using System.Collections.Generic;

namespace _01._Shoot_ListElements
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            List<int> resultList = new List<int>();
            int lastElement = 0;

            while (input != "stop")
            {
                if (input == "bang")
                {
                    lastElement = resultList[0];
                    RemoveElement(resultList);

                }
                else
                {
                    int number = int.Parse(input);
                    resultList.Insert(0, number);
                }

                input = Console.ReadLine();

                if (resultList.Count == 0 && input != "stop")
                {
                    Console.WriteLine($"nobody left to shoot! last one was {lastElement}");
                    return;
                }
            }

            PrintResult(resultList, lastElement);
        }

        static void PrintResult(List<int> resultList, int lastElement)
        {
            if (resultList.Count > 0)
            {
                Console.WriteLine($"survivors: {string.Join(" ", resultList)}");
            }
            else
            {
                Console.WriteLine($"you shot them all. last one was {lastElement}");
            }
        }

        static void RemoveElement(List<int> resultList)
        {
            for (int i = 0; i < resultList.Count; i++)
            {
                double average = Average(resultList);
                if (resultList[i] <= average)
                {
                    Console.WriteLine($"shot {resultList[i]}");
                    resultList.Remove(resultList[i]);
                    Decrement(resultList);
                    return;
                }
            }
        }

        static void Decrement(List<int> resultList)
        {
            for (int i = 0; i < resultList.Count; i++)
            {
                resultList[i]--;
            }
        }

        static double Average(List<int> resultList)
        {
            double average = 0.0;
            for (int n = 0; n < resultList.Count; n++)
            {
                average += resultList[n];
            }

            return average /= resultList.Count;
        }
    }
}
