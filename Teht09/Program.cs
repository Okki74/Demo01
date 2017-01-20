using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht09
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku = 0;
            int summa = 0;
            do                                                     //Pyydetään lukuja ennenkuin luvun arvo on nolla
            {
                Console.Write("Anna luku: ");
                string line = Console.ReadLine();
                bool result = int.TryParse(line, out luku);         // tarkistetaan onko syöte kokonaislukuja
                if (result != true) { luku = 1; continue; }         // jos ei niin sijoitetaan luku muuttujaan 1, mutta ei mennä summaamaan
                else {  summa = summa + luku; }
            } while (luku != 0);
            Console.WriteLine("Summa on : " + summa);
            Console.ReadKey();
        }
    }
}
