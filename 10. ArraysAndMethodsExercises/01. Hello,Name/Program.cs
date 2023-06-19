using System;

namespace _01._Hello_Name
{
    class Program
    {
        static void Main()
        {
            string name = Console.ReadLine();

            SayHello(name);
        }

         static void SayHello(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
