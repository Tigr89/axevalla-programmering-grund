using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int saldo = 100;
            int val = 0;

            while (saldo > 0)
            {
                Console.WriteLine("Vilken glasss vill du ha, 1, 2 eller 3?");
                val = Convert.ToInt32(Console.ReadLine());
                if (val == 1)
                {
                    saldo -= 10;
                }
                else if (val == 2)
                {
                    saldo  -= 20;
                }
                else if (val == 3)
                {
                    saldo -= 30;
                }
            }
            Console.WriteLine("Slut på Pengar!");
        }
    }
}
