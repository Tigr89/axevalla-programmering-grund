using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreValueFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            //PROBLEM: programmet kraschar när jag ber användaren skriva in ett heltal!
            //LÖSNING: Vi kan skapa en funktion som kollar om värdet vi vill lagra är ett
            //heltal eller inte. 

            //Två exempelvariabler som vi vill lagra värden i.
            int choice1 = 0;
            int choice2 = 0;

            //Vi ber användaren göra ett val. 
            Console.WriteLine("Make a choice! Write a number");
            choice1 = CheckIntValue(Console.ReadLine()); 

            //Vi tar vår variabel (choice1) och kallar sedan på vår funktion "CheckIntValue" som
            //returnerar ett heltal. Denna funktion tar emot ett argument av datatypen "string" och
            //returnerar det som ett heltal!

            //Vi ber användaren göra ett till val och lagrar det i en annan variabel.
            Console.WriteLine("Make a second choice! Write a number");
            choice2 = CheckIntValue(Console.ReadLine());

            //Vi kontrollerar så att allt blev rätt!
            Console.WriteLine("You chose the numbers: " + choice1 + " " + choice2);


            //Skriv in "Console.ReadLine()" i den lokala string-variabeln
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
