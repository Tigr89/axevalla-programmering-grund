using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            string Name;
            int PlayerCash = 100;
            int EnemyCash = 100;
            int Bet;
            int Pick;
            string choice = "none";
            int enemyPick;
            string enemyChoice;
            string safetyCheck;
            Console.WriteLine("Please enter your name.");
            Name = Console.ReadLine();
            
            while (PlayerCash > 0 && EnemyCash > 0)
            {
                Console.WriteLine("Your current pool of funds is " + PlayerCash + " while your opponent has " + EnemyCash);
                Bet = 0;
                Pick = 0;
                Console.WriteLine("Make your bet");
                while (Bet > PlayerCash || Bet > EnemyCash || Bet < 1)
                {
                    safetyCheck = Console.ReadLine();
                    bool result = int.TryParse(safetyCheck, out Bet);
                    if (Bet > PlayerCash || Bet > EnemyCash || Bet < 1)
                        Console.WriteLine("Invalid bet. You are limited by your own and your opponent's funds.");
                }
                Console.WriteLine("Pick rock, paper, or scissors");
                while (Pick == 0)
                {
                    choice = Console.ReadLine();
                    switch (choice)
                    {
                        case "rock":
                            Pick = 1;
                            break;
                        case "paper":
                            Pick = 2;
                            break;
                        case "scissors":
                            Pick = 3;
                            break;
                        default:
                            Pick = 0;
                            Console.WriteLine("You must choose either rock, paper, or scissors.");
                            break;
                    }
                }
                enemyPick = rnd.Next(1, 3);
                if (enemyPick == 1)
                    enemyChoice = ("rock");
                else if (enemyPick == 2)
                    enemyChoice = ("paper");
                else
                    enemyChoice = ("scissors");

                if (Pick == enemyPick)
                    Console.WriteLine("You and your opponent have both chosen " + choice + ". Nothing happens.");
                else if (Pick == 1 && enemyPick == 2)
                {
                    Console.WriteLine("You chose " + choice + " while your opponent chose " + enemyChoice + ". You lose this round.");
                    PlayerCash = PlayerCash - Bet;
                    EnemyCash = EnemyCash + Bet;
                }
                else if (Pick == 2 && enemyPick == 3)
                {
                    Console.WriteLine("You chose " + choice + " while your opponent chose " + enemyChoice + ". You lose this round.");
                    PlayerCash = PlayerCash - Bet;
                    EnemyCash = EnemyCash + Bet;
                }
                else if (Pick == 3 && enemyPick == 1)
                {
                    Console.WriteLine("You chose " + choice + " while your opponent chose " + enemyChoice + ". You lose this round.");
                    PlayerCash = PlayerCash - Bet;
                    EnemyCash = EnemyCash + Bet;
                }
                else if (Pick == 2 && enemyPick == 1)
                {
                    Console.WriteLine("You chose " + choice + " while your opponent chose " + enemyChoice + ". You win this round.");
                    PlayerCash = PlayerCash + Bet;
                    EnemyCash = EnemyCash - Bet;
                }
                else if (Pick == 3 && enemyPick == 2)
                {
                    Console.WriteLine("You chose " + choice + " while your opponent chose " + enemyChoice + ". You win this round.");
                    PlayerCash = PlayerCash + Bet;
                    EnemyCash = EnemyCash - Bet;
                }
                else
                {
                    Console.WriteLine("You chose " + choice + " while your opponent chose " + enemyChoice + ". You win this round.");
                    PlayerCash = PlayerCash + Bet;
                    EnemyCash = EnemyCash - Bet;
                }
            }
            if (PlayerCash < 1)
                Console.WriteLine("You lose the game");
            else
                Console.WriteLine("You win the game");
        }
    }
}
