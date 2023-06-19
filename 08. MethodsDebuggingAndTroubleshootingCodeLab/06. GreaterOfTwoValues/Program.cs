using System;

namespace _06._GreaterOfTwoValues
{
    class Program
    {
        static void Main()
        {
            string type = Console.ReadLine();

            if (type == "int")
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                int max = GetMax(first, second);
                Console.WriteLine(max);
            }
            else if (type == "char")
            {
                char firts = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());
                char max = GetMax(firts, second);
                Console.WriteLine(max);
            }
            else
            {
                string firts = Console.ReadLine();
                string second = Console.ReadLine();
                string max = GetMax(firts, second);
                Console.WriteLine(max);
            }
        }

        static string GetMax(string firts, string second)
        {
            if (firts.CompareTo(second) >= 0)
            {
                return firts;
            }
            else
            {
                return second;
            }
        }

        static char GetMax(char first, char second)
        {
            if (first > second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }

        static int GetMax(int first, int second)
        {
            return Math.Max(first, second);
        }
    }
}
