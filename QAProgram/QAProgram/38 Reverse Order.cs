using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAProgram
{
    class _38_Reverse_Order
    {
        public static void Main(string[] args)
        {
          
            int x;
            int y;
            int r;
            int j;
            int rev = 0;

            Console.WriteLine("Input a number: ");
            x = Convert.ToInt16(Console.ReadLine());
            while (x > 0)
            {
                r = x % 10;
                rev = rev * 10 + r;
                x = x / 10;
            }

            Console.WriteLine("The number in reverse order is :" + rev);

        }
    }
}
