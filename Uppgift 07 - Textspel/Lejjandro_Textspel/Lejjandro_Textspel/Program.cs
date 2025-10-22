using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lejjandro_Textspel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            string playerName = "";
            int playerHP = 100;
            string weaponType = "";
            int weaponChoice;
            int playerMaxDamage = 0;
            int playerMinDamage = 0;
            int playerDamage;
            int enemyHp = 100;
            int enemyDamage;
            int enemyMaxDamage;
            int enemyMinDamage;

            Console.WriteLine("Welcome adventurer! What is your name?");
            playerName = Console.ReadLine();

            Console.WriteLine("Welcome to Varelia " + playerName + ". Here is where your journey will begin.");
            Console.ReadLine();

            Console.WriteLine("Welcome to the blacksmith adventure, here you can choose your weapon that will accompany you throughout all your journey.");
            Console.ReadLine();

            while (playerHP > 0 && enemyHp > 0)
            {
                while (weaponType == "")
                {
                    Console.WriteLine("Choose your weapon wisely adventurer:\n1. Sword (20-25 DMG)\n2. Bow (10-20 DMG)\n3. Staff (5-35 DMG)\n4. Dagger (15 DMG)\n5. Axe (10-40 DMG)");
                    weaponChoice = Convert.ToInt32(Console.ReadLine());

                    switch (weaponChoice)
                    {
                        case 1:
                            weaponType = "Sword";
                            playerMinDamage = 20;
                            playerMaxDamage = 25;
                            break;
                        case 2:
                            weaponType = "Bow";
                            playerMinDamage = 10;
                            playerMaxDamage = 20;
                            break;
                        case 3:
                            weaponType = "Staff";
                            playerMinDamage = 5;
                            playerMaxDamage = 35;
                            break;
                        case 4:
                            weaponType = "Dagger";
                            playerMinDamage = 15;
                            playerMaxDamage = 15;
                            break;
                        case 5:
                            weaponType = "Axe";
                            playerMinDamage = 10;
                            playerMaxDamage = 40;
                            break;
                        default:
                            Console.WriteLine("Sorry adventurer I dont have that kind of weapon choose between those weapon adventurer");
                            break;
                    }
                    if (weaponType == "Sword")
                    {
                        Console.WriteLine("Ah... so it was the " + weaponType + " that called to you.May your steel be just and your heart steadfast.");
                        Console.ReadLine();
                    }
                    else if (weaponType == "Bow")
                    {
                        Console.WriteLine("Ah... so the " + weaponType + " it is. May every arrow find what your heart seeks.");
                        Console.ReadLine();
                    }
                    else if (weaponType == "Staff")
                    {
                        Console.WriteLine("Ah... You have chosen the " + weaponType + ". May magic and wisdom be your light and your weapon.");
                        Console.ReadLine();
                    }
                    else if (weaponType == "Dagger")
                    {
                        Console.WriteLine("You have taken the " + weaponType + ". Let silence be your weapon and speed your ally.");
                        Console.ReadLine();
                    }
                    else if (weaponType == "Axe")
                    {
                        Console.WriteLine("Ah… you have chosen the " + weaponType + ". Power and determination will guide your hands.");
                        Console.ReadLine();
                    }

                    playerDamage = rnd.Next(playerMinDamage, playerMaxDamage);
                }


                /*if (playerHP > 0)
                {
                    Console.WriteLine("YOU WIN CONGRATULATIONS ADVENTURE");
                }
                if (playerHP <= 0)
                {
                    Console.WriteLine("YOU DIE ADVENTURE TRY AGAIN");
                }*/
            }
        }
    }
}
