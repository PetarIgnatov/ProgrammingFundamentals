using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Stuck_Zipper
{
    class Program
    {
        static void Main()
        {
            List<int> firstZip = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> secondZip = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int minLenght = FindMinLenghtNumber(firstZip, secondZip);


            #region MyRegion
            //List<int> firstFiltredList = new List<int>();
            //List<int> secondFiltredList = new List<int>();

            //for (int i = 0; i < firstZip.Count; i++)
            //{
            //    if (FindNumberLenght(firstZip[i]) == minLenght)
            //    {
            //        firstFiltredList.Add(firstZip[i]);
            //    }
            //}

            //for (int i = 0; i < secondZip.Count; i++)
            //{
            //    if (FindNumberLenght(secondZip[i]) == minLenght)
            //    {
            //        secondFiltredList.Add(secondZip[i]);
            //    }
            //}

            //List<int> result = new List<int>();

            //for (int i = 0; i < Math.Max(firstFiltredList.Count, secondFiltredList.Count); i++)
            //{
            //    if (i < secondFiltredList.Count)
            //    {
            //        result.Add(secondFiltredList[i]);
            //    }

            //    if (i < firstFiltredList.Count)
            //    {
            //        result.Add(firstFiltredList[i]);
            //    }
            //}

            //Console.WriteLine(string.Join(" ",result));
            #endregion


            firstZip = RemoveBigestDigit(firstZip, minLenght);
            secondZip = RemoveBigestDigit(secondZip, minLenght);

            int index = 1;

            for (int i = 0; i <= firstZip.Count - 1; i++)
            {
                if (index > secondZip.Count)
                {
                    secondZip.Add(firstZip[i]);
                }
                else
                {
                    secondZip.Insert(index, firstZip[i]);
                }

                index += 2;
            }


            Console.WriteLine(string.Join(" ", secondZip));


        }
        static List<int> RemoveBigestDigit(List<int> list, int smallestElement)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (FindNumberLenght(list[i]) != smallestElement)
                {
                    list.RemoveAt(i);
                    i--;
                }
            }

            return list;
        }
        static int FindMinLenghtNumber(List<int> firstZip, List<int> secondZip)
        {
            int minLenght = int.MaxValue;
            int lenght = 0;

            for (int i = 0; i < firstZip.Count; i++)
            {
                lenght = FindNumberLenght(firstZip[i]);
                if (minLenght > lenght)
                {
                    minLenght = lenght;
                }

                if (minLenght == 1)
                {
                    return minLenght;
                }
            }

            for (int i = 0; i < secondZip.Count; i++)
            {
                lenght = FindNumberLenght(secondZip[i]);
                if (minLenght > lenght)
                {
                    minLenght = lenght;
                }

                if (minLenght == 1)
                {
                    return minLenght;
                }
            }

            return minLenght;
        }

        static int FindNumberLenght(int number)
        {
            int digitCount = 0;
            number = Math.Abs(number);
            while (number > 0)
            {
                digitCount++;
                number /= 10;
            }

            return digitCount;
        }
    }
}

