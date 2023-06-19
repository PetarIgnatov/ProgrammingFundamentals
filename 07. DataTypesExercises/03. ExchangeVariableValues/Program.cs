using System;

namespace _03._ExchangeVariableValues
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int temp = a;

            a = b;
            b = temp;

            Console.WriteLine(a);
            Console.WriteLine(b);

            
        }
    }
}
