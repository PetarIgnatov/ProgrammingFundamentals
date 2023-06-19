using System;
using System.Linq;

namespace _04._JapaneseRoulette
{
    class Program
    {
        static void Main()
        {
            int[] bullets = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool isDead = false;
            string[] players = Console.ReadLine().Split(' ');
            int indexBullet = 0;

            for (int i = 0; i < bullets.Length; i++)
            {
                if (bullets[i] == 1)
                {
                    indexBullet = i;
                    break;
                }
            }

            for (int i = 0; i < players.Length; i++)
            {
                string[] tokens = players[i].Split(',');
                int power = int.Parse(tokens[0]);
                string direction = tokens[1];

                switch (direction)
                {
                    case "Right":
                        indexBullet = (indexBullet + power) % bullets.Length;
                        break;
                    case "Left":
                        if (indexBullet - power < 0)
                        {
                            indexBullet = bullets.Length - (Math.Abs(indexBullet - power)) % bullets.Length;
                        }
                        else
                        {
                            indexBullet = indexBullet - power;
                        }

                        break;

                }

                if (indexBullet == 2)
                {
                    Console.WriteLine($"Game over! Player {i} is dead.");
                    isDead = true;
                    break;
                }

                indexBullet = indexBullet + 1 == bullets.Length ? 0 : indexBullet + 1;
            }

            if (!isDead)
            {
                Console.WriteLine("Everybody got lucky!");
            }

        }
    }
}
