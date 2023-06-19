using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _01._DayOfWeek
{
    class Program
    {
        static void Main()
        {
            DateTime inputDate = DateTime.ParseExact(Console.ReadLine(),"d-M-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(inputDate.DayOfWeek);

        }
    }
}
