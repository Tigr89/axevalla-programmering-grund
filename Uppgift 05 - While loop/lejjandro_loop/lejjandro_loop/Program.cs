using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lejjandro_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int saldo = 100;
            int val = 0;

            Console.WriteLine("Välkomen konsument du har 3 glass val för att välja. Du har 100 kr, spendera klokt. (press enter to continue)");

            Console.ReadLine();
            while (saldo > 0)
            {

                Console.WriteLine("Snälla välj ett val mellan 1 och 3. \nval 1 är piggelin och kostar 10 kr. \nval 2 är magnum och kostar 20 kr. \nval 3 är daimstrut och kostar 30 kr.");
                
                Console.WriteLine("Vilken glass vill du köpa?");
                val = Convert.ToInt32(Console.ReadLine());

                if (val < 1 || val > 3)
                {
                    Console.WriteLine("!!!ERRO!!! snällan välja mellan val 1 och 3.");
                }

                else if (val == 1)
                {
                    saldo = saldo - 10;
                    Console.WriteLine("Du har kvar " + saldo + " kr.");
                }

                else if (val == 2 &&  saldo >= 20)
                {
                    saldo = saldo - 20;
                    Console.WriteLine("Du har kvar " + saldo + " kr.");
                }

                else if (val == 3 && saldo >= 30)
                {
                    saldo = saldo - 30;
                    Console.WriteLine("Du har kvar " + saldo + " kr.");
                }
                else
                {
                    Console.WriteLine("Tyvärr, Du har inte tillräcklingt med pengar välj en annan glass.");
                }

                if (saldo < 1)
                {
                    Console.WriteLine("Tyvärr du har använt alla dina pengar kom igen en annan gång när du har mer pengar, tack :)");
                    Console.ReadLine();
                }

            }
            
        }
    }
}
