using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Kirjoita ohjelma, joka pyytää käyttäjältä opiskelijoiden arvosanat 0-5 ohjelmointi-opintojaksosta
 * (voit itse päättää lopetusehdon). Tulosta arvosanajakauma käyttäen tähtimerkkejä seuraavasti:

Arvosanajakauma: 
0:
1:****
2:**
3:******
4:*****
5:**

 */
namespace Teht14
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero; int kpl_nolla = 0; int kpl_yksi = 0;
            int kpl_kaksi = 0; int kpl_kolme = 0;
            int kpl_nelja = 0; int kpl_viisi = 0;



            do
            {
                Console.Write("Anna luku:");
                string line = Console.ReadLine();
                bool result = int.TryParse(line, out numero);         // tarkistetaan onko syöte kokonaislukuja
                if (result != true) {continue; }
                switch (numero)                                      // Kerätään arvosanojen kapplemäärät
                {
                    case 0: kpl_nolla++; break;
                    case 1: kpl_yksi++; break;
                    case 2: kpl_kaksi++; break;
                    case 3: kpl_kolme++; break;
                    case 4: kpl_nelja++; break;
                    case 5: kpl_viisi++; break;
                } 
            } while (numero < 6);
            tulosta(kpl_nolla, 0);                              // kutsutaan tulostusta
            tulosta(kpl_yksi, 1);
            tulosta(kpl_kaksi, 2);
            tulosta(kpl_kolme, 3);
            tulosta(kpl_nelja, 4);
            tulosta(kpl_viisi, 5);
            Console.ReadKey();

        }
        static void tulosta (int kpl, int _numero)          // Tulostus funktio
        {
            Console.Write(_numero + ":");
            for (int i = 0; i < kpl; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
