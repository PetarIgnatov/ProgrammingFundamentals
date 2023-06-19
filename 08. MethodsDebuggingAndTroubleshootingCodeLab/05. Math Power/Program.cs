using System;

namespace _05._Math_Power
{
    class Program
    {
        static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            double result = RaiseToPower(number, power);
            Console.WriteLine(result);
        }

         static double RaiseToPower(double number, int power)
        {
            double result = number;

            for (int i = 0; i < power - 1; i++)
            {
                result *= number;
            }
            return result;
        }
    }
}
