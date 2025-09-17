using System;

namespace Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            int currentyear = 2025;
            int yearofbirth;
            Console.WriteLine("Welcome. Please write down your name:");
            name = Console.ReadLine();
            Console.WriteLine("Write down your year of birth:");
            yearofbirth = Convert.ToInt32(Console.ReadLine());
            age = currentyear - yearofbirth;
            Console.WriteLine("Your name is " + name + " and you are " + age + " years old.");

        }
    }
}
