using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_Natural_numbers_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];
            int i;
            int x;
            int sum = 0;
            Console.WriteLine("Input number of terms:");
            x = Convert.ToInt32(Console.ReadLine());


            for (i = 0; i < (2 * x); i++)
            {
                if (i % 2 != 0)
                {
                    sum = sum + i;
                }


            }

            Console.Write("The odd numbers are :");
            for (i = 0; i < (2 * x); i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + " ");
                }


            }
            Console.WriteLine();
            Console.WriteLine("The Sum of odd Natural Number upto " + x + " terms :" + sum);
        }
    }
}
