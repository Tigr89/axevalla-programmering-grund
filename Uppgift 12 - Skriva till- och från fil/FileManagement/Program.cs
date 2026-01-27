using System;
using System.Collections.Generic;
using System.IO;

namespace FileManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hämta information ifrån textfilen! Denna fil finns lokalt på datorn.
            string input01 = File.ReadAllText("../../FilesToRead/File01.txt");
            string input02 = File.ReadAllText("../../FilesToRead/File02.txt");
            string[] input03 = File.ReadAllLines("../../FilesToRead/File03.txt");
            string[] input04 = File.ReadAllLines("../../FilesToRead/File04.txt");
            string[] input05 = File.ReadAllLines("../../FilesToRead/File05.txt");

         
            //Jobba med File01 här
            string result01 = File01Task(input01);
            Console.WriteLine("Result 01:");
            Console.WriteLine(result01);

            //Jobba med File02 här
            List<int> result02 = File02Task(input02);
            Console.WriteLine("Result 02:");
            foreach (int i in result02)
            {
                Console.WriteLine(i);
            }

            //Jobba med File03 här
            int[] result03 = File03Task(input03);
            Console.WriteLine("Result 03:");
            foreach (int i in result03)
            {
                Console.WriteLine(i);
            }
            //Jobba med File04 här
            string[] result04 = File04Task(input04);
            //Skriv till textdokumentet
            File.WriteAllLines("../../FilesToRead/File04.txt", result04);

            //Jobba med File05 här
            string[] result05 = File05Task(input05);
            //Kalla på funktion
            File.WriteAllLines("../../FilesToRead/File05.txt", result05);
            //Skriv till textdokumentet
        }

        static string File01Task(string input)
        {
            //För enkelhetens skull lagrar vi vår string i en array av karaktärer
            //Detta så att vi kan använda oss av funktionen "sort".
            char[] listToSort = input.ToCharArray();
            string returnString = "";

            foreach (char letter in listToSort)
            {
                returnString += letter;
            }

            //sortera arrayen här.
            //???
            Array.Sort(listToSort);
            returnString = new String(listToSort);

            //Här skickar vi tillbaka listan i datatypen "string".
            return returnString;
        }

        static List<int> File02Task(string input)
        {
            string[] listToSort = input.Split(',');

            //Vi vill mata in vår lista av "bokstavssiffror" så att de blir till
            //faktiska siffror. Vi använder en lista här istället för en array eftersom
            //vi kommer att vilja lägga till saker dynamiskt. 
            List<int> intsInList = new List<int>();

            foreach (string siffra in listToSort)
            {
                //För varje (for each) siffra (vårt valda variabelnamn) i vår lista
                //ska läggas in i vår lista "intsInList".
                intsInList.Add(int.Parse(siffra));
            }
            intsInList.Sort();
            return intsInList;
        }

        static int[] File03Task(string[] input)
        {
            //Här får ni en färdig array med rader som enbart består av "bokstavssiffror".
            //Ert uppdrag är att sortera arrayen och skicka tillbaka den till main.
            List<int> intsInList = new List<int>();
            //Börja med att konvertera varje array element till en siffra och spara i en List<int>.
            for (int i = 0; i < input.Length; i++)
            {
                intsInList.Add(int.Parse(input[i]));
            }
            intsInList.Sort();
            int[] returnInts = intsInList.ToArray();
            //Returnera listan!
            //Ersätt null med ert resultat!
            return returnInts;
        }

        static string[] File04Task(string[] input)
        {
 
            string userName = "Me";
            string birthYear = "1405";
            string favoriteColor = "rgb(215, 58, 253)";
            string favoriteBuilding = "Idfk";

            string[] returnStrings = new string[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                string answer = "";
                switch (i)
                {
                    case 0:
                        answer = userName;
                        break;
                    
                    case 1:
                        answer = birthYear;
                        break;

                    case 2:
                        answer = favoriteColor;
                        break;

                    case 3:
                        answer = favoriteBuilding;
                        break;
                }
                returnStrings[i] = input[i] + answer;
                Console.WriteLine(returnStrings[i]);
            }
            return returnStrings;
            //Ledtråd: jobba med varje array-element för sig.


            //return? Just nu är funktionen "void" -- dvs. funktionen skickar inte tillbaka 
            //något värde.
            //Vill ni skicka tillbaka en string eller en List<string?/char?>?
        }

        static string[] File05Task(string[] input)
        {
            List<string> emptiedFields = new List<string>();
            foreach (string s in input)
            {
                string currentField = s;
                string[] splitString = currentField.Split(':');
                splitString[0] += ": ";
                emptiedFields.Add(splitString[0]);
            }

            string userName = "You";
            string birthYear = "1852";
            string favoriteColor = "rgb(153, 217, 14)";
            string favoriteBuilding = "Not Mässen";

            for (int i = 0; i < input.Length; i++)
            {
                string answer = "";
                switch (i)
                {
                    case 0:
                        answer = userName;
                        break;

                    case 1:
                        answer = birthYear;
                        break;

                    case 2:
                        answer = favoriteColor;
                        break;

                    case 3:
                        answer = favoriteBuilding;
                        break;
                }
                emptiedFields[i] += answer;
                Console.WriteLine(emptiedFields[i]);
            }
            string[] filledFields = emptiedFields.ToArray();
            return filledFields;
        }
    }
}