using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harj06
{
    class Program
    {
        static void Main(string[] args)
        {
            int distance;
            double casol;
            double many;
            Console.Write("Anna matka (km):");
            distance = int.Parse(Console.ReadLine());
            double satakm = distance / 100.00;
            casol= satakm * 7.02;
            many = casol * 1.595;
            Console.Write("Bensaa kuluu: " + casol);
            Console.Write(" Kustannus: " + many);
            Console.ReadKey();
        }
    }
}
