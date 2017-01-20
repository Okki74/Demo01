using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht01b
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku;
            Console.Write("Give a number > ");
            string line = Console.ReadLine();
            bool result = int.TryParse(line, out luku);
            if (result == true)
            {
                switch (luku)
                {
                    case 1: Console.Write("yksi"); break;
                    case 2: Console.Write("kaksi"); break;
                    case 3: Console.Write("kolme"); break;
                    default: Console.Write("Joku muuuku"); break;

                }

            } else { Console.WriteLine("not int"); }
            
            Console.ReadLine();
        }
    }
}
