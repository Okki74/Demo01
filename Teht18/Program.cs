using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Tee ohjelma, joka kysyy käyttäjältä merkkijonon (lause).
 *Sovelluksen tulee ilmoittaa käyttäjälle oliko annettu merkkijono palidromi.
 */
namespace Teht18
{
    class Program
    {
        static void Main(string[] args)
        {
            //int j;
            string line;
            bool pali=true;
            Console.WriteLine("Kirjoita sana");
            line = Console.ReadLine();
            char[] merkit = line.ToCharArray(); // Line tauluksi
            for (int i = 0, j = merkit.Length - 1; i < j; i++, j--) // i lähtee alusta ja j lähtee lopusta ja verrataan arvoja
            {
                if (merkit[i] != merkit[j])
                {
                     pali = false;
                    break;
                }
                else { pali = true; }

            }
            if ( pali == true) { Console.WriteLine("Palidromi"); }
            else { Console.WriteLine("Ei ole palidromi"); }
            Console.ReadKey();
        }
    }
}
