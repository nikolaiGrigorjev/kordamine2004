using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine
{
    class tsikl
    {
        public static void Main(string[] args)
        {
            int mult = 1;
            int sum = 0;
            double avg = 0.0;
            for(int i=0;i<5;i++)
            {
                Console.Write("Palun kirjuta numbrid");
                int smt = Convert.ToInt32(Console.ReadLine());
                sum += smt;
                mult = smt * mult;
            }
            avg = sum / 5;
            Console.WriteLine($"Nums AVG={avg})\nNums SUM={sum}\nNums multiplied={mult}");

        }
    }
}

