using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Demo01 Harjoitus 12
 Tee ohjelma, joka kysyy käyttäjältä 5 kokonaislukua. Luvut tulee sijoittaa taulukkoon. 
 Ohjelman tulee tulostaa annetut luvut käänteisessä järjestyksessä.
*/
namespace Teht12
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int[] taulu= new int [5];
            for (int i = 0; i <= 4; i++)
            {
                Console.Write("Anna luku: ");
                taulu[i] = int.Parse(Console.ReadLine());
            }
            for (int j =4; j>=0; j--)
            {
                Console.WriteLine("Luku on :" + taulu[j]);
            }
            Console.ReadKey();
        }
    }
}
