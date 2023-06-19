using System;

namespace _10._DataOverflow
{
    class Program
    {
        static void Main()
        {
            ulong firstNum = ulong.Parse(Console.ReadLine());
            ulong secondNum = ulong.Parse(Console.ReadLine());

            string maxType = string.Empty;
            string minType = string.Empty;

            decimal maxNum = Math.Max(firstNum,secondNum);
            decimal minNum = Math.Min(firstNum, secondNum);

            decimal overflow = 0;

            if (maxNum <= byte.MaxValue)
            {
                maxType = "byte";
                
            }
            else if (maxNum <= ushort.MaxValue)
            {
                maxType = "ushort";
                
            }
            else if (maxNum <= uint.MaxValue)
            {
                maxType = "uint";
            }
            else
            {
                maxType = "ulong";
            }

            if (minNum <= byte.MaxValue)
            {
                minType = "byte";
                overflow = maxNum / byte.MaxValue;
            }
            else if (minNum <= ushort.MaxValue)
            {
                minType = "ushort";
                overflow = maxNum / ushort.MaxValue;
            }
            else if (minNum <= uint.MaxValue)
            {
                minType = "uint";
                overflow = maxNum / uint.MaxValue;

            }
            else
            {   
                minType = "ulong";
                overflow = maxNum / ulong.MaxValue;

            }

            Console.WriteLine($"bigger type: {maxType}");
            Console.WriteLine($"smaller type: {minType}");
            Console.WriteLine($"{maxNum} can overflow {minType} {Math.Round(overflow)} times");




        }
    }
}
