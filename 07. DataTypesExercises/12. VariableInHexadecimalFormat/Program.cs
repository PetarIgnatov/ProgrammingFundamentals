using System;

namespace _12._VariableInHexadecimalFormat
{
    class Program
    {
        static void Main()
        {
            string form = "0xFE";

            Console.WriteLine(Convert.ToInt32(form, 16));
        }
    }
}
