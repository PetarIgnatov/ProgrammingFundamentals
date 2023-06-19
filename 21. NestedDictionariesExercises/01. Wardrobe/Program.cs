using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Wardrobe
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, int>> result = new Dictionary<string, Dictionary<string, int>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string color = input[0];
                string[] clothes = input[1].Split(',').ToArray();

                if (!result.ContainsKey(color))
                {
                    result[color] = new Dictionary<string, int>();
                }

                //foreach (string cloth in clothes)
                //{
                //    Dictionary<string, int> clothDb = result[color];
                //    if (!clothDb.ContainsKey(cloth))
                //    {
                //        clothDb.Add(cloth,0);
                //    }
                //    clothDb[cloth]++;
                //}

                for (int a = 0; a < clothes.Length; a++)
                {
                    if (!result[color].ContainsKey(clothes[a]))
                    {
                        result[color][clothes[a]] = new int();
                    }
                    result[color][clothes[a]] += 1;
                }
            }

            string[] colorToFind = Console.ReadLine().Split(' ');

            foreach (KeyValuePair<string, Dictionary<string, int>> color in result)
            {
                Console.WriteLine($"{color.Key} clothes:");

                var clothes = color.Value;

                foreach (var cloth in clothes)
                {
                    if (cloth.Key == colorToFind[1] && color.Key == colorToFind[0])
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value}");
                    }
                }
            }
        }
    }
}
