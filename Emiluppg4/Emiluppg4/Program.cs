using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emiluppg4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            int current_year = 2025;
            int birth_year;


            Console.WriteLine("Hello schmungus");

            Console.WriteLine("What is your name!!!!");
            name = Console.ReadLine();


            Console.WriteLine("when were you born bro " + name);
            birth_year = Convert.ToInt32(Console.ReadLine());

            age = current_year - birth_year;

            Console.WriteLine("so you are " + age);



            if (age <= 12)
            {
                Console.WriteLine("u are a baby lol!");
            }
            if (age <= 25)
            {
                Console.WriteLine("u not baby lol!");
            }
            if (age <= 50)
            {
                Console.WriteLine("u old haha");
            }
            if (age > 50)
            {
                Console.WriteLine("daaaamn u hella old " + name);
            }
            Console.ReadLine();

        }
    }
}
