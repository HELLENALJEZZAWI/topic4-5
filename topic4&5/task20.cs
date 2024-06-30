using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace topic4_5
{
    internal class task20
    {
       

class Program
    {
        static void Main()
        {
            int startYear = 1900;
            int endYear = 2024;

            Console.WriteLine("Leap years between 1900 and 2024:");

            for (int year = startYear; year <= endYear; year++)
            {
                if (IsLeapYear(year))
                {
                    Console.WriteLine(year);
                }
            }
        }

        static bool IsLeapYear(int year)
        {
            return (year % 4 == 0) && ((year % 100 != 0) || (year % 400 == 0));
        }
    }

}
}
