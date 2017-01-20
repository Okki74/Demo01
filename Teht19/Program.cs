using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Demo01 Teht 19
 * Tee tekstipohjainen Hirsipuu-peli. Voit kovakoodata arvattavan sanan ja toteuta looppi,
 * jossa käyttäjältä kysytään seuraavaa kirjainta. Muista näyttää aina kirjaimen jälkeen
 * oikein arvatut kirjaimet sanan oikealla kohdalla (käytä esim _-alaviivaa ei arvattujen
 * kirjainten kohdalla). Voit näyttää myös jo arvatut ei käytetyt -kirjaimet. Päätä itse
 * milloin pelaaja joutuu hirteen.
 */
namespace Teht19
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] tosi = new bool[7];
            char[] sana = { 'o', 'h', 'j', 'e', 'l', 'm', 'a' };
            char [] kirjain= new char [1];
            string line;
            int vaarin=0;
            int osunutkpl = 0;
            
            Console.WriteLine("_ _ _ _ _ _ _");
            do
            {
                Console.WriteLine("Anna kirjain:");
                line = Console.ReadLine();
                kirjain = line.ToCharArray();
                bool oikein = false;
                for (int i = 0; i <= sana.Length - 1; i++) // verrataan kirjainta sanan kirjaimiin
                {
                    if (sana[i] == kirjain[0])
                    {
                        tosi[i] = true;                 // merkataan boolean tauluun osumat
                        osunutkpl++;                    // lasketaan osumat
                        oikein = true;                  // merkataan kirjain kohtainen osuma

                    }
                }
                if (oikein == false) { vaarin++; }      // jos ei osunut niin lisätään väärin muuttujaa yhdellä


                // Tulostetaan kaikki tähän menessä osuneet
                for (int j = 0; j <= sana.Length - 1; j++)
                {
                    if (tosi[j] == true)            
                    {
                        Console.Write(sana[j]);
                    }
                    else Console.Write("_");
                }
                Console.WriteLine();
               
                
                if (osunutkpl >= 7) { break; } // jos saatu kaikki kirjaimet (7) lähdetään silmukasta
            } while (vaarin != 3); // jos tulee 3 väärin poistutaan silmukasta
            if (vaarin == 3) { Console.WriteLine("Olet hirressä"); }
            else { Console.WriteLine("OIKEIN"); }
            Console.ReadKey();
        }
        
    }
   
    }


    

