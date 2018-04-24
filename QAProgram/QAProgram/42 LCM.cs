using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAProgram
{
    class _42_LCM
    {
        public static void Main(string[] args)
        {
            int x;
            int y;
            int i;
            int j;
            int z = 0;
            int lcm = 0;

            Console.WriteLine("Input 1st number for LCM:  ");
            x = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Input 2nd number for LCM:  ");

            y = Convert.ToInt16(Console.ReadLine());

            for (i = 1; (i < x && i < y); i++)
            {
                if (x % i == 0 && y % i == 0)
                    z = i;
            }

            lcm = (x * y) / z;
            Console.WriteLine("The LCM of" + x + " and " + y + " is :" + lcm);

        }
    }
}
