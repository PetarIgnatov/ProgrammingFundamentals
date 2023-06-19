using System;

namespace _11._OddNumber
{
    class Program
    {
        static void Main()
        {
            int num = Math.Abs(int.Parse(Console.ReadLine()));
            while (true)
            {
                 
                if (num % 2 == 1)
                {
                    Console.WriteLine("The number is: {0}", num);
                    break;
                }
                else
                {
                    Console.WriteLine("Please write an odd number.");
                    num = int.Parse(Console.ReadLine());

                }

            }
        }
    }
}
