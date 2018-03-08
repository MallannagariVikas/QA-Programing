using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Triangle_Shape
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            int z;
            int sum = 0;

            Console.WriteLine("Input the ANGLES : ");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            z = Convert.ToInt32(Console.ReadLine());


            if ((x == y) && (y == z))

                Console.WriteLine("This is an equilateral traingle");

            else if ((x == y) || (x == z) || (y == z))
                Console.WriteLine("This is an isosceles traingle");
            else
                Console.WriteLine("This is an scalene traingle");
        }
    }
}
