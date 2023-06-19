using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._RabbitHole
{
    class Program
    {
        static List<string> input;
        static void Main()
        {
            input = Console.ReadLine().Split(' ').ToList();
            int energy = int.Parse(Console.ReadLine());
            int position = 0;

            while(energy > 0)
            { 
                string[] tokens = input[position].Split('|');
                string direction = tokens[0];
                int value = 0;

                if (direction == "RabbitHole")
                {
                    Console.WriteLine("You have 5 years to save Kennedy!");
                    return;
                }

                else if (direction == "Left")
                {
                    value = int.Parse(tokens[1]);
                    position = Math.Abs(position - value) % input.Count;
                    energy -= value;

                    if (EnergyIsGone(energy))
                    {
                        return;
                    }
                }
                else if (direction == "Right")
                {
                    value = int.Parse(tokens[1]);
                    position = (position + value) % input.Count;
                    energy -= value;

                    if (EnergyIsGone(energy))
                    {
                        return;
                    }
                }
                else if (direction == "Bomb")
                {
                    value = int.Parse(tokens[1]);
                    energy -= value;
                    input.RemoveAt(position);
                    position = 0;

                    if (energy <= 0)
                    {
                        Console.WriteLine("You are dead due to bomb explosion!");
                        return;
                    }
                }

                if (input[input.Count - 1] != "RabbitHole")
                {
                    input.RemoveAt(input.Count - 1);
                }

                input.Add("Bomb|" + energy);
            }
        }

        static bool EnergyIsGone(int energy)
        {
            if (energy <= 0)
            {
                Console.WriteLine("You are tired. You can't continue the mission.");
                return true;
            }

            return false;
        }
    }
}
