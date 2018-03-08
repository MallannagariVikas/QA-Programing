using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Vowels
{
    class Program
    {
        static void Main(string[] args)
        {
            char ft;

            //Your code goes here
            Console.WriteLine("Enter first charcter");
            ft = Convert.ToChar(Console.ReadLine());

            if (ft == 'a' || ft == 'e' || ft == 'i' || ft == 'o' || ft == 'u' || ft == 'A' || ft == 'E' || ft == 'I' || ft == 'O' || ft == 'U')
                Console.WriteLine("The alphabet is a vowel.");
            else
                Console.WriteLine("The alphabet is a consonant.");
        }
    }
}
