using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Mult_Table
{
    class Program
    {
        static void Main(string[] args)
        {

            int i;
            int j;
            int K;


            j = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i <= 10; i++)
            {
                K = j * i;

                Console.WriteLine(String.Format("{0}*{1}={2}", j, i, K));

            }
        }
        }
}
