using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int money = 100;
            string fruit;
            while (money > 0)
            {
                Console.WriteLine("Pick a fruit!");
                fruit = Console.ReadLine();
                switch(fruit)
                {
                    case "apple":
                        money = money - 10;
                        Console.WriteLine("Paid 10 money");
                        break;
                    case "orange":
                        money = money - 20;
                        Console.WriteLine("Paid 20 money");
                        break;
                    case "banana":
                        money = money - 30;
                        Console.WriteLine("Paid 30 money");
                        break;
                    default:
                        Console.WriteLine("Bad answer");
                        break;
                }
            }
            Console.WriteLine("You are out of money");
        }
    }
}
