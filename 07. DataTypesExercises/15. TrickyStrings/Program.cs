using System;

namespace _15._TrickyStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string delimiter = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string wordToPrint = string.Empty;

            for (int i = 1; i < n; i++)
            {
                string word = Console.ReadLine();
                wordToPrint += word + delimiter;
            }
                string lastWord = Console.ReadLine();

            Console.WriteLine(wordToPrint + lastWord);
        }
    }
}
