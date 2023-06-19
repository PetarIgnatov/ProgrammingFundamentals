using System;
using System.Linq;

namespace _02._MultiplyAnArrayOfDoubles
{
    class Program
    {
        static void Main()
        {
            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double p = double.Parse(Console.ReadLine());

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = numbers[i] * p;
                Console.Write($"{numbers[i]} ");
            }

            //Console.Write(string.Join(" ",numbers));



        }
    }
}
