using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_Sum_of_10_natural_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int sum = 0;
            for (i = 1; i <= 10; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine("The first 10 natural number is :");
            for (i = 1; i <= 10; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("The Sum is : " + sum);
        }
    }
}
