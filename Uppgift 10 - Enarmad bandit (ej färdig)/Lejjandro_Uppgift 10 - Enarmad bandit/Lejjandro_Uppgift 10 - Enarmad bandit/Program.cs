using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

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

            string A;

            Console.WriteLine("Hej user, snälla skriv din namn.");
            userName = Console.ReadLine();

            Console.WriteLine("Välkommen to Triple Seven Slots.");
            Console.ReadLine();
            Console.WriteLine("Här du kan spela slot machime och får chans att få mycket pengar.");
            Console.ReadLine();
            Console.WriteLine(userName + " ,du har " + playerSaldo + " i din konto just nu.");
            Console.ReadLine();
            Console.WriteLine(userName + " hur mycket pengar vill du sätta i din konto? den måste vara mer än 10kr och mindre än 1000kr");

            while(a)
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

            while (playerSaldo >= 10 && playerSaldo < 1000)
            {
                bool gameloop = false;

                Console.WriteLine(userName + " du har " + playerSaldo + " kr " + " i din konto");
                Console.ReadLine();
                Console.WriteLine("Nu jag ska förklara regel av slot machine");

                while (playerBet > playerSaldo)
                {
                    Console.WriteLine("Du kan inte satsar mer pengar än vad du har i ditt konto");
                    gameloop = false;
                }


            }
        }
    }
}
