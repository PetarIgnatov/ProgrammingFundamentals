using System;

namespace _14._Calculator
{
    class Program
    {
        static void Main()
        {
            int firtsNum = int.Parse(Console.ReadLine());
            char operand = char.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            switch (operand)
            {
                case '+':
                    Console.WriteLine($"{firtsNum} + {secondNum} = {firtsNum + secondNum}");
                    break;
                case '-':
                    Console.WriteLine($"{firtsNum} - {secondNum} = {firtsNum - secondNum}");
                    break;
                case '*':
                    Console.WriteLine($"{firtsNum} * {secondNum} = {firtsNum * secondNum}");
                    break;
                case '/':
                    Console.WriteLine($"{firtsNum} / {secondNum} = {firtsNum / secondNum}");
                    break;
                default:
                    break;
            }
        }
    }
}
