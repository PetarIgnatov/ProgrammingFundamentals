using System;

namespace _08._SMSTyping
{
    class Program
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            string print = string.Empty;
            for (int i = 0; i < count; i++)
            {
                string currentInput = Console.ReadLine();
                int currentDigit = 0;

                if (currentInput.Length > 0)
                {
                    currentDigit = currentInput[0] - '0';
                }

                char characterToPrint;

                if (currentDigit == 0)
                {
                    print += " ";

                }
                else if (currentDigit == 8 || currentDigit == 9)
                {
                    characterToPrint = (char)((((currentDigit - 2) * 3) + 1) + (currentInput.Length - 1));
                    characterToPrint += 'a';
                    print += characterToPrint;
                }
                else
                {
                    characterToPrint = (char)(((currentDigit - 2) * 3) + (currentInput.Length - 1));
                    characterToPrint += 'a';
                    print += characterToPrint;
                }

            }

            Console.WriteLine(print);
        }
    }
}

//7
//6
//33
//33
//8
//0
//6
//33
