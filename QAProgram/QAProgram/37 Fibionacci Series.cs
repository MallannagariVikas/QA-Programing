using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAProgram
{
    class _37_Fibionacci_Series
    {
        public static void Main(string[] args)
        {
            int fno = 0;
            int sno = 1;
            int i;
            int j;
            int z = 0;
            int Nno = 0;

            Console.WriteLine("Input number of terms to display :  ");
            z = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Here is the Fibonacci series upto to 10 terms :");
            for (i = 1; i <= z; i++)
            {
                Console.Write(fno + " ");
                Nno = fno + sno;
                fno = sno;
                sno = Nno;

            }



        }
    }
}
