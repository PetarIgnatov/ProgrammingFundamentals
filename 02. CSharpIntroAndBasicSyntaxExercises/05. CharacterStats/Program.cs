using System;

namespace _05._CharacterStats
{
    class Program
    {
        static void Main()
        {
            string name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            int leftHealth = maxHealth - currentHealth;
            int leftEnergy = maxEnergy - currentEnergy;

            Console.WriteLine($"Name: {name}");
            Console.WriteLine("Health: |" + new string('|', currentHealth) + new string('.',leftHealth) + "|");
            Console.WriteLine("Energy: |" + new string('|', currentEnergy) + new string('.',leftEnergy) + "|");
        }
    }
}

