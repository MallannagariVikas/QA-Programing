using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_largest_and_lowest
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter Values for A B and C=");
            a = (Convert.ToInt32(Console.ReadLine()));
            b = (Convert.ToInt32(Console.ReadLine()));
            c = (Convert.ToInt32(Console.ReadLine()));
            if (a > b && a > c)
            {
                Console.WriteLine("Maximum Of A B C is ");
                Console.WriteLine(a);

            }
            else if (b > a && b > c)
            {
                Console.WriteLine("Maximum Of A B C is ");
                Console.WriteLine(b);

            }
            else if (c > a && c > b)
            {
                Console.WriteLine("Maximum Of A B C is ");
                Console.WriteLine(c);

            }

            if (a < b && a < c)
            {
                Console.WriteLine("Minimum Of A B C is ");
                Console.WriteLine(a);

            }
            else if (b < a && b < c)
            {
                Console.WriteLine("Minimum Of A B C is ");
                Console.WriteLine(b);

            }
            else if (c < a && c < b)
            {
                Console.WriteLine("Minimum Of A B C is ");
                Console.WriteLine(c);

            }

        }
    }
}
