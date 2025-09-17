using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lejjandro_beräkning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            string name;
            int current_year = 2025;
            int birth_year;
//Welcome to user
            Console.WriteLine("Welcome user");
            Console.ReadLine();
//User name.           
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
//User age.
            Console.WriteLine("What year are you born?");
            birth_year = Convert.ToInt32(Console.ReadLine());
//message to user with name and age.            
            Console.WriteLine(name + " you are " + (age = current_year - birth_year) + " years old");

            Console.WriteLine(("It was good to knwon a little bit about you ") + name + " have a nice day.");
        }
    }
}
