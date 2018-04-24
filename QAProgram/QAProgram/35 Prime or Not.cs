using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAProgram
{
    class _35_Prime_or_Not
    {
        public static void Main(string[] args)
        {
            //Your code goes here
            int x;
            int i;
            int flag = 0;


            Console.WriteLine("Input a number: ");
            x = Convert.ToInt32(Console.ReadLine());
            for (i = 2; i <= x; i++)
            {
                if (x % i == 0)
                    flag++;
            }

            if (flag == 1)

                Console.WriteLine(x + " is a Prime number");
            else
                Console.WriteLine("Not Prime number");
        }
    }
}
