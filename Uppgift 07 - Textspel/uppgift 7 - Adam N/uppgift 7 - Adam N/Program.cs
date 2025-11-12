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
            string Weapontype = "Axe";
            int WeaponChoice;
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


            Console.WriteLine("An ORC has appeared. He have " + EnemyHP + "HP and " + name + " has " + PlayerHP + "HP");




        }


    }
}
