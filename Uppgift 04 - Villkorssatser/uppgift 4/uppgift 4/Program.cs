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

            string name;
            int age;

            

            






            name = Console.ReadLine();
            Console.WriteLine("Hej " + name + " hur gammal är du?");



            

           

         

            age = Convert.ToInt32(Console.ReadLine());

            if (age <= 12)
            {
                Console.WriteLine(name + " är ett barn");
            }
            else if (age <= 25)
            {
                Console.WriteLine(name + " är en ungdom");
            }

            else if (age <= 40)
            {
                Console.WriteLine(name + " är en medelålders");
            }
            else if (age >= 41)
            {
                Console.WriteLine(name + " är en Gammal");
            }

        }
    }
}
