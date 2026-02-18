using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Microsoft.SqlServer.Server;

namespace Lejjandro_Uppgift_10___Enarmad_bandit
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();
            int playerSaldo = 0;
            string userName;
            int playerBet = 0;
            bool a = true;
            string[] randomSymbol = new string[3];
            int slotSpin = 8;
            string A;
            string slotResult = "";

            Console.WriteLine("Hej user, snälla skriv din namn.");
            userName = Console.ReadLine();

            Console.WriteLine("Välkommen to Triple Seven Slots.");
            Console.ReadLine();
            Console.WriteLine("Här du kan spela slot machime och får chans att få mycket pengar.");
            Console.ReadLine();
            Console.WriteLine(userName + " ,du har " + playerSaldo + " i din konto just nu.");
            Console.ReadLine();
            Console.WriteLine(userName + " hur mycket pengar vill du sätta i din konto? den måste vara mer än 10kr och mindre än 1000kr");

            while (a)
            {
                A = Console.ReadLine();

                while (int.TryParse(A, out int numer) == false)
                {
                    Console.WriteLine("snälla skriva ett nummer mellan 10 och 1000");

                    A = Console.ReadLine();
                }
                playerSaldo = int.Parse(A);
                if (playerSaldo < 10 || playerSaldo > 1000)
                {
                    Console.WriteLine("snälla skriva ett nummer mellan 10 och 1000");
                    a = true;
                }
                else
                {
                    a = false;
                }
            }

            string RandomizedValue()
            {
                string randomValue = "";
                int dice = rnd.Next(0, 3);

                if (dice == 0)
                {
                    randomValue = "7";
                }

                if (dice == 1)
                {
                    randomValue = "&";
                }

                if (dice == 2)
                {
                    randomValue = "£";
                }

                return randomValue;
            }

            while (playerSaldo >= 10 && playerSaldo <= 1000)
            {
                bool gameloop = true;

                Console.WriteLine(userName + " du har " + playerSaldo + " kr " + "i din konto");
                Console.ReadLine();
                Console.WriteLine("Nu jag ska förklara regel av slot machine");
                Console.ReadLine();
                Console.WriteLine("Du ska trycka på en knappen och maskinen ska börja att snurra.");
                Console.ReadLine();
                Console.WriteLine("När maskinen slutar att snurrar du vill att alla synbol ska vara lika. För att vinna den största priset du vill att den visar 777");
                Console.ReadLine();
                Console.WriteLine("Ok, nu ska vi börja");
                Console.ReadLine();
                Console.WriteLine("Hur mycket pengar vill du satsar");

                string SlotFunction()
                {
                    string returnString = "";

                    for (int i = 0; i < slotSpin; i++)
                    {
                        randomSymbol[0] = RandomizedValue();
                        randomSymbol[1] = RandomizedValue();
                        randomSymbol[2] = RandomizedValue();

                        returnString = randomSymbol[0] + randomSymbol[1] + randomSymbol[2];

                        Console.Write(returnString);
                        Thread.Sleep(80);
                        Console.Clear();
                        Thread.Sleep(80);

                        
                    }

                    return returnString;
                }

                while (true)
                {
                    slotResult = SlotFunction();
                    Console.WriteLine(slotResult);

                    if (slotResult == "777")
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("BIG WIN");
                        Console.ResetColor();
                        Thread.Sleep(10000);
                    }
                    break;
                }
                while (playerBet > playerSaldo)
                {
                        Console.WriteLine("Du kan inte satsar mer pengar än vad du har i ditt konto");
                        gameloop = false;
                }   
            }
        }
    }
}
