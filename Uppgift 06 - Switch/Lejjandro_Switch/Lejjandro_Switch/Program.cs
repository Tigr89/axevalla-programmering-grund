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
            string val = "";

            Console.WriteLine("Välkomen konsument du har 3 glass val för att välja. Du har 100 kr, spendera klokt. (press enter to continue)");

            Console.ReadLine();
            while (saldo > 0)
            {

                Console.WriteLine("Snälla välj ett val mellan 1 och 3. \nval 1 är piggelin och kostar 10 kr. \nval 2 är magnum och kostar 20 kr. \nval 3 är daimstrut och kostar 30 kr.");

                Console.WriteLine("Vilken glass vill du köpa?");
                val = Console.ReadLine();

                switch (val)
                {
                    case "1":
                        saldo = saldo - 10;
                        Console.WriteLine("Du har kvar " + saldo + " kr.");
                        break;

                    case "2":
                        if (saldo >= 20)
                        {
                            saldo = saldo - 20;
                            Console.WriteLine("Du har kvar " + saldo + " kr.");
                        }
                        else
                        {
                            Console.WriteLine("Tyvärr, Du har inte tillräcklingt med pengar välj en annan glass.");
                        }
                        break;

                    case "3":
                        if (saldo >= 30)
                        {
                            saldo = saldo - 30;
                            Console.WriteLine("Du har kvar " + saldo + " kr.");
                        }
                        else
                        {
                            Console.WriteLine("Tyvärr, Du har inte tillräcklingt med pengar välj en annan glass.");
                        }
                        break;

                    default:
                        Console.WriteLine("Du behöver välja mellan galss 1 till 3");
                        break;
                }
            }

            Console.WriteLine("Tyvärr du har använt alla dina pengar kom igen en annan gång när du har mer pengar, tack :)");
            Console.ReadLine();
        }
    }
}
