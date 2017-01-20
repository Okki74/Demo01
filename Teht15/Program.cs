using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Demo 01 Harjoitus15
 * Tee ohjelma, joka tulostaa seuraavanlaisen kuvion. Kysy käyttäjältä puunkorkeus käytä juurena kaksi korkeuden yksikkö.

Anna Luku > 7 [Enter]    
        *
       ***
      *****
     *******
    *********
        *
        *
 */
namespace Teht15
{
    class Program
    {
        static void Main(string[] args)
        {
            int leveys = 1;
            Console.Write("anna luku: ");
            int luku = int.Parse(Console.ReadLine());
            for (int k = 1; k <= luku - 2; k++) // lasketaan levein oksa
            {
                leveys = leveys + 2;
            }
            for (int i =0; i < luku-2; i++) { // kutsutaan tulosta_oksat korkeus-2 kertaa
                tulosta_oksat(i, leveys);
            }
            tulosta_kanta(leveys);
            Console.ReadKey();
        }
        static void tulosta_oksat(int _rivi, int _leveys) //Tulostetaan yhden rivin oksa (*-merkit)
        {
            int ekamerkki = _leveys / 2 - _rivi;        // 1. *-merkki rivillä
            int vikamerkki = _leveys / 2 + _rivi;       // Viimeinen *-merkki rivillä
            for (int j = 0; j <= _leveys; j++)
            {
                if (j>=ekamerkki && j <= vikamerkki)   // Tosi-> tulostettaan *-merkki
                {
                    Console.Write("*");
                } else { Console.Write(" "); }
            }
            
            Console.WriteLine();
        }
        static void tulosta_kanta(int _leveys) // tulostetaan kanta 2 *-merkkiä
        {
            int merkki = _leveys / 2; // keskimäinen merkki
            int runko = 0;
            for (int i = 0; i <2; i++) // kutsutaan 2 kertaa rivin tulostus
            {
                for (int j = 0; j <= _leveys; j++)
                {
                    if (j == merkki)
                    {
                        Console.Write("*");
                    }
                    else { Console.Write(" "); }
                }
                runko++;
                Console.WriteLine();
            }
        }
    }
}
