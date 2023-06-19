using System;
using System.Linq;

namespace _08._StringEncryption
{
    class Program
    {

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string result = string.Empty;
            int firts = 0;
           

            for (int i = 0; i < n; i++)
            {
                char letter = Char.Parse(Console.ReadLine());

                int charToInt = (int)(letter);

                if (charToInt < 100)
                {
                    firts = charToInt / 10;
                }
                else
                {
                    firts = charToInt / 100;
                }

                int second = charToInt % 10;
                int firstChar = charToInt + second;
                int secondChar = charToInt - firts;

                result += ($"{(char)firstChar}{firts}{second}{(char)secondChar}");

            }

            Console.WriteLine(result);

        }

    }
}
