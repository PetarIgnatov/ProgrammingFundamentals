using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._MostValuedCustomer
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            Dictionary<string, double> productData = new Dictionary<string, double>();
            Dictionary<string, List<string>> personalData = new Dictionary<string, List<string>>();

            while (input[0] != "Shop")
            {
                string product = input[0];
                double price = double.Parse(input[1]);

                if (!productData.ContainsKey(product))
                {
                    productData[product] = price;
                }

                input = Console.ReadLine().Split(' ');
            }

            input = Console.ReadLine().Split(new char[] { ' ', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "Print")
            {
                string person = input[0];

                if (person == "Discount")
                {
                    Dictionary<string, double> discountedProducts = productData.OrderByDescending(a => a.Value).Take(3).ToDictionary(r => r.Key, r => r.Value * 0.90);

                    foreach (var discountedProduct in discountedProducts)
                    {
                        productData[discountedProduct.Key] = discountedProduct.Value;
                    }
                }

                else
                {
                    if (!personalData.ContainsKey(person))
                    {
                        personalData[person] = new List<string>();
                    }
                    for (int i = 1; i < input.Length; i++)
                    {
                        if (productData.ContainsKey(input[i]))
                        {
                            personalData[person].Add(input[i]);
                        }
                    }
                }

                input = Console.ReadLine().Split(new char[] { ' ', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);
            }

            var topCustumer = personalData.OrderByDescending(a => a.Value.Sum(a => productData[a])).First();
            var total = topCustumer.Value.Sum(a => productData[a]);
            var productsBought = topCustumer.Value.Distinct().OrderByDescending(a => productData[a]);


            Console.WriteLine($"Biggest spender: {topCustumer.Key}");
            Console.WriteLine("^Products bought:");

            foreach (var item in productsBought)
            {
                Console.WriteLine($"^^^{item}: {productData[item]:f2}");
            }

            Console.WriteLine($"Total: {total:f2}");
        }
    }
}
