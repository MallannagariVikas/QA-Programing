using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAProgram
{
    class _33_Armstrong_number
    {
        public static void Main(string[] args)
        {
          
            int x;
            int r;
            int s = 0;
            int y;
            int n = 0;

            Console.WriteLine("Input a number: ");
            //x=Console.ReadLine();
            x = Convert.ToInt16(Console.ReadLine());
            y = x;


            while (x > 0)
            {
                r = x % 10;
                s = (r * r * r) + s;
                // Math.pow
                x = x / 10;
            }

            if (s == y)
                Console.WriteLine(y + " is an Armstrong number.");
            else
                Console.WriteLine(y + " is not an Armstrong number.");

        }
    }
}
