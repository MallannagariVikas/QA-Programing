using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Of_days_in_month
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;

            Console.WriteLine("Enter the month number ");
            x = Convert.ToInt32(Console.ReadLine());

            if (x == 1 || x == 3 || x == 5 || x == 7 || x == 8 || x == 10 || x == 12)


                Console.WriteLine("Month have 31 days");
            else if (x == 2)
                Console.WriteLine("Month have 28 or 29 days");
            else
                Console.WriteLine("Month have 30 days");

        }
    }
}
