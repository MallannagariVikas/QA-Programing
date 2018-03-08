using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Triple_Of_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int FirstNumber;
            int SecondNumber;
            int Result;

            FirstNumber = Convert.ToInt32(Console.ReadLine());
            SecondNumber = Convert.ToInt32(Console.ReadLine());

            if (FirstNumber == SecondNumber)
            {
                Result = 3 * (FirstNumber + SecondNumber);
                Console.WriteLine(Result);
            }
            else
            {
                Result = (FirstNumber + SecondNumber);
                Console.WriteLine(Result);
            }

        }
    }
}
