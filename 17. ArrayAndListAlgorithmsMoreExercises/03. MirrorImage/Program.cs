using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._MirrorImage
{
    class Program
    {
        static void Main()
        {
            List<string> input = Console.ReadLine().Split(' ').ToList();
            string n = Console.ReadLine();

            while (n != "Print")
            {
                int numb = int.Parse(n);

                for (int i = 0; i < numb / 2; i++)
                {
                    string first = input[i];
                    input[i] = input[numb - 1 - i];
                    input[numb - 1 - i] = first;
                    //input.Reverse(0, numb);

                }

                int rotations = input.Count - numb - 1;

                for (int i = 0; i < rotations / 2; i++)
                {
                    string second = input[input.Count - 1 - i];
                    input[input.Count - 1 - i] = input[numb + 1 + i];
                    input[numb + 1 + i] = second;
                    //input.Reverse(numb + 1, rotations);
                }

                n = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
