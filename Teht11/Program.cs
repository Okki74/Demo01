using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Demo 01 Harjoitus 11
 Tee kahden sisäkkäisen for-silmukan avulla ohjelma, 
 joka tulostaa seuraavanlaisen kuvion:
*
**
***
****
*****

Käyttäjä antaa syötteenä tähtirivien lukumäärän. 
Yllä olevassa esimerkissä käyttäjä on syöttänyt luvun 5.
 */
namespace Teht11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna rivien määrä: ");
            int line = int.Parse(Console.ReadLine());
            for (int i = 1; i <=line; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
