using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 0;
            string name;

            Console.WriteLine("När var du född? (Svara i nummer)");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Vad heter du?");
            name = Console.ReadLine();
            age = DateTime.Now.Year - age;
            Console.WriteLine("Hej " + name + " du är " + age + " eller " + (age - 1) + " år gammal");
        }
    }
}
