using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int f = 1;
            int i;


            Console.WriteLine("Input the number :  ");
            x = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= x; i++)
            {
                f = f * i;
            }
            Console.WriteLine("The Factorial of " + x + " is: " + f);
        }
    }
}
