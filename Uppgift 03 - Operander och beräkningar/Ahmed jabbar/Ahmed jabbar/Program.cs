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
            int datum = 2026;
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
            if (age < 13)
            {
                Console.WriteLine("du är ett barn");




            }

            if(age >= 13 && age < 20)
            {
                Console.WriteLine("du är en tonåring");
            }
            if (age >= 20 && age < 65)
            {
                Console.WriteLine("du är vuxen");

            }
            if (age >= 65 && age < 100)
            {
                Console.WriteLine("du är en senior citizen");
            }
            
        }
    }
}
