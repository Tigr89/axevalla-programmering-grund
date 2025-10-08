using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int playerhealth = 100;
            int enemyhealth = 100;
            int emaxdamage = 10;
            int emindamage = 5;

            Console.WriteLine("Välkommen till spelet!");
            Console.WriteLine("Vad heter du?");
            string playername = Console.ReadLine();


            Console.WriteLine("Ditt namn är", playername);

            while (playerhealth  > 0 && enemyhealth > 0)
            {
                Console.WriteLine(playerhealth | enemyhealth);
                Console.WriteLine("välj ett vapen mellan yxa 1. svärd 2. hammare 3.");
                int weaponchoice = Convert.ToInt32(Console.ReadLine());

            while (weaponchoice > 0)
                {
                    Console.WriteLine();
                    int playerdamage = rnd.Next(emindamage, emaxdamage);
                }
            } 
        }
    }
}
