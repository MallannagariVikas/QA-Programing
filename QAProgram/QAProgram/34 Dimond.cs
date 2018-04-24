using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAProgram
{
    class _34_Dimond
    {
        public static void Main(string[] args)
        {
            int x;
            int i;
            int j;
            int k = 1;

            Console.WriteLine("Enter height: ");
            x = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= x; i++)
            {
                for (j = 1; j <= x - i; j++)
                    Console.Write(" ");
                if (i % 2 != 0)
                {
                    for (j = 1; j <= i; j++)
                    {
                        Console.Write("* ");
                        // Console.Write(k+" ");
                        //k++;

                    }
                }
                if (i != 10)
                    Console.WriteLine();
            }

            for (i = x - 2; i > 0; i--)
            {
                for (j = 1; j <= x - i; j++)
                    Console.Write(" ");
                if (i % 2 != 0)
                {
                    for (j = 1; j <= i; j++)
                    {
                        Console.Write("* ");
                        // Console.Write(k+" ");
                        //k++;

                    }
                }
                Console.WriteLine();
            }
        }
    }
}
