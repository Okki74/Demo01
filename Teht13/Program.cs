using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Demo 01 Tehtävä 13
 Mäkihypyssä käytetään viittä arvostelutuomaria. Kirjoita ohjelma, joka kysyy arvostelupisteet yhdelle hypylle
ja tulostaa tyylipisteiden summan siten, että summasta on vähennetty pois pienin ja suurin tyylipiste
*/
namespace Teht13
{
    
    class Program
    {
        

        static void Main(string[] args)
        {
            int[] pisteet = new int[5];
            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine("Anna pisteet:");
                pisteet [i] = int.Parse(Console.ReadLine());
            }
            int suurin = pisteet [0]; // alustetaan jollakin  taulun (0) arvolla
            int pienin = pisteet [0];
            int summa = 0;
            foreach (int summattava in pisteet)
            {
                if (summattava >= suurin) {
                    suurin = summattava;
                }
                if (summattava <= pienin)
                {
                    suurin = summattava;
                }
                summa = summa + summattava;
            }
            int tyylipisteet = summa - (suurin + pienin);
            Console.WriteLine("tyylipisteet: " + tyylipisteet);
            Console.ReadKey();
        }
    }
}
