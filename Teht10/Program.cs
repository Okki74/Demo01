using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Olio-ohjelmointi Demo1 Tehtävä 10 
Tee ohjelma, joka alustaa sovellukseen käyttöö seuraavan
taulukon arvot = [1,2,33,44,55,68,77,96,100]. Käy sovelluksessa
taulukko läpi ja tulosta ruutuun "HEP"-sana aina kun taulukossa 
oleva luku on parillinen.

*/
namespace Teht10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] taulu = { 1, 2, 33, 44, 55, 68, 77, 96, 100 };
            foreach (int luku in taulu)
            {
                int jako = luku / 2;
                int tulo = jako * 2;
                if (luku == tulo)
                {
                    Console.Write(+luku);
                    Console.WriteLine(" Hep");

                }
                else Console.WriteLine(luku);
            }
            Console.ReadKey();
        }
    }
}
