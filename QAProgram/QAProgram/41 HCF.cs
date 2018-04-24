using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAProgram
{
    class _41_HCF
    {
        public static void Main(string[] args)
        {
            int x;
            int y;
            int i;
            int j;
            int z = 0;

            Console.WriteLine("Input 1st number for HCF:  ");
            x = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Input 2nd number for HCF:  ");

            y = Convert.ToInt16(Console.ReadLine());

            for (i = 1; (i < x && i < y); i++)
            {
                if (x % i == 0 && y % i == 0)
                    z = i;
            }
            Console.WriteLine("HCF of " + x + " and " + y + " is :" + z);
        }
    }
}
