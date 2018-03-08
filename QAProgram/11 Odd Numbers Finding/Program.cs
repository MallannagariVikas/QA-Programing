using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Odd_Numbers_Finding
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] num=new int[5];
            //Taking array elemenst directly
            int[] num = new int[5] { 0, 2, 6, 4, 8 };
            int i;
            int flag = 0;
            //For taking array elements from users use the below code
            /* for (i = 0; i < 5; i++)
             {
                 Console.Write("\nEnter your number:\t");
                 //Storing value in an array
                 num[i] = Convert.ToInt32(Console.ReadLine());
             }*/

            for (i = 0; i < num.Length; i++)
            {
                if (num[i] % 2 != 0)
                    flag++;
            }
            if (flag != 0)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");

        }
    }
}
