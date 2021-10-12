using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine
{
    class random
    {
        public static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            if (num==20)
            {
                Console.WriteLine("Sa leitsid");
            }
            else if (vanus <= 6)
            {
                Console.WriteLine("Tasuta pilet");
            }
            else if (vanus > 6 && vanus <= 14)
            {
                Console.WriteLine("Laste pilet!");
            }
            else if (vanus > 15 && vanus <= 64)
            {
                Console.WriteLine("Täispilet!");
            }
            else if (vanus > 65 && vanus <= 119)
            {
                Console.WriteLine("Sooduspilet!");
            }
        }
    }
}
