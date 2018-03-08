using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Multiply
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int C;

            a = Convert.ToInt32(Console.ReadLine());

            b = Convert.ToInt32(Console.ReadLine());

            C = Convert.ToInt32(Console.ReadLine());

            int d = a * b * C;

            Console.WriteLine(d);


        }
    }
}
