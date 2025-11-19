using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace loop
{
    internal class Program
    {
        static void Main(string[] args) { 
        int saldo = 100;
        int val = 0;
        int money;
            while (saldo > 0)
            {
            
                Console.WriteLine("option 1:buy ice cream for 10");
                Console.WriteLine("option 2:buy a sandwich for 20");
                Console.WriteLine("option 3: buy a cake for 30");              
                val = Convert.ToInt32(Console.ReadLine());

                if (val > 3 || val < 1)
                {
                    Console.WriteLine("error message");
                }
               
                if (val == 1)
                {
                    saldo = saldo - 10;
                }
                
                

                if (val == 2)
                {
                    saldo = saldo - 20;
                }

                if (val == 3)
                {
                    saldo = saldo - 30;
                }

                if (saldo < 0)
                {
                    Console.WriteLine("youre out of money");
                }

                Console.WriteLine("you have " + saldo + " coins");
            }

       }
    }
}
