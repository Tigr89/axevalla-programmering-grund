using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Lejjandro_uppgift_11_klasser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Bilar> bilLista = new List<Bilar>();
            bilLista.Add(new Bilar("Volvo", "XC60", 180, 570000));
            bilLista.Add(new Bilar("Tesla", "Model Y", 250, 500000));
            bilLista.Add(new Bilar("Lamborghini", "Urus", 310, 3000000));

            int saldo = 4000000;

            Console.WriteLine("Välkommer till vår bilhandlare");
            Console.ReadLine();
            Console.WriteLine("Vi har många olika typer av bil märker och modeller, jag hoppas att vi har en som du ska gillar");
            Console.ReadLine();
            Console.WriteLine("Jag kan se här att du har " + saldo + "kr, det är väldigt mycket pengar");
            Console.ReadLine();
            Console.WriteLine("Komm med mig jag ska vissa dig alla billar vi har så du han välja en eller fler som du gillar. Du kan också lägga till bilar om du vill");
            Console.ReadLine();
            gamePlay();

            void gamePlay()
            {
                while (saldo > 0)
                {
                    userAddCar();
                    
                    Console.WriteLine("Jag kan se här att du har " + saldo + "kr, kvar vill du köpa mer? If not type: 0");

                    for (int i = 0; i < bilLista.Count; i++)
                    {
                        Console.WriteLine((i + 1) + ": " + bilLista[i].bilMärke + " " + bilLista[i].bilModell + " " + bilLista[i].bilHastighet + "km " + bilLista[i].bilPris);
                    }
                        Console.WriteLine("0: gå ut/add ny bil");

                    int val = checkToValue(Console.ReadLine());

                    while (val < 0 || val > bilLista.Count)
                    {
                        Console.WriteLine("ERRO, Den bil finns inte");
                        val = checkToValue(Console.ReadLine());
                    }

                    if (val == 0)
                    {
                        userAddCar();
                        break;
                    }
                    else
                    {
                        saldo = saldo - bilLista[val - 1].checkSaldo(saldo);
                    }
                }
            }

            void userAddCar()
            {
                Console.WriteLine("Vill du lägga till bilar\n1: Ja\n2: Nej\n3: gå ut");
                int val1 = checkToValue(Console.ReadLine());

                if (val1 == 1)
                {
                    Console.WriteLine("Du behöver skriva märke, modell, hastighet och pris av bilen du vill lägga till");
                    Bilar biladd = new Bilar("","",0,0);
                    biladd.addCar();
                    bilLista.Add(biladd);
                }
                if (val1 == 3)
                {
                    gamePayEnd();
                }
            }

            void gamePayEnd()
            {
                //Console.Clear();
                Console.WriteLine("Tack att du har kommit, ha en bra dag och hej då");
                Console.ReadLine();
            }

            int checkToValue(string valueToCheck)
            {
                int returnValue;

                while (int.TryParse(valueToCheck, out int number) == false)
                {
                    Console.WriteLine("ERRO!! Snälla använd ett nummer");
                    valueToCheck = Console.ReadLine();
                }

                returnValue = int.Parse(valueToCheck);

                return returnValue;
            }
        }
    }
}
