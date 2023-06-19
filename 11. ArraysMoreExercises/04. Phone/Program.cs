using System;

namespace _04._Phone
{
    class Program
    {
        static string[] numbers;
        static string[] names;
        static void Main()
        {
            numbers = Console.ReadLine().Split(' ');
            names = Console.ReadLine().Split(' ');
            string[] inputNameOrNumber = Console.ReadLine().Split(' ');
            while (inputNameOrNumber[0] != "done")
            {

                string command = inputNameOrNumber[0];
                string argument = inputNameOrNumber[1];
                string name;
                string number;
                string output;

                if (IsNumber(argument))
                {
                    name = GetEntry(argument);
                    number = argument;
                    output = name;
                }
                else
                {
                    name = argument;
                    number = GetEntry(argument);
                    output = number;
                }

                int digitSum = GetDigitSum(number);
                if (command == "call")
                {
                    Console.WriteLine($"calling {output}...");
                    if (IsOddSum(digitSum))
                    {
                        Console.WriteLine("no answer");
                    }
                    else
                    {
                        int minutes = digitSum / 60;
                        int seconds = digitSum % 60;
                        Console.WriteLine($"call ended. duration: {minutes:d2}:{seconds:d2}");
                    }
                }
                else if (command == "message")
                {
                    Console.WriteLine($"sending sms to {output}...");
                    if (IsOddSum(digitSum))
                    {
                        Console.WriteLine("busy");
                    }
                    else
                    {
                        Console.WriteLine("meet me there");
                    }
                }

                inputNameOrNumber = Console.ReadLine().Split(' ');
            }    
        }

        static bool IsOddSum(int digitSum)
        {
            return digitSum % 2 == 1;
        }

        static int GetDigitSum(string telephoneNumber)
        {
            int sum = 0;
            for (int i = 0; i < telephoneNumber.Length; i++)
            {
                if (IsDigit(telephoneNumber[i]))
                {
                    sum += telephoneNumber[i] - '0';
                }
            }
            return sum;
        }

        static string GetEntry(string input)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (names[i] == input)
                {
                    return numbers[i];
                }
                else if (numbers[i] == input)
                {
                    return names[i];
                }
            }

            return string.Empty;
        }

        static bool IsNumber(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (IsDigit(input[i]))
                {
                    return true;
                }
            }
            return false;
        }

        static bool IsDigit(char symbol)
        {
            return (symbol >= '0' && symbol <= '9');
        }
    }
}

