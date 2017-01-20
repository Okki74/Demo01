using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harj04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ikä ?:");
            int age = int.Parse(Console.ReadLine());
            if (age < 18)
            {
                Console.WriteLine("alaikäinen");
            } else if (age>=18 && age <= 65)
            {
                Console.WriteLine("aikuinen");
            }
            else
            {
                Console.WriteLine("Eläkkeellä");
            }
            Console.ReadKey();
        }
    }
}
