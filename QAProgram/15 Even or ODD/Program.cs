using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Even_or_ODD
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;

            Console.WriteLine("Input the First Number : ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the Second Number : ");
            y = Convert.ToInt32(Console.ReadLine());

            //Your code goes here
            if (x % 2 == 0 && y % 2 == 0)
                Console.WriteLine("True");
            else if (x % 2 != 0 && y % 2 != 0)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
        }
    }
}
