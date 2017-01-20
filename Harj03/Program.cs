using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harj03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] luku = new int[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Anna luku:");
                luku [i] = int.Parse(Console.ReadLine());
            }
            int summa = luku[0] + luku[1] + luku[2];
            double ka = summa / 3.0;
            Console.Write("Summa on :" + summa);
            Console.Write("  Keskiarvo on :" + ka);
            Console.ReadKey();
        }
       
    }
}
