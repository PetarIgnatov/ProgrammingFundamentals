using System;

namespace _01._Greeting
{
    class Program
    {
        static void Main()
        {

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
