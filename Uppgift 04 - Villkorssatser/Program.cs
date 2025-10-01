using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int current_year = 2025;
            int birth_year;
            Console.WriteLine("Hi, what is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Please state your age.");
            birth_year = Convert.ToInt32(Console.ReadLine());
            int age = birth_year;
            if (age < 12)
            {
                Console.WriteLine(age + " You are a child " + name);
            }
            else if (age < 30)
            {
                Console.WriteLine(age + " You are a young adult " + name);
            }
            else if (age < 50)
            {
                Console.WriteLine(age + " You are middle aged " + name);
            }
            else if (age > 50)
            {
                Console.WriteLine(age + " You are old " + name);
            }
        }
    }
}
