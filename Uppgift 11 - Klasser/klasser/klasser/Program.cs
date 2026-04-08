using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace klasser
{

    internal class Program
    {
        public class animal
        {
            public string name;
            public string whatdotheyeat;
            public int legs;

            public void names()
            {
                Console.WriteLine("animal name: " + name);
               
            }
            public void diet()
            {
                Console.WriteLine("animal diet: " + whatdotheyeat);
            }
            public void numberoflegs()
            {
                Console.WriteLine("how many legs do they have: " + legs);
            }
             
            
        }

        static void Main(string[] args)
        {
            
            int choice = 0;
            choice = 0;
            List<animal> animals = new List<animal>();
            

            while (true)
            {


                while (choice <= 0 || choice >= 4)
                {
                    Console.WriteLine("pick between 1-3");
                    Console.WriteLine("1: pick animals");
                    Console.WriteLine("2: list animals that have been picked");
                    Console.WriteLine("3: leave the game");
                    choice = Convert.ToInt32(Console.ReadLine());

                }


                if (choice == 1)
                {
                    animal animal = new animal();
                    Console.WriteLine("what animal is it");
                    animal.name = Console.ReadLine();
                    Console.WriteLine("are they a carnivore, omnivore or herbivore");
                    animal.whatdotheyeat = Console.ReadLine();
                    Console.WriteLine("how many legs does it have");
                    animal.legs = Convert.ToInt32(Console.ReadLine());
                    animals.Add(animal);
                }
                if (choice == 2)
                {
                    Console.WriteLine("listing all the animals and their information you have written");
                    for (int i = 0; i < animals.Count; i++)
                    {
                
                        animals[i].names();
                        animals[i].diet();
                        animals[i].numberoflegs();
                    }
                }
                else if (choice == 3)
                {
                    break;
                }

                choice = 0;
                    
                 
            }


        } 
       
    }
}
