using System;

namespace _14._MagicLetter
{
    class Program
    {
        static void Main()
        {
            char startLetter = char.Parse(Console.ReadLine().ToLower());
            char endLetter = char.Parse(Console.ReadLine().ToLower());
            char magicLetter = char.Parse(Console.ReadLine().ToLower());

            for (char i = startLetter; i <= endLetter; i++)
            {
                for (char j = startLetter; j <= endLetter; j++)
                {
                    for (char l = startLetter; l <= endLetter; l++)
                    {
                        string word = "" + i + j + l;

                        //if (!word.Contains(magicLetter))
                        //{
                        //    Console.Write(word + " ");
                        //}
                        if (i != magicLetter && j != magicLetter && l != magicLetter)
                        {
                            Console.Write($"{i}{j}{l} ");
                        }
                        

                    }

                }

            }
        }
    }
}
