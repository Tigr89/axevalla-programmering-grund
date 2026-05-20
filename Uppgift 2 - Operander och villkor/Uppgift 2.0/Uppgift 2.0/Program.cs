using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            int userChoice;

            Console.WriteLine("Skriv in en siffra för variabeln x:");
            x = int.Parse(Console.ReadLine());

            //Be användaren skriva in en siffra för variabeln y.

            //Lagra värdet för variabeln y.

            Console.WriteLine($"x är {x} och y är {y}. Gör ett val:");
            Console.WriteLine("1 för att addera");
            Console.WriteLine("2 för att subtrahera");
            Console.WriteLine("3 för att multiplicera");
            userChoice = int.Parse(Console.ReadLine());

            if(userChoice == 1)
            {
                Console.WriteLine($"Resultat: {x + y}");
            }
            //Lägg till fler villkor i en villkorskedja. Använd else if().

            else
            {
                Console.WriteLine("Ej giltigt val.");
            }
        }
    }
}
