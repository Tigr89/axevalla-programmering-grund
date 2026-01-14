using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace stenSaxPåse___Adam_N
{
    
    internal class Program
    {

        static void Main(string[] args)
        {
            int psaldo = 100;
            int esaldo = 100;
            int val = 0;
            string choice;
            string Rock;
            string Paper;
            string Scissors;
            Random EnemyRNG = new Random();
            int EnemyChoice;
            string EnemyAttack;
            int bet;
            EnemyAttack  = "";

            while (psaldo + esaldo > 0)
            {
                Console.WriteLine("it's time to play Rock, Paper Scissors. How much do you wanna bet? You currently have " + psaldo + "kr and the enemy has " + esaldo + "kr");
                rockbet = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("You bet " + bet + "kr. Let's begin. You now have to Choose Rock Paper or Scissors and win over the opponent"); 

            choice = Console.ReadLine();
            if (choice.ToLower() == "rock")
            {
                Console.WriteLine("you choose " + choice);
            }

            
            if (choice.ToLower() == "paper")
            {
                Console.WriteLine("you choose " + choice);
            }

            
            if (choice.ToLower() == "scissors")
            {
                Console.WriteLine("you choose " + choice);
            }
            

            


            EnemyChoice = EnemyRNG.Next(1, 4);
            if (EnemyChoice == 1)
            {
                EnemyAttack = "Rock";
            }
            else if (EnemyChoice == 2)
            {
                EnemyAttack = "Paper";
            }
            else if (EnemyChoice == 3)
            {
                EnemyAttack = "Scissors";
            }

                Console.WriteLine("Enemy choose " + EnemyAttack);
            }
            //NEXT LESSION I HAVE TO MAKE HOW YOU CAN WIN AND LOSE
         //  if EnemyAttack == rock && choice == Rock
            {

            }
        }
               //saldo - bet at the end of the script
    }
}
