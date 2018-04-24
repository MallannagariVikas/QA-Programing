using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAProgram
{
    class _36_Prime_Numbers_in_range
    {
        public static void Main(string[] args)
        {
            int x;
            int y;
            int i;
            int j;
            int flag = 0;

            Console.WriteLine("Input the numbers: ");
            x = Convert.ToInt16(Console.ReadLine());

            y = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("The prime number between" + x + "and " + y + "are :");
            x++;
            for (i = x; i <= y; i++)
            {
                flag = 0;
                for (j = 1; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        flag++;
                    }
                }
                if (flag <= 1)
                    Console.Write(i + " ");

            }



        }
    }
}
