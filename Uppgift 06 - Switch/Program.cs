using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int money = 100;
            int val = 0;

            while(money > 0)
            {
                Console.WriteLine("Vilken glass vill du ha, 1, 2, 3 eller 4?");
                val = Convert.ToInt32(Console.ReadLine());
                switch (val)
                {
                   
                    case 1:
                        Console.WriteLine("val ett", money -= 5);
                        break;
                    case 2:
                    Console.WriteLine("val två", money -= 10);
                        break;
                    case 3:
                    Console.WriteLine("val tre", money -= 20);
                        break;
                    case 4:
                        Console.WriteLine("val fyra", money -= 40);
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }
            }
            Console.WriteLine("Du är pank");
        }
    }
}
