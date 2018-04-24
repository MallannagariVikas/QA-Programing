using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAProgram
{
    class _32_Perfect_Number
    {
        public static void Main(string[] args)
        {
            int number;
            int rem;
            int sum = 0;
            int i;

            Console.WriteLine("Enter a Number");
            number = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= (number - 1); i++)
            {
                rem = number % i;
                if (rem == 0)
                {
                    sum = sum + i;
                }
            }
            Console.Write("The positive divisors are: ");
            for (i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    Console.Write(i + " ");

                }
            }
            Console.WriteLine();
            Console.WriteLine("The sum of the divisor is :" + sum);
            if (sum == number)
                Console.WriteLine("Entered Number is perfect number");
            else
                Console.WriteLine("So, the number is not perfect.");


            Console.WriteLine();
        }
    }
}
