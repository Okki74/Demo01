using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht05
{
    class Program
    {
        static void Main(string[] args)
        {
            int sec;
            Console.Write("Anna sekunnit:");
            sec = int.Parse(Console.ReadLine());
            int hour = sec / 3600;
            sec = sec - (hour * 3600);
            int min = sec / 60;
            sec = sec - (min * 60);
            Console.Write("Tunnit on :" + hour);
            Console.Write(" Minuutit on :" + min);
            Console.Write(" Sekunnit :" + sec);
            //Console.WriteLine("Tunnit: {0} Minuutit: {1} Sekunit: {2} " + hour + min + sec);
            Console.ReadKey();
        }
    }
}
