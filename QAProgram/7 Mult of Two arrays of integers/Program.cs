using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Mult_of_Two_arrays_of_integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Arraysize=");
            n = (Convert.ToInt32(Console.ReadLine()));
            int[] a = new int[n];
            int[] b = new int[n];
            Console.WriteLine("values of A=");
            for (int i = 0; i < n; i++)
            {
                a[i] = (Convert.ToInt32(Console.ReadLine()));

            }

            Console.WriteLine("values of B=");
            for (int i = 0; i < n; i++)
            {
                b[i] = (Convert.ToInt32(Console.ReadLine()));

            }

            Console.WriteLine("a*b=");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(a[i] * b[i]);

            }

        }
    }
}
