using System;
using System.Linq;

namespace _07._ResizableArray
{
    class Program
    {
        static int[] numbers;
        static int currentIndex;
        static void Main()
        {
            string[] inputTokens = Console.ReadLine().Split(' ');
            numbers = new int[4];
            currentIndex = 0;

            while (inputTokens[0] != "end")
            {
                string command = inputTokens[0];
                 
                switch (command)
                {
                    case "push":
                        numbers[currentIndex] = int.Parse(inputTokens[1]);
                        currentIndex++;
                        int index = int.Parse(inputTokens[1]);
                        if (currentIndex >= numbers.Length)
                        {
                            GrowArray();
                        }
                        break;
                    case "pop":
                        numbers[currentIndex] = 0;
                        currentIndex--;
                        break;
                    case "removeAt":                       
                        Remove(int.Parse(inputTokens[1]));
                        currentIndex--;
                        break;
                    case "clear":
                        currentIndex = 0;
                        break;
                    default:
                        break;
                }

                inputTokens = Console.ReadLine().Split(' ');
            }


            PrintArray();

        }

        static void PrintArray()
        {
            if (currentIndex == 0)
            {
                Console.WriteLine("empty array");
            }
            for (int i = 0; i < currentIndex; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
        }

        static void GrowArray()
        {
            int[] nwArray = new int[currentIndex * 2];

            for (int i = 0; i < currentIndex; i++)
            {
                nwArray[i] = numbers[i];
            }

            numbers = nwArray;
        }

        static void Remove(int index)
        {
            for (int i = index + 1; i < currentIndex; i++)
            {
                numbers[i - 1] = numbers[i];
            }
        }
    }
}
