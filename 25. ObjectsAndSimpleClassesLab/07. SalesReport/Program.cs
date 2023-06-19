using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._SalesReport
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

           //SortedDictionary<string, decimal> salesByTown = new SortedDictionary<string, decimal>();

            List<Sale> sales = new List<Sale>();
            Sale input = Sale.ReadSale(Console.ReadLine());
            sales.Add(input);

            //for (int i = 0; i < n; i++)
            //{
            //    //if (!salesByTown.ContainsKey(inputList.Town))
            //    //{
            //    //    salesByTown[inputList.Town] = new decimal();
            //    //}

            //    //salesByTown[inputList.Town] += inputList.Quantity * inputList.Price;
           // }

            List<string> towns = sales.Select(t => t.Town).Distinct().OrderBy(t => t).ToList();

            foreach (var town in towns)
            {
                decimal currentSum = sales.Where(s => s.Town == town).Select(s => s.Price * s.Quantity).Sum();
                Console.WriteLine($"{town} -> {currentSum:f2}");
            }
        }
    }

    class Sale
    {
        public Sale(string v1, string v2, decimal v3, decimal v4)
        {
            Town = v1;
            Product = v2;
            Price = v3;
            Quantity = v4;
        }

        public string Town { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }

        public static Sale ReadSale(string input)
        {
            string[] inputData = input.Split(' ').ToArray();

            return new Sale(inputData[0], inputData[1], decimal.Parse(inputData[2]), decimal.Parse(inputData[3]));
        }
    }
}
