using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Reverse_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            char first;
            char second;
            char third;
            //Your code goes here
            Console.WriteLine("Enter first charcter");
            first = Convert.ToChar(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Enter Second charcter");
            second = Convert.ToChar(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Enter Third charcter");
            third = Convert.ToChar(Console.ReadLine());

            Console.WriteLine();
            Console.Write(third + " " + second + " " + first);
        }
    }
}
