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
            string Playerchoice ="";
            string Rock;
            string Paper;
            string Scissors;
            Random EnemyRNG = new Random();
            int EnemyChoice;
            string EnemyAttack;
            int bet = 0;
            EnemyAttack  = "";

            while (psaldo > 0 && esaldo > 0)
            {
                Console.WriteLine("it's time to play Rock, Paper Scissors. How much do you wanna bet? You currently have " + psaldo + "kr and the enemy has " + esaldo + "kr");
                bet = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("You bet " + bet + "kr. Let's begin. You now have to Choose Rock Paper or Scissors and win over the opponent");

                Playerchoice = Console.ReadLine();
                if (Playerchoice.ToLower() == "rock")
                {
                    Console.WriteLine("you choose " + Playerchoice);
                }


                if (Playerchoice.ToLower() == "paper")
                {
                    Console.WriteLine("you choose " + Playerchoice);
                }


                if (Playerchoice.ToLower() == "scissors")
                {
                    Console.WriteLine("you choose " + Playerchoice);
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


                if (EnemyAttack == Playerchoice)
                {
                    Console.WriteLine("Tie. Try again");
                }
                else if (EnemyAttack == "Rock" && Playerchoice.ToLower() == "paper")
                {
                    psaldo = (psaldo + bet);
                    esaldo = (esaldo - bet);
                    Console.WriteLine("You Win. You have " + psaldo + "kr left and enemy has " + esaldo + "kr left");
                }


                else if (EnemyAttack == "Paper" && Playerchoice.ToLower() == "scissors")
                {
                    psaldo = (psaldo + bet);
                    esaldo = (esaldo - bet);
                    Console.WriteLine("You Win. You have " + psaldo + "kr left and enemy has " + esaldo + "kr left");
                }

                else if (EnemyAttack == "Scissors" && Playerchoice.ToLower() == "rock")
                {
                    psaldo = (psaldo + bet);
                    esaldo = (esaldo - bet);
                    Console.WriteLine("You Win. You have " + psaldo + "kr left and enemy has " + esaldo + "kr left");
                }

                else if (EnemyAttack == "Rock" && Playerchoice.ToLower() == "scissors")
                {
                    psaldo = (psaldo - bet);
                    esaldo = (esaldo + bet);
                    Console.WriteLine("You lost. You have " + psaldo + "kr left and enemy has " + esaldo + "kr left");
                }

                else if (EnemyAttack == "Paper" && Playerchoice.ToLower() == "rock")
                {
                    psaldo = (psaldo - bet);
                    esaldo = (esaldo + bet);
                    Console.WriteLine("You lost. You have " + psaldo + "kr left and enemy has " + esaldo + "kr left");
                }
                else if (EnemyAttack == "Scissors" && Playerchoice.ToLower() == "paper")
                {
                    psaldo = (psaldo - bet);
                    esaldo = (esaldo + bet);
                    Console.WriteLine("You lost. You have " + psaldo + "kr left and enemy has " + esaldo + "kr left");
                }
            }
            if (psaldo < 0)
            {
                Console.WriteLine("Sorry loser. You lost...");
            }
            else if (esaldo < 0)
            {
                Console.WriteLine("Congrats! You won!");
            }
        }

    }
}
