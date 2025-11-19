using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace @switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int money = 100;
            int Tim = 100;
            int val = 0;



            while (money > 0)

            {
                Console.WriteLine("which ice cream do you wanna buy?");
                val = Convert.ToInt32(Console.ReadLine());
                switch (val)

                {

                    default:
                        Console.WriteLine("error :(");
                        break;

                    case 1:
                        Console.WriteLine("you have bought piggelin");
                        money = money - 10;
                        Console.WriteLine("you have " + money + " left");
                        break;
                    case 2:
                        Console.WriteLine(" you have bought glassbåt");
                        money =  money  - 20;
                        Console.WriteLine("you have " + money + " left");
                        break;
                    case 3:
                        Console.WriteLine("you have bought daimglass");
                        money = money - 30;
                        Console.WriteLine("you have " + money + " left");
                        break;

                }
               
            }
            Console.WriteLine("youre out of luck :(");



        }

      
    }
}
