using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Tee ohjelma, joka arpoo satunnaisluvun väliltä 0-100. Käytä C#:n Random -luokkaa.
 *  Tämän jälkeen ohjelman käyttäjää kehoitetaan arvaaman arvottu luku. Ohjelman tulee
 *   antaa vihje arvauksen jälkeen onko arvottu luku pienemäi vai suurempi. Tämän jälkeen 
 *   vihjeitä toistetaan kunnes käyttäjä arvaa oikean luvun. Tulosta lopuksi arvausten määrä
 *    näytölle. PS Satunnaislukujen arpomisesta tietokoneella löytyy mielenkiintoista luettavaa
 *     esimerkiksi tästä artikkelista: Computers are lousy random number generators.
 */
namespace Harj16
{
    class Program
    {
        static void Main(string[] args)
        {
            int arvaus = 101;
            Random numbergenerator = new Random();
            int num = numbergenerator.Next(0, 101);
            do
            {
                Console.WriteLine("Arvaa numero 0-100 väliltä");
                arvaus = int.Parse(Console.ReadLine());
                if (arvaus > num)
                {
                    Console.WriteLine("Numero on pienempi kuin antamasi vastaus");
                }
                if (arvaus < num)
                {
                    Console.WriteLine("Numero on suurempi kuin antamasi vastaus");
                }
            }
            while (arvaus != num);
            Console.WriteLine("OIKEIN :):)");
            Console.ReadKey();

        }
    }
}
