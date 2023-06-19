using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._LambadaExpressions
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, string>> data = new Dictionary<string, Dictionary<string, string>>();
            string[] input = Console.ReadLine().Split(new char[] { '=', '>', ' ', '.' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            while (input[0] != "lambada")
            {
                string selector = input[0];

                if (selector == "dance")
                {
                    data = data
                        .ToDictionary(a => a.Key, a => a.Value.ToDictionary(b => b.Key, b => b.Key + "." + b.Value));

                    // var selectors = data.Keys.ToList();
                    //foreach (var select in selectors)
                    //{
                    //    var selectorObjects = data[select].Keys.ToList();
                    //    foreach (var selectorObject in selectorObjects)
                    //    {
                    //        data[select][selectorObject] =
                    //            selectorObject + "." + data[select][selectorObject];
                    //    }

                }

                else
                {
                    string selectorObject = input[1];
                    string property = input[2];

                    if (!data.ContainsKey(selector))
                    {
                        data[selector] = new Dictionary<string, string>();
                    }

                    data[selector][selectorObject] = property;
                }

                input = Console.ReadLine().Split(new char[] { '=', '>', ' ', '.' },
                    StringSplitOptions.RemoveEmptyEntries).ToArray();
            }

            foreach (var item in data)
            {
                string selector = item.Key;
                var selectorsObjectData = item.Value;

                foreach (var selectorObject in selectorsObjectData)
                {
                    string selectorsObject = selectorObject.Key;
                    string property = selectorObject.Value;

                    Console.WriteLine($"{selector} => {selectorsObject}.{property}");
                }
            }

        }
    }
}
