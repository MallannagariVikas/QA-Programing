using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_SumOfArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, sum = 0;
            Console.WriteLine("Arraysize=");
            n = (Convert.ToInt32(Console.ReadLine()));
            int[] a = new int[n];
            Console.WriteLine("values of Array=");
            for (int i = 0; i < n; i++)
            {
                a[i] = (Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine("Sum Of All ");
            for (int i = 0; i < n; i++)
            {
                sum = sum + a[i];
            }
            Console.WriteLine(sum);

        }
    }
}
