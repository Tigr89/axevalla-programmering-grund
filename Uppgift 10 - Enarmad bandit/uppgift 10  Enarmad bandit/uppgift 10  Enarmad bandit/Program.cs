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
            int money;
            bool spin;
            Random rnd = new Random();
            int spin1 = rnd.Next(1, 5);
            int spin2 = rnd.Next(1, 5);
            int spin3 = rnd.Next(1, 5);


            Console.WriteLine("How much money do you wanna bet on the slot machine?");

            money = int.Parse(Console.ReadLine());

            //make slotmachine spin

            
            




















        }
    }
}
