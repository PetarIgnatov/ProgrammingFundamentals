using System;

namespace _03._Phonebook
{
    class Program
    { string[] numbers = Console.ReadLine().Split(' ');
            string[] names = Console.ReadLine().Split(' ');

            string inputName = Console.ReadLine();

            while (inputName != "done")
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (inputName == names[i])
                    {
                        Console.WriteLine($"{inputName} -> {numbers[i]}");
                    }
                }

                inputName = Console.ReadLine();
            }

        }
    }
}

        static void Main()
        {
           