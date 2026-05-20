using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace uppgift_11___Klasser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerchoice;


            


            List<Animalclass> animallist = new List<Animalclass>();


            while (true)
            {
                Console.WriteLine("Write 1 to add animal. Write 2 to see list. Write 3 to quit");

                playerchoice = int.Parse(Console.ReadLine());
                if (playerchoice == 1)
                {



                    Console.WriteLine("please enter 1 household pet");



                    Animalclass AnimalInstance = new Animalclass();

                    AnimalInstance.name = Console.ReadLine();

                    Console.WriteLine("now enter how many legs does a " + AnimalInstance.name + " have");



                    AnimalInstance.legAmount = Console.ReadLine();

                    Console.WriteLine("a " + AnimalInstance.name + " has " + AnimalInstance.legAmount + " legs! Would you like to add more animals?");



                    animallist.Add(AnimalInstance);



                    



                }

                Console.WriteLine(animallist[0].animalname);
                if (playerchoice == 2)
                {

                    for (int i = 0; i < animallist.Count; i++)
                    {
                        Console.WriteLine("The " + animallist[i].name + " has " + animallist[i].legAmount + " legs");
                        
                    }

                }


                if (playerchoice == 3)
                {
                    break;
                }



            }
        }


           
            
    }


            






        
}

