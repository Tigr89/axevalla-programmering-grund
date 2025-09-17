using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int current_year = 2025;

            Console.WriteLine("Välkommen till programmet");
            Console.WriteLine("Vad heter du?");
            string namn = Console.ReadLine();


            Console.WriteLine("Vilket år är du född?");
            int birth_year = Convert.ToInt32(Console.ReadLine());

            int age = current_year - birth_year;

            Console.WriteLine("Du heter: " + namn);
            Console.WriteLine("Du är : " + age + "år");


        }
    }
}
