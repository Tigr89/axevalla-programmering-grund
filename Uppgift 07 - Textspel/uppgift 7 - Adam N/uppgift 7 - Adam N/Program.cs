using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace uppgift_7___Adam_N

    
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            string PlayerName = "Player";
            int PlayerHP = 100;
            string Axe = "Axe";
            string Sword = "Sword";
            string Hammer = "Hammer";
            string WeaponChoice;
            int pMaxDamage = 0;
            int pMinDamage = 0;
            int PlayerDamage = 0;
            int EnemyHP = 75;
            int eMaxDamage = 25;
            int eMinDamage = 5;
            int EnemyDamage;

            Console.WriteLine("Welcome to the game. What do you wanna Name your character?");
            string name;

            name = Console.ReadLine();
            Console.WriteLine("Interesting name " + name + ". The game is played by simply killing enemies until you die");


            Console.WriteLine("An ORC has appeared.");



            while (EnemyHP >= 0 && PlayerHP >= 0)
            {
                
                
                Console.WriteLine("The ORC have " + EnemyHP + "HP and " + name + " has " + PlayerHP + "HP");

                Console.WriteLine("You need a weapon. Do you want a Sword, an Axe or a Hammer?");
                WeaponChoice = Console.ReadLine();
                if (WeaponChoice.ToLower() == "axe")
                {
                    Console.WriteLine ("Du valde " + WeaponChoice);
                    pMinDamage = 8;
                    pMaxDamage = 14;
                    
                }

                else if (WeaponChoice.ToLower() == "sword")
                {
                    Console.WriteLine("Du valde " + WeaponChoice);
                    pMinDamage = 10;
                    pMaxDamage = 12;
                    
                }

                else if (WeaponChoice.ToLower() == "hammer")
                {
                    Console.WriteLine("Du valde " + WeaponChoice);
                    pMinDamage = 6;
                    pMaxDamage = 16;
                    
                }
                

                
                PlayerDamage = rnd.Next(pMinDamage, pMaxDamage);
                EnemyDamage = rnd.Next(eMinDamage, eMaxDamage);
                Console.WriteLine ("Du gjorde " + PlayerDamage + " Damage och fienden gjorde " + EnemyDamage + " Damage");

                EnemyHP = EnemyHP - PlayerDamage;
                PlayerHP = PlayerHP - EnemyDamage;
            }



            if (PlayerHP <= 0 && EnemyHP >= 1)
            {
                Console.WriteLine("Du förlorade");
            }

            else if (PlayerHP > 0 && EnemyHP <= 0)
            {
                Console.WriteLine("Du vann! med " + PlayerHP +" hp kvar");
            }

            else if (PlayerHP <= 0 && EnemyHP <= 0)
            {
                Console.WriteLine("ni båda dog...");
            }
        }
        
        
        


    }
}
