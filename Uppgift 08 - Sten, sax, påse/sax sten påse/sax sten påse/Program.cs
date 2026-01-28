using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace sax_sten_påse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int saldo = 100;
            int choice;
            int pc = 100;
            int pcchoice;
            int bet;
            Random diceroll = new Random();


            Console.WriteLine("welcome to rock paper scissors C:");
            Console.WriteLine("choose between rock, paper or scissors");
           
            while (saldo > 0 && pc > 0)
            {
                Console.WriteLine("you have " + saldo + " money");
                Console.WriteLine("how much money do you wanna spend ?");
                bet = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("rock is number 1, paper is number 2 and scissors are number 3");
                
                Console.WriteLine("pick between your options");
                choice = Convert.ToInt32(Console.ReadLine());
                pcchoice = diceroll.Next(1,4);

                while (choice == 1)
                {
                    if (pcchoice == 3 && pcchoice != 2)
                    {
                        Console.WriteLine("you lost :C");
                        saldo = saldo - bet;
                        pc = pc + bet; 
                    }
                    else if (pcchoice == 2 && pcchoice != 3)
                    {
                        Console.WriteLine("you won c:");
                        saldo = saldo + bet;
                        pc = pc - bet;
                    }
                    else
                    {
                        Console.WriteLine("its a draw");
                    }
                        break;
                }
                while (choice == 2 )
                {
                    if (pcchoice == 1 && pcchoice != 3)
                    {
                        Console.WriteLine("you won c:");
                        saldo = saldo + bet;
                        pc = pc - bet;
                    }
                    else if (pcchoice == 3 && pcchoice != 1)
                    {
                        Console.WriteLine("you lost :C");
                        saldo = saldo - bet;
                        pc = pc + bet;
                    }
                    else
                    {
                        Console.WriteLine("its a draw");
                    }
                    break ;
                }
                while (choice == 3)
                {
                    if (pcchoice == 1 && pcchoice != 2)
                    {
                        Console.WriteLine("you won c:");
                        saldo = saldo + bet;
                        pc = pc - bet;
                    }
                        
                    else if (pcchoice == 2 && pcchoice != 1)
                    {
                        Console.WriteLine("you lost :C");
                        saldo = saldo - bet;
                        pc = pc + bet;
                    }

                    else
                    {
                        Console.WriteLine("its a draw");
                    }
                    break ;
                }

            }
            while (saldo < 0 && pc > 0)
                Console.WriteLine("you lost :c");
            while (saldo > 0 && pc < 0)
                Console.WriteLine("you won");

        }
    }
}
