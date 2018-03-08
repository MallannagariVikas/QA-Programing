using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Sum_of_digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num; //169
            int rem = 0;

            Num = (Convert.ToInt32(Console.ReadLine()));

            bool loop = true;

            while (loop)
            {
                rem += Num % 10; //9 //6 //1
                Num = Num / 10; //16  //1 //0
                if (Num == 0)
                {
                    break;
                }
            }

            Console.WriteLine(" rem : {0}", rem);

        }
    }
}
