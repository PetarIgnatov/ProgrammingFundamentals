using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._OrderedBankingSystem
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, decimal>> data = new Dictionary<string, Dictionary<string, decimal>>();
            string[] input = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            while (input[0] != "end")
            {
                string bank = input[0];
                string account = input[1];
                decimal balance = decimal.Parse(input[2]);

                if (!data.ContainsKey(bank))
                {
                    data[bank] = new Dictionary<string, decimal>();
                }

                if (!data[bank].ContainsKey(account))
                {
                    data[bank][account] = new decimal();
                }

                data[bank][account] += balance;

                input = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            }

            var orderedData = data.OrderByDescending(a => a.Value.Sum(b => b.Value))
                .ThenByDescending(a => a.Value.Max(b => b.Value));

            foreach (var item in orderedData)
            {
                var accountsData = item.Value;

                foreach (var account in accountsData.OrderByDescending(a => a.Value))
                {
                    Console.WriteLine($"{account.Key} -> {account.Value} ({item.Key})");
                }

            }
        }
    }
}
