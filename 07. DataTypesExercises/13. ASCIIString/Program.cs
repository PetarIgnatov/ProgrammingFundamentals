using System;

namespace _13._ASCIIString
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string wordsToPrint = string.Empty;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                char alfa = (char)num;
                wordsToPrint += alfa;

            }

            Console.WriteLine(wordsToPrint);
        }
    }
}
