using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Valid_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            int z;
            int sum = 0;

            Console.WriteLine("Input the ANGLES : ");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            z = Convert.ToInt32(Console.ReadLine());
            //Your code goes here
            sum = x + y + z;
            if (sum == 180)
            {
                Console.WriteLine("Triangle is valid");
            }
            else
                Console.WriteLine("Triangle is not valid");
        }
    }
}
