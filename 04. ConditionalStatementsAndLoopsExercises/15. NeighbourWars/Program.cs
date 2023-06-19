using System;

namespace _15._NeighbourWars
{
    class Program
    {
        static void Main()
        {
            int peshoDamage = int.Parse(Console.ReadLine());
            int goshoDamage = int.Parse(Console.ReadLine());
            int peshoHealth = 100;
            int goshoHealth = 100;
            int numberOfround = 1;

            while (true)
            {
                if (numberOfround % 2 == 0)
                {
                    peshoHealth -= goshoDamage;
                    if (peshoHealth > 0)
                    {
                        Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHealth} health.");
                    }
                    else
                    {
                        Console.WriteLine($"Gosho won in {numberOfround}th round.");
                        break;
                    }

                }

                else
                {
                    goshoHealth -= peshoDamage;
                    if (goshoHealth > 0)
                    {
                        Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHealth} health.");
                    }
                    else
                    {
                        Console.WriteLine($"Pesho won in {numberOfround}th round.");
                        break;
                    }

                }

                if (numberOfround % 3 == 0)
                {
                    goshoHealth += 10;
                    peshoHealth += 10;
                }

                numberOfround++;

            }


        }
    }
}
