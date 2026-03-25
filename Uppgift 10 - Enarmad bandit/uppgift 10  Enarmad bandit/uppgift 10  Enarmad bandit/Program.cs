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
            int coins;
            int coinsinserted;
            bool spin;
            Random rnd = new Random();
            int spin1 = rnd.Next(1, 7);
            int spin2 = rnd.Next(1, 7);
            int spin3 = rnd.Next(1, 7);
            int jackpot;
            int winst;
            string[] symbols = new[] { "seven", "Banana", "apples" }; 

            Console.WriteLine("How many coins do you wanna bet on the slot machine?");

            coins = int.Parse(Console.ReadLine());

            Console.WriteLine("You bet " + coins + " coins. Ready to gamble? Let's start!");



            //make slotmachine spin
            void slotmachine()
            {
                if (spin1 == 7 && spin2 == 7 && spin3 == 7)
                {
                    coins = coinsinserted * 10;
                }

                else if (spin1 == /***random number that isn't matching with the other 2***/ && spin2 == 7 && spin3 == 7)
                {

                }

            }





        }
    }
}
