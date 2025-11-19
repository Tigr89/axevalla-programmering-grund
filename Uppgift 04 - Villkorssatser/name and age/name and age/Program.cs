using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace name_and_age
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int age;
            string name;

            Console.WriteLine("whats your name?");
            name = Console.ReadLine();
            Console.WriteLine("hello " + name );

            Console.WriteLine("how old are you?");
            age = Convert.ToInt32( Console.ReadLine() );
            Console.WriteLine("you are " + age + " years old");

            if (age < 13)
            {
                Console.WriteLine( name +  " you are " + age + " and you are a child");
            }
            if ( age < 18 && age >= 13)
            {
                Console.WriteLine(name + " you are " + age + " and you are teen");
            }
            if (age > 18 && age < 60)
            {
                Console.WriteLine(name + " you are " + age + " and you are an adult");
            }
            
            if (age >= 60)
            {
                Console.WriteLine(name + " you are " + age + " and you are elderly");
            }
        }
    }
}
