using System;

namespace _02._MinMethod
{
    class Program
    {
        static void Main()
        {

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int minNum = GetMin(num1, num2);

            //Console.WriteLine(GetMin(num1, GetMin(num2, num3)));

            if (minNum < num3)
            {
                Console.WriteLine(minNum);
            }
            else
            {
                Console.WriteLine(num3);
            }
        }

        static int GetMin(int num1, int num2)
        {
            if (num1 < num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }
    }
}
