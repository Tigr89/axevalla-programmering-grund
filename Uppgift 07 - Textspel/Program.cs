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
            int weaponChoice = 1;
            int playerDamage = weaponChoice + 5;
            int pMaxDamage = playerDamage + 15;
            int pMinDamage = playerDamage - 3;
            int enemyHP = 100;
            int enemyDamage = weaponChoice + 3;
            int eMaxDamage = enemyDamage + 15;
            int eMinDamage = enemyDamage - 2;
            

            Console.WriteLine("Välkommen till: svärd, skjöld eller yxa!");
            Console.WriteLine("Vad är ditt namn?");
            playerName = Console.ReadLine();
            Console.WriteLine("Okej " + playerName + ", gör dig redo för strid");

            while (playerHP > 0 && enemyHP > 0)
            {
                Console.WriteLine("Ny runda för er, hur mår ni? du: " + playerHP + " motståndare: "+ enemyHP + " bra");
                Console.WriteLine("Välj ditt vapen");
                weaponType = Console.ReadLine();
                while (playerHP > 0)
                {
                    switch (weaponChoice)
                    {
                        case 1:
                            Console.WriteLine("svärd");
                            break;
                        case 2:
                            Console.WriteLine("yxa");
                            break;
                        case 3:
                            Console.WriteLine("sköld");
                            break;
                    }
                }                    
            }
            if (playerHP > 0)
            {
                Console.WriteLine("Du vann!");
            }
            else
            {
                Console.WriteLine("Game Over");
            }
        }
    }
}
