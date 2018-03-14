using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];
            int i;
            float sum = 0;
            float avg = 0F;
            Console.WriteLine("Input the 10 numbers :");

            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Number-" + i + ":");
                //Storing value in an array
                num[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < num.Length; i++)
            {
                sum = sum + num[i];
            }

            avg = sum / 10;
            Console.WriteLine("The sum of 10 no is :" + sum);
            Console.WriteLine("The Average is : " + avg);

        }
    }
}
