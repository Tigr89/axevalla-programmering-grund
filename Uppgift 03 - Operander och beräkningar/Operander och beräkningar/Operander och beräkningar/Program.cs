using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operander_och_beräkningar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string namn = "åldras";


            int åldras;
            int året;
            int resultat;
        
            Console.WriteLine("när föddes du?");

            //This is how you save an integer into a variable
           åldras = Convert.ToInt32(Console.ReadLine());
            

            Console.WriteLine("vilket år är nu?");
            året = Convert.ToInt32(Console.ReadLine());

            resultat = året - åldras;

         
            Console.WriteLine("du är " +resultat+  " år gammal");
           

            
            
        }
    }
}
