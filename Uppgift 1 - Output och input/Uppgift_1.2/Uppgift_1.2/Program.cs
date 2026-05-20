using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string förNamn = "förnamn";
            string efterNamn = "efternamn";

            //Undersök funktionen WriteName(string) som finns nedtill
            //Tillämpa den så att output blir korrekt på slutet av programmet.


            //Slutresultat:
            Console.WriteLine($"Du heter {förNamn} {efterNamn}.");
            //Detta är den sista kodraden som programmet utför!


            //Detta är en funktion som returnerar en "string". Dvs. när man kallar på funktionen
            //så kommer den att ge tillbaka en text. 
            string WriteName(string nameToWrite)
            {
                Console.WriteLine($"Fyll i {nameToWrite}");
                return Console.ReadLine();
            }
        }
    }
}
