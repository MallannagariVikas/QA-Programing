using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_RAT_number_increased_by_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int i;
            int j;
            int k = 1;

            Console.WriteLine("Enter height: ");
            x = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= x; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(k + " ");
                    k++;
                }
                Console.WriteLine();
            }
        }
    }
}
