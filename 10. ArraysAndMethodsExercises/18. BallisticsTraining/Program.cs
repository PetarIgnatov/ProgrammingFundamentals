using System;
using System.Linq;

namespace _18._BallisticsTraining
{
    class Program
    {
        static void Main()
        {
            int[] coordinates = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string[] commands = Console.ReadLine().Split(' ');
            int targetX = coordinates[0];
            int targetY = coordinates[1];
            int x = 0;
            int y = 0;



            for (int i = 0; i < commands.Length; i += 2)
            {

                if (commands[i] == "up")
                {
                    y += int.Parse(commands[i + 1]);
                }
                else if (commands[i] == "down")
                {
                    y -= int.Parse(commands[i + 1]);
                }
                else if (commands[i] == "left")
                {
                    x -= int.Parse(commands[i + 1]);
                }
                else if (commands[i] == "right")
                {
                    x += int.Parse(commands[i + 1]);
                }            
            }

            Console.WriteLine($"firing at [{x}, {y}]");

            if (targetX == x && targetY == y)
            {
                Console.WriteLine("got 'em!");
            }
            else
            {
                Console.WriteLine("better luck next time...");
            }
        }
    }
}






