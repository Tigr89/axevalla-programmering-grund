using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project8A
{
    internal class Program
    {        
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int Housecash = 100;
            int Playercash = 100;
            string name;
            int Housebet;
            int Housebetmod;
            int Playerbet;
            string safetycheck1;
            string Playerhand;
            int Househand;
            int resultat = 0;

            Console.WriteLine("Välkommen till Sten, Sax eller Påse!");
            Console.WriteLine("Vad heter du?");
            name = Console.ReadLine();
            Console.WriteLine("Gör dig redo " + name + ", Du och huset börjar med 100kr var, du kan bara satsa så mycket som huset kan matcha.");

            while (Playercash > 0 && Housecash > 0)
            {
                Playerbet = 0;
                Console.WriteLine("Du har " + Playercash + "kr");
                Console.WriteLine("Huset har " + Housecash + "kr");
                Console.WriteLine("Vad satsar du?");
                while (Playerbet > Playercash || Playerbet < 1)
                {
                    safetycheck1 = Console.ReadLine();
                    bool result = int.TryParse(safetycheck1, out Playerbet);
                    if (Playerbet > Playercash || Playerbet < 1)
                        Console.WriteLine("Fel mängd, pröva igen.");
                    if (Playerbet > Housecash || Playerbet < 1)
                        Console.WriteLine("Du kan inte satsa mer pengar än huset har.");
                }                
                Housebetmod = Housecash - Playerbet;
                Housebet = Playerbet + rnd.Next(0, Housebetmod);

                Console.WriteLine("Okej. Sten, Sax eller Påse?");
                Playerhand = Console.ReadLine();
                Househand = rnd.Next(1, 3);
                if (Playerhand == "sten")
                {
                    switch (Househand)
                    {
                        default:
                            Console.WriteLine("Nuts");
                            resultat = 0;
                            break;
                        case 1:
                            Console.WriteLine("Sten mot sten, det blir dödläge.");
                            resultat = 0;
                            break;
                        case 2:
                            Console.WriteLine("Din sten tar sax.");
                            resultat = 1;
                            break;
                        case 3:
                            Console.WriteLine("Husets påse tar sten.");
                            resultat = -1;
                            break;
                    }
                }
                else if (Playerhand == "sax")
                {
                    switch (Househand)
                    {
                        default:
                            Console.WriteLine("Nuts");
                            resultat = 0;
                            break;
                        case 1:
                            Console.WriteLine("Husets sten tar sax");
                            resultat = -1;
                            break;
                        case 2:
                            Console.WriteLine("Sax mot sax, det blir dödläge.");
                            resultat = 0;
                            break;
                        case 3:
                            Console.WriteLine("Din sax tar påse");
                            resultat = 1;
                            break;
                    }
                }
                else if (Playerhand == "påse")
                {
                    switch (Househand)
                    {
                        default:
                            Console.WriteLine("Nuts");
                            resultat = 0;
                            break;
                        case 1:
                            Console.WriteLine("´Din påse tar sten");
                            resultat = 1;
                            break;
                        case 2:
                            Console.WriteLine("Husets sax tar påse");
                            resultat = -1;
                            break;
                        case 3:
                            Console.WriteLine("Påse mot påse, det blir dödläge.");
                            resultat = 0;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Nuts!");
                }
                if (resultat == 1)
                {
                    Playercash += Playerbet;
                    Housecash -= Playerbet;
                }                
                else if (resultat == -1)
                {
                    Housecash += Housebet;
                    Playercash -= Housebet;
                }
                else
                {
                    Console.WriteLine("Spela igen");
                }

            }
            if (Playercash > 0)
            {
                Console.WriteLine("Du vann " + name + "!");
            }
            else
            {
                Console.WriteLine("Huset vann");
            }
        }
    }
}
