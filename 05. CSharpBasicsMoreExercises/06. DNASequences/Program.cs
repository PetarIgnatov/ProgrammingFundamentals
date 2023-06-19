using System;

namespace _06._DNASequences
{
    class Program
    {
        static void Main()
        {
            int sum = int.Parse(Console.ReadLine());
            char specialChar;
            int counter = 0;

            for (int i = 1; i <= 4; i++)
            {
                for (int m = 1; m <= 4; m++)
                {
                    for (int n = 1; n <= 4; n++)
                    {

                        if (i + m + n >= sum)
                        {
                            specialChar = 'O';
                        }
                        else
                        {
                            specialChar = 'X';
                        }

                        Console.Write($"{specialChar}");

                        if (i == 1)
                        {
                            Console.Write("A");
                        }
                        else if (i == 2)
                        {
                            Console.Write("C");
                        }
                        else if (i == 3)
                        {
                            Console.Write("G");
                        }
                        else if (i == 4)
                        {
                            Console.Write("T");
                        }

                        if (m == 1)
                        {
                            Console.Write("A");
                        }
                        else if (m == 2)

                        {
                            Console.Write("C");
                        }
                        else if (m == 3)

                        {
                            Console.Write("G");
                        }
                        else if (m == 4)

                        {
                            Console.Write("T");
                        }

                        if (n == 1)

                        {
                            Console.Write("A");
                        }
                        else if (n == 2)

                        {
                            Console.Write("C");
                        }
                        else if (n == 3)

                        {
                            Console.Write("G");
                        }

                        else if (n == 4)

                        {
                            Console.Write("T");
                        }

                        Console.Write($"{specialChar} ");

                        counter++;

                        if (counter == 4)
                        {
                            counter = 0;
                            Console.WriteLine();
                        }

                    }

                }

            }

        }
    }
}