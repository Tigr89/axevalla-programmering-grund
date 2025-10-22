using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift_5___Adam_Nilsson

{
    class Program
    {
        static void Main(string[] args)
        {
            int saldo = 100;
            int val = 0;


            while (saldo > 0)
            {
                Console.WriteLine("Du har " + saldo + " kvar. Vilken glass vill du köpa? Skriv 1 för Piggelin som kostar 10kr. Skriv 2 för Magnum som kostar 20kr. Skriv 3 för Dajmglass för 30kr");
                

                val = Convert.ToInt32(Console.ReadLine());

                if (val <= 0 || val >= 4)
                {
                    Console.WriteLine("fel nummer");
                }

                else if (val == 1 && saldo >= 10)
                {
                    saldo = saldo - 10;

                    Console.WriteLine("Du köpte Piggelin. Du har " + saldo + " kvar");
                }

                else if (val == 2 && saldo >= 20)
                {
                    saldo = saldo - 20;

                    Console.WriteLine("Du köpte Magnum. Du har " + saldo + " kvar");

                }


                else if (val == 3 && saldo > 30)
                {
                    saldo = saldo - 30;

                    Console.WriteLine("Du köpte Dajmglass. Du har " + saldo + " kvar");
                }

                else
                {
                    Console.WriteLine("du har mindre än 30kr, så du kan inte köpa Dajmglass");
                }
               
                //Berätta för användaren vad den har för valmöjligheter
                //Använd Console.WriteLine();

                //Lagra användarens val i "val"-variabeln

                //Kolla  vad spelaren valde och dra pengar från dess saldo.



                //Om spelaren har pengar kvar så kommer programmet loopa här!

                
                    
                        }
        }
    }
}