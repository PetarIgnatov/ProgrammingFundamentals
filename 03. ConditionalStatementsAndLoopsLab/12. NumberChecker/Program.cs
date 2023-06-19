using System;

namespace _12._NumberChecker
{
    class Program
    {
        static void Main()
        {


            try
            {
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine("It is a number.");
            }
            catch (Exception)
            {

                Console.WriteLine("Invalid input!");
            }
        }
    }
}
