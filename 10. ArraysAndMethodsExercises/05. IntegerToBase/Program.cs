using System;

namespace _05._IntegerToBase
{
    class Program
    {
        static void Main()
        {
            long number = long.Parse(Console.ReadLine());
            int toBase = int.Parse(Console.ReadLine());

            Console.WriteLine(IntegerToBase(number, toBase));
        }
        static string IntegerToBase(long number, int toBase)
        {
            string result = string.Empty;

            while (number != 0)
            {
                long remainder = number % toBase;
                result = remainder + result;
                number /= toBase;

                //long first = number % toBase;
                //number /= toBase;
                //string second = result;
                //result = first + second;

            }

            return result;
        }
    }
}
