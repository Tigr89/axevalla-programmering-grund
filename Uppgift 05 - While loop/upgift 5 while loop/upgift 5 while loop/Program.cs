using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace upgift_5_while_loop
{
    

    internal class Program
    {
        
        static void Main(string[] args)
        {
            int Saldo = 100;
            int Val = 0;
            
            while (Saldo > 0) 
            {
                Console.WriteLine("Du har: " + Saldo + " kr, vilken glass vill du köpa? Tryck 1 för Isglass, 2 för Mjukglass eller 3 för en Milkshake");
                //Program options for ice-cream

                Val = int.Parse(Console.ReadLine());

                if (Val == 1)
                {
                    Console.WriteLine("Du har köpt en Isglass");
                    Saldo -= 15;
                }

                if (Val == 2)
                {
                    Console.WriteLine("Du har köpt en Mjukglass");
                    Saldo -= 20;
                }

                if (Val == 3)
                {
                    Console.WriteLine("Du har köpt en Milkshake");
                    Saldo -= 30;
                }

                if (Val > 3 || Val < 0)
                {
                    Console.WriteLine("Det finns bara 3 val din sopprot. Stanna kvar framför datorn, polis på väg.");

                }
                //Not done, program a shut-down

                if (Saldo <= 0)
                {
                    Console.WriteLine("Du har inte råd med någon glass.");
                }
                //Same as prior comment
            }
               
        }
    }
    
}
