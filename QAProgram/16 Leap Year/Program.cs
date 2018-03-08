using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Leap_Year
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;

            Console.WriteLine("Input the First Number : ");
            year = Convert.ToInt32(Console.ReadLine());

            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    // year is divisible by 400, hence the year is a leap year
                    if (year % 400 == 0)
                        Console.WriteLine(year + " is a leap year");
                    else
                        Console.WriteLine(year + " is not a leap year");
                }
                else
                    Console.WriteLine(year + " is a leap year");
            }
            else
                Console.WriteLine(year + " is not a leap year");


        }
    }
}
