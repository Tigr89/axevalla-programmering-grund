using System;
using System.Collections.Generic;
using System.Linq;
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
            
            Console.WriteLine("Kan du namnge 3 kända personen?");

            name[0] = Console.ReadLine();

            Console.WriteLine("okej, 2 till");

            name[1] = Console.ReadLine();

            Console.WriteLine("okej, 1 till");

            name[2] = Console.ReadLine();

            Console.WriteLine("Sök efter en person genom att skriva i en siffra. skriv 0 om du vill lista alla personer");
            val1 = int.Parse(Console.ReadLine());

            switch (val1)
            {
                case 0:
                    for (int i = 0; i <= name.Length; i++)
                    {

                    }
                    break;

                case 1:
                    break;

                case 2:
                    break;
            }
        }
    }
}
