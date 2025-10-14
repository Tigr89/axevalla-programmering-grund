using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsGoGambling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Slot1;
            int Slot2;
            int Slot3;
            Random rnd = new Random();
            bool motivation = true;
            int Cash = 0;
            int Bet;
            string safetycheck;
            string safetycheck2;
            string yesorno;
            bool Repeater;
            int starter;
            int totalscore;
            Console.WriteLine("Welcome. Please input the funds you would like to spend here.");
            while (Cash > 1000 || Cash < 10)
            {
                safetycheck2 = Console.ReadLine();
                bool result = int.TryParse(safetycheck2, out Cash);
                if (Cash > 1000 || Cash < 10)
                    Console.WriteLine("Invalid input. You can input between 10 and 1000 cash.");
            }
            starter = Cash;
            while (Cash > 0 && motivation == true)
            {
                Bet = 0;
                Repeater = true;
                Console.WriteLine("You currently have " + Cash + " cash. Please enter your bet.");
                while (Bet > Cash || Bet < 1)
                {
                    safetycheck = Console.ReadLine();
                    bool result = int.TryParse(safetycheck, out Bet);
                    if (Bet > Cash || Bet < 1)
                        Console.WriteLine("Invalid bet. Try again.");
                }
                Console.WriteLine("Let's go gambling!");
                Slot1 = rnd.Next(1, 3);
                Slot2 = rnd.Next(1, 3);
                Slot3 = rnd.Next(1, 3);

                if (Slot1 == 1)
                    Console.WriteLine("Cherry");
                else if (Slot1 == 2)
                    Console.WriteLine("BAR");
                else
                    Console.WriteLine("7");

                if (Slot2 == 1)
                    Console.WriteLine("Cherry");
                else if (Slot2 == 2)
                    Console.WriteLine("BAR");
                else
                    Console.WriteLine("7");

                if (Slot3 == 1)
                    Console.WriteLine("Cherry");
                else if (Slot3 == 2)
                    Console.WriteLine("BAR");
                else
                    Console.WriteLine("7");

                if (Slot1 == Slot2 && Slot2 == Slot3)
                {
                    Console.WriteLine("You win! You will receive " + Bet * 2 + " in cash.");
                    Cash = Cash - Bet;
                    Cash = Cash + Bet * 2;
                }
                else
                {
                    Console.WriteLine("Aw dangit! You lost your bet of " + Bet + " cash.");
                    Cash = Cash - Bet;
                }
                if (Cash > 0)
                {
                    Console.WriteLine("Would you like to try again?");
                    while (Repeater == true)
                    {
                        yesorno = Console.ReadLine();
                        switch (yesorno)
                        {
                            case "yes":
                                motivation = true;
                                Repeater = false;
                                break;

                            case "no":
                                motivation = false;
                                Repeater = false;
                                break;

                            default:
                                Repeater = true;
                                Console.WriteLine("You must decide! Just say yes or no.");
                                break;
                        }
                    }
                }
            }
            if (Cash < 1)
            {
                Console.WriteLine("You are out of money.");
            }
            else if (Cash < starter)
            {
                totalscore = starter - Cash;
                Console.WriteLine("You have lost " + totalscore + " cash since you started gambling.");
            }
            else if (Cash > starter)
            {
                totalscore = Cash - starter;
                Console.WriteLine("You have somehow earned " + totalscore + " more than what you started with.");
            }
            else
            {
                Console.WriteLine("You have the exact same amount of money that you started with.");
            }
        }
    }
}
