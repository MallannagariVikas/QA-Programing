using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAProgram
{
    class _40_Sum_Of_All_Integers
    {
        public static void Main(string[] args)
        {
            int x;
            int y;
            int i;
            int j;
            int sum = 0;


            Console.WriteLine("Input 1st number :");
            x = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Input 2nd number :  ");

            y = Convert.ToInt16(Console.ReadLine());

            for (i = x; i <= y; i++)
            {
                if (i % 9 == 0)
                {
                    sum = sum + i;
                    Console.Write(i + " ");
                }


            }
            Console.WriteLine();
            Console.Write("The sum: " + sum);
        }
    }
}
