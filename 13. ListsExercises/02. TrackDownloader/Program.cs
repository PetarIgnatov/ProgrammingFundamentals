using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._TrackDownloader
{
    class Program
    {
        static void Main()
        {
            List<string> list = Console.ReadLine().Split(' ').ToList();
            List<string> result = new List<string>();


            string input = Console.ReadLine();
            while (input != "end")
            {
                bool isMatch = false;

                for (int i = 0; i < list.Count; i++)
                {
                    if (input.Contains(list[i]))
                    {
                        isMatch = true;
                    }
                }

                if (!isMatch)
                {
                    result.Add(input);
                }

                input = Console.ReadLine();
            }

            result.Sort();
            Console.WriteLine(string.Join(Environment.NewLine, result));
        }
    }
}
