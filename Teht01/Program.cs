using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht01
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku;
            Console.Write("Give a number > ");
            string line = Console.ReadLine();
            luku = int.Parse(line);
            switch (luku)
            {
                case 1: Console.Write("yksi"); break;
                case 2: Console.Write("kaksi"); break;
                case 3: Console.Write("kolme"); break;
               default: Console.Write("Joku muuuku"); break;
                    
            }
            Console.ReadLine();
        }
    }
}
