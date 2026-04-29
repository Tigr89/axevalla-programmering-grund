using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperIceCreamSeller
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Glass> glassLista = new List<Glass>();
            glassLista.Add(new Glass("Daimstrut", 30, "Chocolate", true));
            glassLista.Add(new Glass("Piggelin", 10, "None", false));
            glassLista.Add(new Glass("Magnum White", 25, "White chocolate", false));
            glassLista.Add(new Glass("Sandwich", 15, "Chocolate cookie bread", false));
            glassLista.Add(new Glass("Ben & Jerry's Cookie Dough", 80, "Cookie Dough", false));



            int saldo = 100;

            Console.WriteLine("Hej och välkommen till Super Ice Cream Seller!");
            GamePlay();

            Console.WriteLine("Du har inga pengar kvar!");



            void GamePlay()
            {
                while(saldo > 0)
                {
                    Console.WriteLine("Du har: " + saldo);
                    Console.WriteLine("Välj en glass: ");
                    //PROBLEM: vill automatiskt lista namnet på alla tillgängliga glassar!
                    for (int i = 0; i < glassLista.Count; i++)
                    {
                        //1. Daimstrut
                        //2. Piggelin
                        Console.WriteLine((i + 1) + ": " + glassLista[i].glassNamn);
                    }

                    //int choice = Convert.ToInt32(Console.ReadLine());

                    int val = CheckIntValue(Console.ReadLine());

                   

                    while(val < 1 || val > glassLista.Count)
                    {
                        Console.WriteLine("TESTING");
                        Console.WriteLine("ERROR: Glassen finns inte!");
                        val = CheckIntValue(Console.ReadLine());
                    }
                    saldo = saldo - glassLista[val - 1].CheckCash(saldo);
                }
            }

            int CheckIntValue(string valueToCheck)
            {
                //Detta är värdet som vi kommer skicka tillbaka när funktionen är färdigt. Än så länge har det inget värde.
                int returnValue;

                //Kontrollen! Om det man skriver in INTE är ett heltal så kommer man att behöva skriva in ett nytt värde.
                //Datorn låter användaren enbart fortsätta om de skriver in ett faktiskt heltal.
                //Ni kan läsa mer om funktionen "TryParse" genom följande länk: https://learn.microsoft.com/en-us/dotnet/api/system.int32.tryparse?view=netframework-4.7.2
                while (int.TryParse(valueToCheck, out int number) == false)
                {
                    Console.WriteLine("Error try again");
                    valueToCheck = Console.ReadLine();
                }

                //Här sparar vi användarens input i ett faktiskt heltal eftersom vi nu faktiskt vet med 100% säkerhet
                //att det är ett heltal.
                returnValue = int.Parse(valueToCheck);

                //Vi skickar tillbaka värdet!
                return returnValue;
            }
        }
    }
}
