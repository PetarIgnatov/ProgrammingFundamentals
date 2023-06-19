using System;

namespace _01_.Last3ConsecutiveEqualStrings
{
    class Program
    {
        static void Main()
        {
            string[] arr = Console.ReadLine().Split(' ');

            int repetitions = 1;
            string wordToPrint = string.Empty;

            for (int i = arr.Length - 1; i >= 0; i--)
            {

                if (arr[i] == arr[i - 1])
                {
                    repetitions++;
                   
                }
                else
                {
                    repetitions = 1;
                }

                if (repetitions == 3)
                {
                    wordToPrint = arr[i];
                    break; 
                }
            }

            Console.WriteLine($"{wordToPrint} {wordToPrint} {wordToPrint}");
        }
    }
}
