using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harj02
{
    class Program
    {
        static void Main(string[] args)
        {
            int pisteet;
            Console.Write("Anna pistemäärä > ");
            pisteet = int.Parse(Console.ReadLine());
            switch (pisteet)
            {
                case 0:
                case 1: Console.WriteLine("Koulunumero on 0"); break;
                case 2:
                case 3: Console.WriteLine("Koulunumero on 1"); break;
                case 4:
                case 5: Console.WriteLine("Koulunumero on 2"); break;
                case 6:
                case 7: Console.WriteLine("Koulunumero on 3"); break;
                case 8:
                case 9: Console.WriteLine("Koulunumero on 4"); break;
                case 10:
                case 11:
                case 12: Console.WriteLine("Koulunumero on 5"); break;
                default: Console.WriteLine("Luku ei ole arvosteluasteikoilla"); break;

            }
            Console.ReadKey();
        }
    }
}
