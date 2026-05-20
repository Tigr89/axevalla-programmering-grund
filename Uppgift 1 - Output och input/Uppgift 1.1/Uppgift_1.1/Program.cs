using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;

            Console.WriteLine("Skriv in en första siffra");
            x = int.Parse(Console.ReadLine());

            //Be användaren skriva in en andra siffra

            //Lagra det användaren skriver

            //slutresultat:
            Console.WriteLine($"Om man gångrar {x} med {y} så blir det: {x*y}");
        }
    }
}
