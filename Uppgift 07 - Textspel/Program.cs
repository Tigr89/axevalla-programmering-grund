using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project7a
{
    internal class Program
    {
        Random rnd = new Random();

        
        static void Main(string[] args)
        {
            string playerName = "";
            int playerHP = 100;
            string weaponType = "";
            int weaponChoice;
            int playerDamage;
            int pMaxDamage;
            int pMinDamage;
            int enemyHP = 100;
            int enemyDamage;
            int eMaxDamage = 25;
            int eMinDamage = 15;
            

            Console.WriteLine("Välkommen till: svärd, dolk eller yxa!");
            Console.WriteLine("Vad är ditt namn?");
            playerName = Console.ReadLine();
            Console.WriteLine("Okej " + playerName + ", gör dig redo för strid");

            while (playerHP > 0 && enemyHP > 0)
            {
                Console.WriteLine("Ny runda för er, hur mår ni? du: " + playerHP + " motståndare: "+ enemyHP + " bra");
                Console.WriteLine("Välj ditt vapen: 1 för svärd, 2 för yxa, och 3 för dolk.");
                while (weaponType == "")
                {
                    weaponChoice = Convert.ToInt32(Console.ReadLine());
                    switch (weaponChoice)
                    {
                        case 1:
                            weaponType = "1"
                            Console.WriteLine("svärd")
                            pMaxDamage = 25
                            pMinDamage = 19
                            break;
                        case 2:
                            weaponType = "2"
                            Console.WriteLine("yxa")
                            pMaxDamage = 30
                            pMinDamage = 14
                            break;
                        case 3:
                            weaponType = "3"
                            Console.WriteLine("dolk")
                            pMaxDamage = 20
                            pMinDamage = 19
                            break;
                        default:
                            weaponType = ""
                            Console.WriteLine("Error, välj igen")
                            break;
                    }
                }
                playerDamage = rnd.Next(pMaxDamage, pMinDamage);
                enemyDamage = rnd.Next(eMaxDamage, eMinDamage);
                playerHP -= enemyDamage;
                enemyHP -= playerDamage;
            }
            if (playerHP > 0)
            {
                Console.WriteLine("Gratulerar " + playerName + ", Du vann!");
            }
            else
            {
                Console.WriteLine("Game Over");
            }
        }
    }
}
