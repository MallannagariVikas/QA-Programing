using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAProgram
{
    class _39_Palindrome
    {
        public static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            int r;
            int j;
            int rev = 0;

            Console.WriteLine("Input a number: ");
            x = Convert.ToInt16(Console.ReadLine());
            j = x;
            while (x > 0)
            {
                r = x % 10;
                rev = rev * 10 + r;
                x = x / 10;
            }

            if (rev == j)
            {

                Console.WriteLine(j + " is a palindrome number.");
            }
            else
                Console.WriteLine(j + " is not a palindrome number.");
        }
    }
}
