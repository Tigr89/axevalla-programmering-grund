using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            int age = 14;
            
            //Användaren ska skriva in ett värde till age
            age = int.Parse(Console.ReadLine());

            if (age < 13)
            {
                Console.WriteLine("du är ett barn");
            }
            //Om värdet i age är mer än 13 men mindre än 20
            if(age >= 13 && age < 20)
            {
               
                Console.WriteLine("du är en ungdom");
            }
            if (age >= 20 && age < 65)
            {
                Console.WriteLine("du är vuxen");

            }
            if (age >= 65 && age < 100) 
            { Console.WriteLine("du är gammal"); }

        } 
    }
}
 