using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAProgram
{
    class Floyds_Triangle
    {
        public class Program
        {
            public static void Main(string[] args)
            {
                int z;
                int i;
                int j;
                int x = 0;

                Console.WriteLine("Input number of terms to display :  ");
                z = Convert.ToInt16(Console.ReadLine());

                for (i = 1; i < z; i++)
                {

                    for (j = 0; j < i; j++)
                    {
                        if ((i + j) % 2 == 0)
                        {
                            Console.Write("0");
                        }
                        else
                        {
                            Console.Write("1");
                        }

                    }

                    Console.WriteLine();
                }


            }
        }
    }
}
