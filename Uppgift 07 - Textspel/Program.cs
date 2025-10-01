using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textbattle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            string name;
            string weapon;
            int weaponloop = 0;
            int playerHP = 175;
            int pMaxDmg = 0;
            int pMinDmg = 0;
            int playerDmg = 0;
            int playerSpeed = 0;
            int enemyHP = 200;
            int eMaxDmg = 12;
            int eMinDmg = 5;
            int enemyDmg = 0;
            int enemyMiss = 0;
            Console.WriteLine("Welcome to the arena. You have three weapons at your disposal: a sword, an axe, and a hammer.");
            Console.WriteLine("Choose your weapon when asked to do so. You must defeat your enemy before they can defeat you.");
            Console.WriteLine("State your name for the record");
            name = Console.ReadLine();
            Console.WriteLine("Begin!");
            while (playerHP > 0 && enemyHP > 0)
            {
                Console.WriteLine("Your current health is " + playerHP + " and your opponent's current health is " + enemyHP);
                Console.WriteLine("Choose a weapon");
                while (weaponloop == 0)
                {
                    weapon = Console.ReadLine();
                    switch (weapon)
                    {
                        case "sword":
                            weaponloop = 1;
                            pMaxDmg = 13;
                            pMinDmg = 9;
                            break;
                        case "axe":
                            weaponloop = 2;
                            pMaxDmg = 21;
                            pMinDmg = 5;
                            break;
                        case "hammer":
                            weaponloop = 3;
                            pMaxDmg = 27;
                            pMinDmg = 2;
                            break;
                        default:
                            weaponloop = 0;
                            Console.WriteLine("You must choose a weapon! Your choices are sword, axe, and hammer.");
                            break;
                    }
                    playerDmg = rnd.Next(pMinDmg, pMaxDmg);
                    if (weaponloop > 1)
                    {
                        if (pMaxDmg == playerDmg)
                        {
                            Console.WriteLine("Critical hit!");
                            playerDmg = 30;
                        }
                    }
                    enemyHP = enemyHP - playerDmg;
                    Console.WriteLine(name + " dealt " + playerDmg + " damage!");
                    if (enemyHP > 0)
                    {
                        enemyDmg = rnd.Next(eMinDmg, eMaxDmg);
                        playerSpeed = rnd.Next(weaponloop, enemyDmg - 1);
                        enemyMiss = rnd.Next(playerSpeed, enemyDmg);
                        if (enemyMiss > 2 * playerSpeed)
                        {
                            Console.WriteLine("The enemy misses!");
                        }
                        else
                        {
                            playerHP = playerHP - enemyDmg;
                            Console.WriteLine("The enemy hits you for " + enemyDmg + " damage!");
                        }
                    }
                }
                weaponloop = 0;
                pMaxDmg = 0;
                pMinDmg = 0;
                playerDmg = 0;
                enemyDmg = 0;
                enemyMiss = 0;
                playerSpeed = 0;
            }
            if (playerHP < 1)
            {
                Console.WriteLine(name + " was defeated...");
            }
            else
            {
                Console.WriteLine(name + " is victorious!");
            }
        }
    }
}
