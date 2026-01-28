using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_loop
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string[] name = new string[3];
            int choice = 0;



            Console.WriteLine(" welcome please name 3 people");
      
            name[0] = Console.ReadLine(); 
            name[1] = Console.ReadLine();
            name[2] = Console.ReadLine();
            Console.WriteLine("pick from numbers 0 to 2 if you wanna list all names press 3");
             choice = Convert.ToInt32(Console.ReadLine());

            if (choice > -1 && choice < 3) 
            {
                Console.WriteLine("you picked " + name[choice]);
            }
            while (choice < 0 || choice > 3)
            {
                Console.WriteLine("error");
            }
            if (choice == 3)
            {
                for (int i = 0; i < name.Length; i++)
                {
                    Console.WriteLine(name[i]);
                }
            }

            
        }      
    }
}
