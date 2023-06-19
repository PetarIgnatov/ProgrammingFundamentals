using System;

namespace _04._Phone
{
    class Program
    {
        static void Main()
        {
            string[] numbers = Console.ReadLine().Split(' ');
            string[] names = Console.ReadLine().Split(' ');

            string[] inputNameOrNumber = Console.ReadLine().Split(' ');
            int sumOfDigit = 0;

            int[] sumOfNums = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                string currentNum = numbers[i];

                for (int a = 0; a < currentNum.Length; a++)
                {

                    if (IsDigit(currentNum[a]))
                    {
                        sumOfDigit += currentNum[a] - '0';
                    }
                }

                sumOfNums[i] = sumOfDigit;
                sumOfDigit = 0;
            }



            while (inputNameOrNumber[0] != "done")
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (inputNameOrNumber[0] == "call")
                    {
                        if (inputNameOrNumber[1] == names[i])
                        {
                            Console.WriteLine($"calling {numbers[i]}...");

                            if (IsSumIsOdd(sumOfNums[i]))
                            {
                                Console.WriteLine("no answer");
                            }
                            else
                            {
                                Console.WriteLine($"call ended. duration: {0}{sumOfNums[i] / 60}:{sumOfNums[i] % 60}");
                            }
                        }

                        else if (inputNameOrNumber[1] == numbers[i])
                        {
                            Console.WriteLine($"calling {names[i]}...");

                            if (IsSumIsOdd(sumOfNums[i]))
                            {
                                Console.WriteLine("no answer");

                            }
                            else
                            {
                                Console.WriteLine($"call ended. duration: {0}{sumOfNums[i] / 60}:{sumOfNums[i] % 60}");
                            }

                        }
                    }

                    else
                    {
                        if (inputNameOrNumber[1] == names[i])
                        {
                            Console.WriteLine($"sending sms to {numbers[i]}...");
                            if (IsSumIsOdd(sumOfNums[i]))
                            {
                                Console.WriteLine("busy");
                            }
                            else
                            {
                                Console.WriteLine("meet me there");
                            }
                        }

                        else if (inputNameOrNumber[1] == numbers[i])
                        {
                            Console.WriteLine($"sending sms to {names[i]}...");

                            if (IsSumIsOdd(sumOfNums[i]))
                            {
                                Console.WriteLine("busy");
                            }
                            else
                            {
                                Console.WriteLine("meet me there");
                            }
                        }
                    }

                }

                inputNameOrNumber = Console.ReadLine().Split(' ');
            }

        }

        static bool IsSumIsOdd(int sumOfNums)
        {
            return sumOfNums % 2 == 1;
        }

        static bool IsDigit(char currentNum)
        {
            return (currentNum >= '0' && currentNum <= '9');
        }

    }
}

