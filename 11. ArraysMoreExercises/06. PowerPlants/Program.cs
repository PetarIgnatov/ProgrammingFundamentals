using System;
using System.Linq;

namespace _06._PowerPlants
{
    class Program
    {
        static void Main()
        {
            int[] plantlives = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int daysCount = 0;
            int daysInSeason = plantlives.Length;
            while (AreAnyPlantsAlive(plantlives))
            {
                for (int i = 0; i < plantlives.Length; i++)
                {
                    if (plantlives[i] > 0)
                    {
                        if (daysCount % daysInSeason != i)
                        {
                            plantlives[i]--;
                        }
                    }
                }

                daysCount++;

                if (daysCount % daysInSeason == 0)
                {
                    for (int i = 0; i < plantlives.Length; i++)
                    {
                        if (plantlives[i] > 0)
                        {
                            plantlives[i]++;
                        }
                    }
                }
            }
            int totalSeasons = ((daysCount - 1) / daysInSeason);

            string season = "season";

            if (totalSeasons != 1)
            {
                season = "seasons";
            }

            Console.WriteLine($"survived {daysCount} days ({totalSeasons} {season})");

        }
        static bool AreAnyPlantsAlive(int[] plantLive)
        {
            for (int i = 0; i < plantLive.Length; i++)
            {
                if (plantLive[i] > 0)
                {
                    return true;
                }
            }

            return false;
        }

    }
}