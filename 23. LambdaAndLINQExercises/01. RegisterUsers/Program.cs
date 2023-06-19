using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._RegisterUsers
{
    class Record
    {
        public int id;
        public DateTime date;

        public Record(int id, DateTime date)
        {
            this.id = id;
            this.date = date;
        }
    }
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var result = new Dictionary<string, Record>();
            int id = 0;
            while (input[0] != "end")
            {
                string name = input[0];
                DateTime date = DateTime.ParseExact(input[1], "dd/MM/yyyy", null);

                result.Add(name, new Record(id++, date));

                input = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();           
            }

            var orderedData = result
                .OrderBy(r => r.Value.date)
                .ThenByDescending(r => r.Value.id)
                .Take(5)
                .OrderByDescending(r => r.Value.date);

            foreach (var record in orderedData)
            {
                Console.WriteLine(record.Key);
            }
        }
    }
}
