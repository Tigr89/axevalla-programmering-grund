using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            //Jobba med File01 här
            string result01 = File01Task(input01);
            Console.WriteLine(result01);


            Console.WriteLine();


            //Jobba med File02 här
            List <int> result02 = File02Task(input02);
            foreach(int number in result02)
            {
                Console.WriteLine(number);
            }



            Console.WriteLine();

            //Jobba med File03 här
            int[] result03 = File03Task(input03);
            foreach (int number in result03)
            {
                Console.WriteLine(number);
            }

            //Jobba med File04 här
            //Kalla på funktion
            //Skriv till textdokumentet

            //Jobba med File05 här
            //Kalla på funktion
            //Skriv till textdokumentet
        }

        static string File01Task(string input)
        {
            //För enkelhetens skull lagrar vi vår string i en array av karaktärer
            //Detta så att vi kan använda oss av funktionen "sort".
            char[] listToSort = input.ToCharArray();
            string returnString = "";
            

            //sortera arrayen här.
            Array.Sort(listToSort);


            foreach (char letter in listToSort)
            {
                returnString += letter;
            }

            

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

            foreach(string siffra in listToSort)
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
            

            //Börja med att konvertera varje array element till en siffra och spara i en List<int>.
            List<int> numberList = new List<int>();
            //Sortera listan!
            foreach(string number in input)
            {
                numberList.Add(int.Parse(number));
            }

            numberList.Sort();
            //Returnera listan!
            //Ersätt null med ert resultat!
            return numberList.ToArray();
        }

        static void File04Task(string[] input)
        {
            //Svara på frågorna! 
            //Ledtråd: jobba med varje array-element för sig.
            
            
            //return? Just nu är funktionen "void" -- dvs. funktionen skickar inte tillbaka 
            //något värde.
            //Vill ni skicka tillbaka en string eller en List<string?/char?>?
        }

        static void File05Task(string[] input)
        {
            //Samma uppgift som File04, fast nu ska ni ersätta den existerande informationen
            //med ny information!
        }
    }
}
