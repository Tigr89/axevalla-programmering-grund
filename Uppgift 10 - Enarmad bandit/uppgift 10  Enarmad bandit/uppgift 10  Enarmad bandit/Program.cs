using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift_10__Enarmad_bandit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int coins = 10000;
            int coinsinserted;
            bool spin;
            Random rnd = new Random();
            int spin1 = rnd.Next(1, 7);
            int spin2 = rnd.Next(1, 7);
            int spin3 = rnd.Next(1, 7);
            int jackpot;
            int winst;
            int loop = 0;

            

            while(coins >= 1)
            {
                Console.WriteLine("How many coins do you wanna bet on the slot machine? you currently have " + coins + " left");

                coinsinserted = int.Parse(Console.ReadLine());
                coins = coins - coinsinserted;


                Console.WriteLine("You bet " + coinsinserted + " coins. Ready to gamble? Let's start!");
                slotmachine();


                

                Console.WriteLine("You have " + coins + " coins left. Do you wanna quit or continue press N to quit or any key to continue");

                string quit = Console.ReadLine();
                if (quit == "N")
                {
                    break;
                }

            }

            if (coins >= 10000)
            {
                Console.WriteLine("You ended up with " + coins + " amount of coins! That is more than what you started with, well done!");
            }


            if (coins <= 10000)
            {
                Console.WriteLine("You ended up with " + coins + " amount of coins... You lost more than you gained...");
            }


            //if continue, go back to betting 




            //make slotmachine spin
            void slotmachine()
            {

                spin1 = rnd.Next(1, 7);
                spin2 = rnd.Next(1, 7);
                spin3 = rnd.Next(1, 7);
                Console.WriteLine(spin1 + " " + spin2 + " " + " " + spin3);

                if (spin1 == spin2 && spin1 == spin3)
                {
                    if (spin1 == 7)
                    {
                        coins = coins + coinsinserted * 50;
                        Console.WriteLine("congrats! You won " + coins + " coins!");
                    }

                    else if (spin1 == 1 || spin1 == 2 || spin1 == 3 || spin1 == 4 || spin1 == 5 || spin1 == 6)
                    {
                        coins = coins + coinsinserted * 10;
                        Console.WriteLine("congrats! You won " + coins + " coins!");
                    }
                }

                if (spin1 == spin2 || spin1 == spin3)
                {
                    if (spin1 == 7)
                    {
                        coins = coins + coinsinserted * 5;
                        Console.WriteLine("congrats! You won " + coins + " coins!");

                    }

                    else if (spin1 == 1 || spin1 == 2 || spin1 == 3 || spin1 == 4 || spin1 == 5 || spin1 == 6)
                    {
                        coins = coins + coinsinserted * 2;
                        Console.WriteLine("congrats! You won " + coins + " coins!");
                    }
                }

                else if (spin2 == spin1 || spin2 == spin3)
                {
                    if (spin2 == 7)
                    {
                        coins = coins + coinsinserted  * 5;
                        Console.WriteLine("congrats! You won " + coins + " coins!");

                    }

                    else if (spin2 == 1 || spin2 == 2 || spin2 == 3 || spin2 == 4 || spin2 == 5 || spin2 == 6)
                    {
                        coins = coins +  coinsinserted * 2;
                        Console.WriteLine("congrats! You won " + coins + " coins!");
                    }
                }



            }



        }
    }
}
