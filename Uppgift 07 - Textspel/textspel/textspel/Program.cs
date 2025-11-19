using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textspel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random diceroll = new Random();
            string playerName = "";
            int playerHP = 100;
            string weaponType = "";
            int weaponChoice;
            int pMaxDamage = 0;
            int pMinDamage = 0;
            int playerDamage;
            int enemyHP = 100;
            int eMaxDamage = 10;
            int eMinDamage = 5;
            int enemyDamage;

            Console.WriteLine("whats your name?");
          playerName = Console.ReadLine();
            Console.WriteLine("your name is: " + playerName);
            Console.WriteLine(" welcome to the game c:");
            Console.WriteLine("you'll pick weapons and fight enemies");

            //gameplay loop
            while (enemyHP > 0 && playerHP > 0)
            {
                Console.WriteLine("pick a weapon");
                weaponChoice = Convert.ToInt32(Console.ReadLine());

                switch (weaponChoice)
                {
                    case 0:
                        Console.WriteLine("error :C");
                        break;

                    case 1:
                        Console.WriteLine("you have a sword with max damage 17 and minimum damage 5" );
                        pMaxDamage = 17;
                        pMinDamage = 5;
                        break;

                    case 2:
                        Console.WriteLine("you have an axe with max damage 14 and minimum damage 8");
                        pMaxDamage = 14;
                        pMinDamage = 8;
                        break;
                   
                    case 3:
                        Console.WriteLine("you have a hammer with max damage 16 and minimum damage 4");
                        pMaxDamage = 16;
                        pMinDamage = 4;
                        break;

                }

                playerDamage = diceroll.Next(pMinDamage, pMaxDamage);
                enemyDamage = diceroll.Next(eMinDamage, eMaxDamage);

                playerHP = playerHP - enemyDamage;
                enemyHP = enemyHP - playerDamage;

                Console.WriteLine("you have " + playerHP + " left ");
                Console.WriteLine("enemy has " + enemyHP + " left");

            }

                if (playerHP <=0 && enemyHP > 0)
            {
                Console.WriteLine("you lost :c");
            }
            if (enemyHP <= 0 && playerHP > 0) 
            {
                Console.WriteLine("YOU WON!!! c:");
            }

            

        } 
     
    }
}
