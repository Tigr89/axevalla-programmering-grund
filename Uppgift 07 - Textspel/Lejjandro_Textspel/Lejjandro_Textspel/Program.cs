using System;
using System.Collections.Generic;
using System.Linq;
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
            int playerMaxDamage;
            int playerMinDamage;
            int playerDmage;
            int enemyHp = 100;
            int enemyDmage;
            int enemyMaxDamage;
            int enemyMinDamage;

            while(playerHP > 0 && enemyHp > 0)
            {
                if (playerHP > 0)
                {
                    Console.WriteLine("YOU WIN CONGRATULATIONS ADVENTURE");
                }
                else
                {
                    Console.WriteLine("YOU DIE ADVENTURE TRY AGAIN");
                }
                
            }
        }
    }
}
