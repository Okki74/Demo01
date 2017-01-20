using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht08
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] luku = new int[3];
            int suurin=0;
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Anna luku:");
                string line = Console.ReadLine();
                bool result = int.TryParse(line, out luku [i]);         // tarkistetaan onko syöte kokonaislukuja
                if (result != true) { i--; continue; }                  // jos ei niin kysytään uudelleen
                if (i >= 1)                                             // lukuja on kysytty kaksi niin mennään vertailuun
                {
                    if (luku[i] >= luku[i - 1] && luku[i] > suurin)     // suurin säilytettään tai sijoitettaan isompi luku[i]-> suurin
                    {
                        suurin = luku[i];
                    }
                    else if (luku[i - 1] > suurin) { suurin = luku[i - 1]; } 
                }
            }
               
            Console.Write("Suurin luku:" +suurin);
            Console.ReadKey();
        }
    }
}
