using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Arthametic_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            int temp;
            char u;
            Console.WriteLine("Input the First Number : ");
            x = Convert.ToInt32(Console.ReadLine());

        start:
            Console.WriteLine("Input the Opeartor : ");
            u = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Input the Second Number : ");
            y = Convert.ToInt32(Console.ReadLine());


            /* if(u=='/')
             {
                 if(y==0)
                     Console.WriteLine("Not a valid number for division please enter second number other than zero");
                 else 
                     goto start;
             }*/


            switch (u)
            {
                case '+':
                    Console.WriteLine(x + "+" + y + "=" + (x + y));
                    break;

                case '-':
                    Console.WriteLine(x + "-" + y + "=" + (x - y));
                    break;

                case '*':
                    Console.WriteLine(x + "*" + y + "=" + (x * y));
                    break;

                case '/':
                    if (y == 0)
                        Console.WriteLine("Not a valid number for division please enter second number other than zero");

                    Console.WriteLine(x + "/" + y + "=" + (x / y));
                    break;

                default:
                    Console.WriteLine("Enter correct option");
                    break;


            }

        }
    }
}
