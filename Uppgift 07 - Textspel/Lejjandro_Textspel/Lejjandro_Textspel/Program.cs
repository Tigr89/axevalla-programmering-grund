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
            int enemyMaxDamage = 25;
            int enemyMinDamage = 5;
            int enemyCritChance = 0;
            int playercritChance = 0;

            // Ask for player's name
            // Fråga efter spelarens namn
            Console.WriteLine("Welcome adventurer! What is your name?");
            playerName = Console.ReadLine();

            // Welcome message
            // Välkomstmeddelande
            Console.WriteLine("Welcome to Varelia " + playerName + ". Here is where your journey will begin.");
            Console.ReadLine();

            // Introduction to the blacksmith and weapon selection
            // Introduktion till smeden och vapenval
            Console.WriteLine("Welcome to the blacksmith adventure, here you can choose your weapon that will accompany you throughout all your journey.");
            Console.ReadLine();

            // Weapon selection loop
            // Vapenvalslopp
            while (playerHP > 0 && enemyHp > 0)
            {
                while (weaponType == "")
                {
                    Console.WriteLine("Choose your weapon wisely adventurer:\n1. Sword (20-25 DMG)\n2. Bow (10-20 DMG)\n3. Staff (5-35 DMG)\n4. Dagger (15 DMG)\n5. Axe (10-40 DMG)");
                    weaponChoice = Convert.ToInt32(Console.ReadLine());

                    switch (weaponChoice)
                    {
                        // Assign weapon stats based on choice
                        // Tilldela vapenstatistik baserat på val
                        case 1:
                            weaponType = "Sword";
                            playerMinDamage = 20;
                            playerMaxDamage = 25;
                            playercritChance = 50;
                            break;
                        
                        case 2:
                            weaponType = "Bow";
                            playerMinDamage = 10;
                            playerMaxDamage = 20;
                            playercritChance = 60;
                            break;
                       
                        case 3:
                            weaponType = "Staff";
                            playerMinDamage = 5;
                            playerMaxDamage = 35;
                            playercritChance = 30;
                            break;
                        
                        case 4:
                            weaponType = "Dagger";
                            playerMinDamage = 15;
                            playerMaxDamage = 15;
                            playercritChance = 70;
                            break;
                        
                        case 5:
                            weaponType = "Axe";
                            playerMinDamage = 10;
                            playerMaxDamage = 40;
                            playercritChance = 20;
                            break;
                        
                        default:
                            Console.WriteLine("Sorry adventurer I dont have that kind of weapon choose between those weapon adventurer");
                            weaponType = "";
                            break;
                    }
                }
                // Provide feedback based on weapon choice
                // Ge feedback baserat på vapenval
                if (weaponType == "Sword")
                    {
                        Console.WriteLine("Ah... So it was the " + weaponType + " that called to you.May your steel be just and your heart steadfast.");
                        Console.ReadLine();
                    }
                    else if (weaponType == "Bow")
                    {
                        Console.WriteLine("Ah... So the " + weaponType + " it is. May every arrow find what your heart seeks.");
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
                        Console.WriteLine("Ah... You have chosen the " + weaponType + ". Power and determination will guide your hands.");
                        Console.ReadLine();
                    }
                    break;
            }

            // Combat loop
            // Stridsloop
            while (playerHP > 0 && enemyHp > 0)
            {
                int val = 0;
                
                playerDamage = rnd.Next(playerMinDamage, playerMaxDamage);

                enemyDamage = rnd.Next(enemyMinDamage, enemyMaxDamage);

                // Player attack choice
                // Spelarens attackval
                while ( val < 1 || val > 2)
                {
                    Console.WriteLine("Choose your attack:\n1. Light Attack (Normal damage)\n2. Heavy Attack (Low chance to hit, chance to do critial damage)");
                    val = Convert.ToInt32(Console.ReadLine());
                    switch (val)
                    {
                        case 1:
                            Console.WriteLine("You chose Light Attack!");
                            break;

                        case 2:

                            // Critical hit and miss chance
                            // Kritisk träff och misschans
                            if (rnd.Next(0, 100) <= playercritChance)
                            {
                                playerDamage = playerDamage * 2;
                                Console.WriteLine("(Critical Hit!)");
                            }
                            else
                            {
                                playerDamage = 0;
                                Console.WriteLine("(You missed your attack!)");
                            }
                            break;

                        default:
                            Console.WriteLine("Invalid choice, please choose again.");
                            break;
                    }
                }
                // Apply damage
                // Tillämpa skada
                enemyHp = enemyHp - playerDamage;

                playerHP = playerHP - enemyDamage;

                // Player damage
                // Spelarens skada
                if (enemyHp < 100)
                {
                    Console.WriteLine("Your " + weaponType + " dealt " + playerDamage + " damage to the enemy.");
                    if (enemyHp < 0)
                    {
                        enemyHp = 0;
                    }

                    Console.WriteLine("The enemy has " + enemyHp + " HP left.");
                }

                // Enemy damage
                // Fiendens skada
                if (playerHP < 100)
                {
                    Console.WriteLine("The enemy dealt " + enemyDamage + " damage to you.");
                    if (playerHP < 0)
                    {
                        playerHP = 0;
                    }

                    Console.WriteLine("You have " + playerHP + " HP left.");
                }

                // Check for enemy defeat
                // Kontrollera om fienden är besegrad
                if (enemyHp <= 0)
                {
                    Console.WriteLine("The enemy has been defeated!");
                }

            }
            // End game messages
            // Slutmeddelanden
            if (playerHP > 0)
            {
                Console.WriteLine("YOU WIN CONGRATULATIONS ADVENTURE");
            }
            if (playerHP <= 0)
            {
                Console.WriteLine("YOU DIE ADVENTURE TRY AGAIN");
            }
        }
    }
}
