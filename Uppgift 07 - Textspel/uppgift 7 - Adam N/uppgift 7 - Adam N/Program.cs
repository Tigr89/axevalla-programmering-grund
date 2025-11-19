using System;
using System.Collections.Generic;
using System.Linq;
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
            int pMaxDamage;
            int pMinDamage;
            int PlayerDamage;
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
                    break;
                }

                else if (WeaponChoice.ToLower() == "sword")
                {
                    Console.WriteLine("Du valde " + WeaponChoice);
                    break;
                }

                else if (WeaponChoice.ToLower() == "hammer")
                {
                    Console.WriteLine("Du valde " + WeaponChoice);
                    break;
                }



            }

            if (PlayerHP <= 0 == true)
            {
                Console.WriteLine("Du förlorade");
            }

            else if (PlayerHP <= 0 == false)
            {
                Console.WriteLine("Du vann!");
            }
        }
        
        
        


    }
}
