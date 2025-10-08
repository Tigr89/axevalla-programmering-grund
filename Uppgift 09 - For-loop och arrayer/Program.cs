using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] name = new string[3];
            int Pick = 0;
            string safety;

            Console.WriteLine("Name three different people");
            Console.WriteLine("Person 1 is named...");
            name[0] = Console.ReadLine();
            Console.WriteLine("Person 2 is named...");
            name[1] = Console.ReadLine();
            Console.WriteLine("Person 3 is named...");
            name[2] = Console.ReadLine();
            while (Pick != 4)
            {
                Console.WriteLine("Search for a someone by writing a number. Write 4 if you want to list everyone");
                safety = Console.ReadLine();
                bool result = int.TryParse(safety, out Pick);
                if (Pick == 1)
                    Console.WriteLine("Person 1 is " + name[0]);
                else if (Pick == 2)
                    Console.WriteLine("Person 2 is " + name[1]);
                else if (Pick == 3)
                    Console.WriteLine("Person 3 is " + name[2]);
                else if (Pick != 4)
                    Console.WriteLine("Invalid response");
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Person " + (i + 1) + " is named " + name[i]);
            }
            Console.WriteLine("And that was everyone!");
        }
    }
}
