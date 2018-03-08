using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_OddPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            string ip = Console.ReadLine();
            int n = ip.Length;
            String str = "";

            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)

                    str += ip[i];

            }

            Console.WriteLine(str);

        }
    }
}
