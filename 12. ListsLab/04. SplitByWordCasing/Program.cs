using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._SplitByWordCasing
{
    class Program
    {
        static void Main()
        {
            List<string> listArr = Console.ReadLine().Split(new char[] 
            { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> lowerCase = new List<string>();
            List<string> upperCase = new List<string>();
            List<string> mixCase = new List<string>();

            for (int i = 0; i < listArr.Count; i++)
            {
                string word = listArr[i];
                int countLenghtMin = 0;
                int countLenghtMax = 0;

                for (int a = 0; a < word.Length; a++)
                {
                    if (word[a] >= 'a' && word[a] <= 'z')
                    {
                        countLenghtMin++;
                    }
                    else if (word[a] >= 'A' && word[a] <= 'Z')
                    {
                        countLenghtMax++;
                    }
                }

                if (countLenghtMax == word.Length)
                {
                    upperCase.Add(word);
                }
                else if (countLenghtMin == word.Length)
                {
                    lowerCase.Add(word);
                }
                else 
                {
                    mixCase.Add(word);
                }

            }

            Console.WriteLine(string.Join(' ', lowerCase));
            Console.WriteLine(string.Join(' ', mixCase));
            Console.WriteLine(string.Join(' ', upperCase));
        }
    }
}
