using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._EqualSumAfterExtraction
{
    class Program
    {
        static void Main()
        {
            List<int> firtsList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < firtsList.Count; i++)
            {

                //if (secondList.Contains(firtsList[i]))
                //{
                //    secondList.Remove(firtsList[i]);
                //}

                secondList.RemoveAll(x => x == firtsList[i]);
            }

            //int sumFirts = 0;
            //int sumSecond = 0;

            long firstSum = firtsList.Sum();
            long secondSum = secondList.Sum();

            //foreach (int item in firtsList)
            //{
            //    sumFirts += item;
            //}

            //foreach (int item in secondList)
            //{
            //    sumSecond += item;
            //}

            if (firstSum == secondSum)
            {
                Console.WriteLine($"Yes. Sum: {firstSum}");
            }
            else
            {
                long diff = Math.Abs(firstSum - secondSum);
                //int diff = Math.Abs(sumFirts - sumSecond);

                Console.WriteLine($"No. Diff: {diff}");
            }
        }
    }
}
