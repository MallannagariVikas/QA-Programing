using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;

            for (i = 1; i < 100; i++)
            {
                if ((i % 2) != 0)

                    Console.WriteLine("\n" + i);
            }
    }
}
