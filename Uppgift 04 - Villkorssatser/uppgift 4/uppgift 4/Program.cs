using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace uppgift_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what's your name?");

            string name = "Adam";
            int age;

            int birth_year = 2005;

            int current_year = 2025;






            name = Console.ReadLine();
            Console.WriteLine("Hej " + name + " när är du född?");



            birth_year = Convert.ToInt32(Console.ReadLine());
            age = current_year - birth_year;

            Console.WriteLine("Du är " + age + " år gammal");

            age = Convert.ToInt32(Console.ReadLine());

            if (age >= 12)
            {
                Console.WriteLine(name + " är ett barn");
            }


        }
    }
}
