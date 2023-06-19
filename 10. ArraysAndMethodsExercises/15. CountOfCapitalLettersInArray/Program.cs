using System;
using System.Linq;

namespace _15._CountOfCapitalLettersInArray
{
    class Program
    {
        static void Main()
        {
            string[] arr = Console.ReadLine().Split(' ');
            int counter = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length == 1)
                {
                    char arrayChar = (arr[i][0]);

                    if (arrayChar >= 'A' || arrayChar <= 'Z')
                    {
                        counter++;
                    }
                }

            }
                Console.WriteLine(counter);

        }
    }
}
