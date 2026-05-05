using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixDaCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //VARIABLER
            string[] nameArray = new string[5];
            int userChoice;

            //Be användaren fylla listan med namn.
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Insert name :" + i);
                nameArray[i] = Console.ReadLine();
            }

            //Här startar programloopen. 
            while (true)
            {
                //Berätta för användaren vad de har för alternativ
                Console.WriteLine("Vad vill du göra?");
                Console.WriteLine("1. Lista alla namn");
                Console.WriteLine("2. Lista specifik individ");
                Console.WriteLine("3. Avsluta program");

                userChoice = Console.ReadLine();

                //Om användaren väljer ett icke-legitimt val, be dem välja igen.
                while(userChoice < 1 || userChoice > 3)
                {
                    Console.WriteLine("ERROR. Välj en annan siffra");
                    userChoice = Console.ReadLine();
                }

                //Skriv ut alla individer på separata rader
                if(userChoice == 1)
                {
                    for(int i = 0; i < 5; i++)
                    {
                        Console.Write(nameArray[1]);
                    }
                }
                
                //Låt användaren välja en specifik individ och skriv sedan ut den.
                if(userChoice == 2)
                {
                    Console.WriteLine("Välj en siffra?");

                    userChoice = Console.ReadLine();

                    for(int i = 0; i < 3; i++)
                    {
                        Console.WriteLine("ERROR. Välj en annan siffra");
                        userChoice = Console.ReadLine();
                    }

                    //Skriv ut det som användaren har valt!
                    Console.WriteLine(nameArray[int o = 1]);
                }

                //Avsluta programmet
                if(userChoice == 3)
                {
                    Console.WriteLine("OK! Ha en trevlig dag!");
                }
            }
        }
    }
}
