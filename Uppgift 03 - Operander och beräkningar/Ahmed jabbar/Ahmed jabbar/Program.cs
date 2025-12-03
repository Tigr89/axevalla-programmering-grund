using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahmed_jabbar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int datum = 2025;
            int birth; 
            int age; 
            string person;

            Console.WriteLine("hej och välkommen skriv ditt namn");
            person = Console.ReadLine();
            Console.WriteLine("Hej " + person);
            Console.WriteLine("vilket år föddes du?");
            birth = Convert.ToInt32(Console.ReadLine());

            age = datum - birth;
            Console.WriteLine("du heter " + person + " och du är " + age + " år gammal");

            //Nästa gång: gör en beräkning av datum och birth och spara i age!
        }
    }
}
