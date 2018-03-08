using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Electricity_Bill
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            String name;
            int unit;
            double bill = 0;
            double SurchargeAmount = 0;
            double netAmount = 0;

            Console.WriteLine("Enter details");
            num = Convert.ToInt32(Console.ReadLine());
            name = Console.ReadLine();
            unit = Convert.ToInt32(Console.ReadLine());
            if (unit <= 199)
                bill = 1.20 * 199;
            else if (unit >= 200 && unit < 400)
                bill = 1.50 * unit;
            else if (unit >= 400 && unit < 600)
                bill = 1.80 * unit;
            else if (unit >= 600)
                bill = 2.00 * unit;

            if (bill > 400)
                SurchargeAmount = bill * 0.15;

            netAmount = bill + SurchargeAmount;
            Console.WriteLine();
            Console.WriteLine("Customer IDNO :" + num);
            Console.WriteLine("Customer Name :" + name);
            Console.WriteLine("unit Consumed :" + unit);
            Console.WriteLine("Amount:" + bill);
            Console.WriteLine("Surchage Amount :" + SurchargeAmount);
            Console.WriteLine("Net Amount Paid By the Customer : " + netAmount);

        }
    }
}
