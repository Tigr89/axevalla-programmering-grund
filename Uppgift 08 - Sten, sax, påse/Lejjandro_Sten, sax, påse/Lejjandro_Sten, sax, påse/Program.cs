using System;

namespace Lejjandro_Sten__sax__påse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int playerSaldo = 100;
            int computerSaldo = 100;
            int playerBet;
            int computerBet;
            string playerChoice;
            string computerChoice;


            string userName = "user";

            Console.WriteLine("Välkommen till Sten, sax, påse!");
            Console.ReadLine();

            Console.WriteLine("Vad heter du?");
            userName = Console.ReadLine();

            Console.WriteLine("Okej " + userName + ", nu jag ska förklarar reglarna till dig");
            Console.ReadLine();

            Console.WriteLine("Du och datorn börjar med 100 poäng var");
            Console.ReadLine();

            Console.WriteLine("Varje runda väljer du Sten, Sax eller Påse");
            Console.ReadLine();

            Console.WriteLine("Sten slår Sax, Sax slår Påse och Påse slår Sten");
            Console.ReadLine();

            Console.WriteLine("Vinnaren av rundan tar poäng som ni satsade från förloraren");
            Console.ReadLine();

            Console.WriteLine("Låt oss börja!");
            Console.ReadLine();

            Console.Clear();
            while (playerSaldo > 0 && computerSaldo > 0)
            {
                string val1;
                bool gameloop = false;
                
                computerBet = rnd.Next(1, computerSaldo);
                Console.WriteLine("Dator satsade " + computerBet);

                Console.WriteLine("Vill du satsa några poäng? du har " + playerSaldo + " poäng kvar.");
                Console.WriteLine("Ja eller Nej?");
                val1 = Console.ReadLine();


                switch (val1.ToLower())
                {
                    case "ja":
                        Console.WriteLine(userName + ", hur många poäng vill du satsa?");
                        playerBet = int.Parse(Console.ReadLine());
                        gameloop = true;
                        break;

                    case "nej":
                        Console.WriteLine("Okej, du satsar inga poäng denna runda.");
                        gameloop = false;
                        break;
                }

                if (gameloop == true)
                {
                    Console.WriteLine("Nu, välj mellan Sten, Sax eller Påse:");
                    playerChoice = Console.ReadLine();
                    switch (playerChoice.ToLower())
                    {
                        case "sten":
                            break;
                        
                        case "sax":
                            break;

                        case "påse":
                            break;

                    }
                }

            }

            if (playerSaldo <= 0)
            {
                Console.WriteLine("Tyvärr " + userName + ", du har förlorat allt ditt poäng. Datorn vinner!");
                Console.WriteLine("Forsök igen.");
            }
            if (computerSaldo <= 0)
            {
                Console.WriteLine("Grattis " + userName + ", du har vunnit mot datorn!");
                Console.WriteLine("Bra jobbat!");
            }
        }
    }
}
