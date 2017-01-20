using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht07
{
    class Program
    {
        static void Main(string[] args)
        {
            int vuosi;
            Console.Write("Anna vuosiluku:");
            string line = Console.ReadLine();
            bool result = int.TryParse(line, out vuosi); // tarkistetaan onko syöte kokonaislukuja
            if (result == true)
            {
                int karkaus = vuosi / 4;                 // jaetaan annettu vuosiluku 4
                int neljalla = karkaus * 4;         // ja kerrotaan vuosiluku 4 huom! kokonaisluku
                int sata = vuosi / 100;             // sama sadalla
                int sadalla = sata * 100;
                if (vuosi == neljalla && vuosi != sadalla  )               // jos syöte -> neljällä jaollinen ja ei ole sadalla jaollinen -> karkausvuosi
                {               
                        Console.Write("Vuosiluku on karkausvuosi");     
                }
                else { Console.Write("Vuosiluku ei ole karkausvuosi"); }

            } else { Console.Write("Syötä vuosiluku numeroilla"); }
            Console.ReadLine();
        }
    }
}
