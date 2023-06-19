using System;
using System.Collections.Generic;
using System.Linq;
namespace _03._Short_Words_Sorted
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().ToLower().
                Split(new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '\\', '\"', '\'', '/', '!', '?', ' ' },StringSplitOptions.RemoveEmptyEntries).Where(w => w.Length < 5).OrderBy(w => w).Distinct().ToArray(); ;

           
            Console.WriteLine(string.Join(", ", input));

        }
    }
}
