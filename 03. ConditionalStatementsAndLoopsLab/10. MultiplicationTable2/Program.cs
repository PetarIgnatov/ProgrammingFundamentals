using System;

namespace _10._MultiplicationTable2
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());

            if (multiplier > 10)
            {
                Console.WriteLine($"{num} X {multiplier} = {num * multiplier}");
                
            }

            while (multiplier <= 10)
            {
                
                Console.WriteLine($"{num} X {multiplier} = {num * multiplier}");
                multiplier++;
            }
        }

    }
}
