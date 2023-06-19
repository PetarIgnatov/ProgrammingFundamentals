using System;

namespace _13._GameOfNumbers
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magicalNum = int.Parse(Console.ReadLine());
            int sum = 0;
            int combinations = 0;

            int firstN = 0;
            int secondM = 0;


            for (int i = n; i <= m; i++)
            {
                for (int j = n; j <= m; j++)
                {
                    combinations++;
                    sum = i + j;

                    if (magicalNum == sum)
                    {
                        firstN = i;
                        secondM = j;
                    }
                }
            }

            if (firstN + secondM != 0)
            {
                Console.WriteLine(
                    $"Number found! {firstN} + {secondM} = {magicalNum}");
            }
            else
            {
                Console.WriteLine(
                    $"Total combinations: {combinations} – neither equals {magicalNum}");
            }


        }
    }
}
