using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emil_uppg7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            string playername = "";
            double  playerHP = 0;
            string weaponType = "";
            int playerchoice;
            int weaponchoice;
            double pmaxdamage = 0;
            double pMinDamage = 0;
            double playerdamage = 0;
            double EnemyHP = 250 ;
            double enemydamage = 20;
            double emaxdamage = enemydamage * 2;
            double emindamage = enemydamage * 0.25;
            string weapontext1 = "";
            string weapontext2 = "";
            int hitchance = 0;
            int actualdmg;
            int enemyhitchance = 40;

            Console.WriteLine("Welcome to bängt och gretas wild carjacking");
            Console.ReadLine();

            Console.WriteLine("do you wish to play bängt or greta?");
            Console.WriteLine("press 1 to choose bängt and press 2 to choose greta.");
            playerchoice = Convert.ToInt32(Console.ReadLine());

            while (playerchoice != 1 && playerchoice != 2) 
            {
                //ERROR!
                Console.WriteLine("THERE AINT NO SUCH PERSON IN THIS GAME SON! PICK 1 OR 2 NOW!!!");
                playerchoice = Convert.ToInt32(Console.ReadLine());
            }
            

            if(playerchoice == 1)
            {
                playername = "bängt";
                playerHP = 120;
                playerdamage = 40;
                Console.WriteLine("vad is good " + playername + " lets get to work.");
                Console.ReadLine();
                weapontext1 = "Axe";
                weapontext2 = "Big ol sword";



            }

            

            if (playerchoice == 2)
            {
                playername = "greta";
                playerHP = 60;
                playerdamage = 20;
                Console.WriteLine("hello " + playername+ ".");
                Console.ReadLine();
                weapontext1 = "fishing rod";
                weapontext2 = "pellet slingshot";

            }
            Console.WriteLine("now select your weapon press 1 for " + weapontext1 + " and press 2 for " + weapontext2 + ".");
                weaponchoice = Convert.ToInt32(Console.ReadLine());
                if (weaponchoice == 1)
                {
                    Console.WriteLine("you chose the " + weapontext1 + " not a bad choice son");
                    playerdamage = playerdamage * 1.5f;

                    Console.ReadLine();
                }
                if (weaponchoice == 2)
                {   
                    Console.WriteLine("really? you chose the " + weapontext2 + " are we serious? hey its your choice but damn man really?");
                    Console.ReadLine();
                }
                Console.WriteLine("Now watch out " + playername + " theres the Perfect Samsara Heaven-Defying Earth-Shattering Divine Jade Immortal Paragon of the Great Firmament and the Nine Nirvana Stars Nine Divine Shifts comprising Divine Sea Divine Transformation Divine Lord.!");
                
            
            playerchoice = int.Parse(Console.ReadLine());

            while (playerHP > 0 && EnemyHP > 0)
            {
                Console.WriteLine(" press 1 to use your heavy attack, 2 to use your light attack and 3 to do your special attack!");
                Console.ReadLine();
                if (playerchoice ==1)
                {
                    playerdamage = 70;
                    //Bestäm hit chance
                    hitchance = 50;
                    //Lägg till skadebonusar
                }
                if (playerchoice == 2)
                {
                    playerdamage = 35;
                    hitchance = 75;
                }

                if (playerchoice == 3)
                {
                    playerdamage = 9999;
                    hitchance = 1;
                }

                pMinDamage = playerdamage * 0.5f;
                pmaxdamage = playerdamage * 1.5f;

                
                {

                }
                
                   
                

                if(rnd.Next(0, 100) < enemyhitchance)
                {
                    EnemyHP -= playerdamage;
                
                    Console.WriteLine("Träff!");
                    //Träff
                }
                else
                {
                    Console.WriteLine("Miss!");
                    //Miss
                }
                if (rnd.Next(0, 100) < hitchance)
                {
                    
                    playerHP -= enemydamage; 
                }


                    Console.WriteLine("You have " + playerHP + " HP left.");
                Console.WriteLine("And your enemy has " + EnemyHP + "HP left.");

                Console.ReadLine();
                Console.WriteLine("\n\n\n\n\n");

            }
            

            {
                Console.WriteLine("nice jobbat man du did it!");
                Console.ReadLine();
            }
        }
    }
}
