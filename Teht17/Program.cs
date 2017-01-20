using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Tee ohjelma, joka lajittelee kahdessa kokonaislukutaulukossa olevat alkiot
 *  suurusjärjestykseen kolmanteen kokonaislukutaulukkoon. Tulosta lopuksi
 *   lajitellun taulukon sisältö.
 */
namespace Teht17
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] taulu1 = { 1, 5, 7, 9, 12, 20, };
            int[] taulu2 = { 2, 4, 8, 10, 18, 28, };
            int[] taulu3 = new int[12];
            int pointer = 0;
            int j= 0;
            int i = 0;
            int arvo1=0;
            int arvo2=0;

            bool t1loppu = false;
            bool t2loppu = false;
            do
            {
                if (i < taulu1.Length) { arvo1 = taulu1[i]; } else { t1loppu = true; } // taulu1 ->arvo1 niin pitkään kuin käyty läpi 
                if (j < taulu2.Length) { arvo2 = taulu2[j]; } else { t2loppu = true; } // taulu2 ->arvo2 niin pitkään kuin käyty läpi 
                if (arvo1 >= arvo2 || t1loppu==true )
                {
                    taulu3[pointer] = arvo2;
                    pointer++;
                    arvo2 = 0;        
                    j++;
                    
                }
                else if (arvo1 < arvo2 || t2loppu==true )
                {
                    taulu3[pointer] = taulu1[i];
                    pointer++;
                    arvo1 = 0;
                    i++;
                }
               
            } while (i < taulu1.Length-1 && j < taulu2.Length-1 || pointer <
            taulu3.Length);                                                     // tehdään niin pitkään enne kuin taulut 1&2 käytyläpi tai taulu3 menee yli
            
            foreach(int tuloste in taulu3)
            {
                Console.WriteLine(tuloste);
            }
            Console.ReadKey();

        }
    }     
 }


