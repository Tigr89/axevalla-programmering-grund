using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfThenElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            string name;
            Console.WriteLine("Who are you?");
            name = Console.ReadLine();
            Console.WriteLine("How old are you?");
            age = Convert.ToInt32(Console.ReadLine());
            if (age > 70)
            {
                Console.WriteLine("Your name is " + name + " and you are an old fart.");
            }
            else if (age > 40)
            {
                Console.WriteLine("Your name is " + name + " and your life is wasting away");
            }
            else if (age > 18)
            {
                Console.WriteLine("Your name is " + name + " and you are just getting started");
            }
            else
            Console.WriteLine("Your name is " + name + " and you are still too young");

        }
    }
}
