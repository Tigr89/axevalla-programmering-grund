using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emiluppg5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int saldo = 100;
            int val = 0;

            Console.WriteLine("välj mellan glass 1 för 10kr, 2 för 20kr och 3 för 30kr du har " + saldo + " kr");

            while (saldo > 0)
            {

                val = Convert.ToInt32(Console.ReadLine());
                if (val == 1)
                {
                    saldo = saldo - 10;
                    Console.WriteLine("tack, du har " + saldo + " kr kvar");
                      
                }
                else if (val == 2 && saldo >= 20)
                {
                    saldo = saldo - 20;
                    Console.WriteLine("tack, du har " + saldo + " kr kvar");
                }
                else if (val ==3 && saldo >= 30)
                {
                    saldo = saldo - 30;
                    Console.WriteLine("tack, du har " + saldo + " kr kvar");

                }
                else
                {
                    
                    Console.WriteLine("du har inte råd du har bara " + saldo + " kr!!!!!!");

                   
                }

                if (val > 3)
                {
                    Console.WriteLine("finns inget sånt här");

                }
                if (val<1) { Console.WriteLine("finns inget sånt här");
                   
                 }
                if (saldo <= 0)
                {
                    Console.WriteLine("du e pank stick härifrån!!");
                    Console.ReadLine();



                }
            }
            
        }
    }
}
