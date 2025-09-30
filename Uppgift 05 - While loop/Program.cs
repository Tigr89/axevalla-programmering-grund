using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileloop
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int funds = 100;
            int choice = 0;
            while (funds > 0)
            {
                Console.WriteLine("Pick a number");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    funds = funds - 10;
                }
                else if (choice == 2)
                {
                    funds = funds - 20;
                }
                else if (choice == 3)
                {
                    funds = funds - 30;
                }
                else
                {
                    Console.WriteLine("Make a real choice for once in your life");
                }
            }
            Console.WriteLine("You are out of money");
        }
    }
}
