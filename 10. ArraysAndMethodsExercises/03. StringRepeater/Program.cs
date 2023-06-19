using System;

namespace _03._StringRepeater
{
    class Program
    {
        static void Main()
        {
            String word = Console.ReadLine();
            int repeated = int.Parse(Console.ReadLine());

            Console.WriteLine(RepeatString(word, repeated));
            
        }

         static string RepeatString(string word, int repeated)
        {
            string repeatedString = string.Empty;
            for (int i = 0; i < repeated; i++)
            {
                repeatedString += word;
            }

            return repeatedString;
        }
    }
}
