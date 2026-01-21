using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Lejjandro_For_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] name = new string[3];

            int val1;
            bool T = true;
            
            Console.WriteLine("Kan du namnge 3 kända personen?");
            Console.ReadLine();
            Console.WriteLine("Den första ska vara?");

            name[0] = Console.ReadLine();

            Console.WriteLine("okej, 2 till");

            name[1] = Console.ReadLine();

            Console.WriteLine("okej, 1 till");

            name[2] = Console.ReadLine();


            while (T) 
            {
                Console.WriteLine("Sök efter en person genom att skriva i en siffra från 1 till " + name.Length + ". skriv 0 om du vill lista alla personer");
                string test;
                
                
                test= Console.ReadLine();
                
                
                while (int.TryParse(test, out int number) == false)
                {
                    Console.WriteLine("Skriva en siffra mellan 1 och 3");
                    test = Console.ReadLine();
                }
                
                
                
                
                val1 = int.Parse(test);

                switch (val1)
                {
                    case 0:
                        for (int i = 0; i < name.Length; i++)
                        {
                            Console.WriteLine("person " + (i + 1) + ":" + name[i]);
                        }
                        break;

                    case 1:
                        Console.WriteLine("Du söker efter " + name[0]);
                        T = false;
                        break;
                    
                    case 2:
                        Console.WriteLine("Du söker efter " + name[1]);
                        T = false;
                        break;

                    case 3:
                        Console.WriteLine("Du söker efter " + name[2]);
                        T = false;
                        break;

                    default:
                        Console.WriteLine("du kan inte skriva den siffran");
                        break;
                }
            }
        }
    }
}
