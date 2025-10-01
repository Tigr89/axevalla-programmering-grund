using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace uppgift_03_Adam_N
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 0;
            Console.WriteLine("what's your name?");

            string name = "Adam";
            int birth_year = 2005;

            int current_year = 2025;
            



            name = Console.ReadLine();
            Console.WriteLine("Hej " + name + " när är du född?");

            birth_year = Convert.ToInt32(Console.ReadLine());

            age = current_year - birth_year;

            Console.WriteLine("Du är " + age + " år gammal");
        }

    }
   
}
