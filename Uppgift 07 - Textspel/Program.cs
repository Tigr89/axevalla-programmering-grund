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

            string playername = "";
            
            int playerhealth = 100;

            string weapontype = "";

            int weaponchoice = 0;
            int Pmaxdamage = 0;
            int Pmindamage = 0;
            int playerdamage = 0;

            int enemyhealth = 100;
            int emaxdamage = 10;
            int emindamage = 5;
            int enemydamage = 0;

            Console.WriteLine("---Stridspelet---");
            Console.WriteLine("Du och en fiende har max 100hp, varje runda väljer en av er vapen.");


            Console.WriteLine("Vad heter du?");
            playername = Console.ReadLine();


            //Denna kod kollar om user skriver in något, om inte så frågar den igen.
            if (String.IsNullOrWhiteSpace(playername)) playername = "Spelare";
            {
                Console.WriteLine($"Välkommen, {playername} ,Nu börjar spelet!");
            }
            while (playerhealth > 0 && enemyhealth > 0)
            {
                Console.WriteLine($"{playername}, {playerhealth} Fienden, { enemyhealth}");

                weapontype = "";
                while (weapontype == "")
                {
                    Console.WriteLine("Välj vapen");
                    Console.WriteLine("1 Svärd = 12 - 10 damage");
                    Console.WriteLine("2 Yxa = 14 - 8 damage");
                    Console.WriteLine("3 Hammare = 16 - 4 damage");
                    Console.Write("Ditt val 1-3:");

                    //kollar om user skriver in en int om inte frågar programmet om ett int värde mellan 1 till 3.
                    string input = Console.ReadLine();
                    if (!int.TryParse(input, out weaponchoice))
                    {
                        Console.WriteLine("Ogiltigt val, försök igen");
                        continue;
                    }
                    //denna del kollar igenom vilka alternativ som user har skrivet i föregående kod med switch och case statements. 
                    switch (weaponchoice)
                    {
                        case 1:
                            weapontype = "Sword";
                            Pmaxdamage = 12;
                            Pmindamage = 10;
                            break;

                        case 2:
                            weapontype = "Axe";
                            Pmaxdamage = 14;
                            Pmindamage = 8;
                            break;

                        case 3:
                            weapontype = "Hammer";
                            Pmaxdamage = 16;
                            Pmindamage = 4;
                            break;
                        default:
                            break;
                    }
                }

                //slumpmässigt välja skada på fiende eller spelare, beroende på vapen. 
                playerdamage = rnd.Next(Pmindamage, Pmaxdamage + 1);
                enemydamage = rnd.Next(emindamage, emaxdamage + 0);

                enemyhealth -= playerdamage;
                if (enemyhealth < 0) enemyhealth = 0;

                playerhealth -= enemydamage;
                if (playerhealth < 0) playerhealth = 0;
                {
                    Console.WriteLine($"Spelare, {playername}, använder {weapontype}, och gör, {playerdamage} skada,");
                    Console.WriteLine($"Fienden slår tillbaka och gör, {enemydamage} skada på {playername},");
                    Console.WriteLine($"Efter rundan, {playername}, HP = ,{playerhealth}  och fienden har, {enemyhealth}");

                    continue;
                    weapontype = "";
                }

                if (playerhealth > 0)
                {
                    Console.WriteLine("Spelare vinner");
                }
                else 
                {
                    Console.WriteLine("Spelare förlora");
                }
                Console.WriteLine("\nTack för att du spelade!");
            } 
        }
    }
}
