using System;

namespace _07._MultiplyEvensByOdds
{
    class Program
    {
        static void Main()
            {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(GetMultiple(Math.Abs(n)));
        }

         static int GetMultiple(int number)
        {
            int sumOfEven = GetEvenSum(number);
            int sumOfOdd = GetOddSum(number);
            return sumOfEven * sumOfOdd;
        }

         static int GetOddSum(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int lastdigit = number % 10;
                if (lastdigit % 2 != 0)
                {
                    sum += lastdigit;
                }
                number /= 10;
            }

            return sum;
            
        }

         static int GetEvenSum(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int lastdigit = number % 10;
                if (lastdigit % 2 == 0)
                {
                    sum += lastdigit;
                }
                number /= 10;
            }

            return sum;
        }
    }
}
