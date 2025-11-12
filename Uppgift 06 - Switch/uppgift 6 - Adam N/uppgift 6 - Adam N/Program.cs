using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace uppgift_6___Adam_N

{

    internal class Program
    {
        static void Main(string[] args)

        {
            int saldo = 100;
            string money;
            int val = 0;

            while (saldo > 0)

            {
                Console.WriteLine("Du har " + saldo + " kvar. Vilken glass vill du köpa? Skriv 1 för Piggelin som kostar 10kr. Skriv 2 för Magnum som kostar 20kr. Skriv 3 för Dajmglass för 30kr");


                

                while (val <= 0 || val >= 4)
                {
                    val = Convert.ToInt32(Console.ReadLine());

                    switch (val)
                    {
                        case 1:
                            saldo = saldo - 10;
                            Console.WriteLine("Du köpte Piggelin. Du har " + saldo + " kvar ");
                            break;



                        case 2:
                            if (saldo >= 20)
                            {
                                saldo = saldo - 20;
                                Console.WriteLine("Du köpte Magnum. Du har " + saldo + " kvar ");

                            }
                            else Console.WriteLine("Du har inte råd");
                                break;



                        case 3:
                            if (saldo >= 30)
                            {
                            saldo = saldo - 30;
                            Console.WriteLine("Du köpte Dajmglass. Du har " + saldo + " kvar ");

                            }
                            else Console.WriteLine("Du har inte råd");
                            break;

                        default:

                            Console.WriteLine("går ej, välj 1, 2 eller 3");

                            val = Convert.ToInt32(Console.ReadLine());
                            break;
                    }

                }
                    val = 0;













            }





        }
    }
}