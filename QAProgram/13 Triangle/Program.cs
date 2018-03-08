using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int i; int j; int x; int k;
            Console.WriteLine("Enter a number :");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the desired width :");
            k = Convert.ToInt32(Console.ReadLine());
            for (i = k; i >= 0; i--)
            {
                for (j = 0; j < i; j++)
                {
                    Console.Write(x);
                }
                Console.WriteLine();
            }


        }
    }
}
