using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt3
{
    internal class Program
    {
        
       
        static void Main(string[] args)
        {
            int current_year = 2025;
            int birth_year;
            Console.WriteLine("Hello there");
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("When were you born?");
            birth_year = Convert.ToInt32(Console.ReadLine());
            int age = current_year - birth_year;
            Console.WriteLine("Thank you " + name);
            Console.WriteLine("Your age is " + age);
        }
    }
}
