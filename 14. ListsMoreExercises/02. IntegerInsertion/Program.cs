using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._IntegerInsertion
{
    class Program
    {
        static void Main()
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string token = Console.ReadLine();

            while (token != "end")
            {
                int number = int.Parse(token);

                int index = FindFirsDigit(number);
                //int index = token[0] - '0';

                input.Insert(index, number);

                token = Console.ReadLine();
            }


            Console.WriteLine(string.Join(" ", input));
        }

         static int FindFirsDigit(int number)
        {
            int firstDigit = number;

            while (number != 0)
            {
                firstDigit = number;
                number /= 10;
            }

            return firstDigit;
        }
    }
}
