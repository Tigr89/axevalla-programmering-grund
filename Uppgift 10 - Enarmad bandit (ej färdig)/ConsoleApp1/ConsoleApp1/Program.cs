using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int saldo = 1000;
            int bet = 0;
            Random random = new Random();
            int gachamachinechoice = 0;
            string[] gachamachine = new string[3];
            string gachamachineresult = "";
            int gains = 0;
            int winnings = 0;
            int losses = 0;
            string[] gachamachine2 = new string[3];
            int gachamachinechoice2 = 0;
            string gachamachineresult2 = "";
            bool win = false;
            int gachamachinechoice3 = 0;
            string[] gachamachine3 = new string[3];
            string gachamachineresult3 = "";

            Console.WriteLine("welcome to the game");
            
            while (true)
            {
              

                Console.WriteLine("how much do you wanna bet?");
                bet = Convert.ToInt32(Console.ReadLine());

                while (bet < 10 || bet > 1000 || bet > saldo)
                {

                    Console.WriteLine("error, write bet again");
                    bet = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("you have betted " + bet + " amount of money");
                FillGachamachine();
                Console.ResetColor();
                VerticalCheck();
                Console.ResetColor();
                HorizontalCheck();
                Console.ResetColor();
                DiagonalCheck();
                Console.ResetColor();
                Console.WriteLine("");
               

                

                


                if (win == false)  
                {
                    Console.WriteLine("you lose");
                    saldo = saldo - bet;
                    gains =  saldo - bet ;  
                    losses = losses - bet ;
                }
                Console.WriteLine("you have " + saldo+ " amount");

                
                Console.WriteLine("do you wanna play again?");
                

                if (Console.ReadLine() == "no")
                {
                    break;
                }

                if (saldo <= 10)
                {
                    break;
                }
                Console.Clear();
                win = false;
                gachamachineresult = "";
            }
            // counting the gains 
            Console.WriteLine("you have " + gains + " remaining");
            Console.WriteLine("you won " + winnings);
            Console.WriteLine("you lost " + losses);

            void DiagonalCheck()
            {
                Console.BackgroundColor = ConsoleColor.Gray;
                if (gachamachine[0] == gachamachine2[1] && gachamachine[0] == gachamachine3[2])
                {
                    Console.WriteLine("you win");
                    saldo = saldo + bet;
                    gains = saldo + bet;
                    winnings = winnings + bet;
                    win = true;
                }
                if (gachamachine[2] == gachamachine2[1] && gachamachine[2] == gachamachine3[0])
                {
                    Console.WriteLine("you win");
                    saldo = saldo + bet;
                    gains = saldo + bet;
                    winnings = winnings + bet;
                    win = true;
                }
            }

            void VerticalCheck()
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                if (gachamachine[0] == gachamachine2[0] && gachamachine[0] == gachamachine3[0])
                {
                    Console.WriteLine("you win");
                    saldo = saldo + bet;
                    gains = saldo + bet;
                    winnings = winnings + bet;
                    win = true;
                }
                if (gachamachine[1] == gachamachine2[1] && gachamachine[1] == gachamachine3[1])
                {
                    Console.WriteLine("you win");
                    saldo = saldo + bet;
                    gains = saldo + bet;
                    winnings = winnings + bet;
                    win = true;
                }
                if (gachamachine[2] == gachamachine2[2] && gachamachine[2] == gachamachine3[2])
                {
                    Console.WriteLine("you win");
                    saldo = saldo + bet;
                    gains = saldo + bet;
                    winnings = winnings + bet;
                    win = true;
                }
            }

            void FillGachamachine()
            {

                for (int i = 0; i < gachamachine.Length; i++)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    gachamachinechoice = random.Next(1, 4);

                    if (gachamachinechoice == 1)
                    {
                        gachamachine[i] = "y";
                        Console.Write(gachamachine[i]);
                    }

                    if (gachamachinechoice == 2)
                    {
                        gachamachine[i] = "x";
                        Console.Write(gachamachine[i]);

                    }
                    if (gachamachinechoice == 3)
                    {
                        gachamachine[i] = "z";
                        Console.Write(gachamachine[i]);

                    }

                    gachamachineresult += gachamachine[i];


                }
                Console.WriteLine("");
                for (int i = 0; i < gachamachine2.Length; i++)
                {
                    gachamachinechoice2 = random.Next(1, 4);

                    if (gachamachinechoice2 == 1)
                    {
                        gachamachine2[i] = "y";
                        Console.Write(gachamachine2[i]);
                    }
                    if (gachamachinechoice2 == 2)
                    {
                        gachamachine2[i] = "x";
                        Console.Write(gachamachine2[i]);
                    }
                    if (gachamachinechoice2 == 3)
                    {
                        gachamachine2[i] = "z";
                        Console.Write(gachamachine2[i]);
                    }
                    gachamachineresult2 += gachamachine2[i];
                }
                Console.WriteLine("");
                for (int i = 0; i < gachamachine3.Length; i++)
                {
                    gachamachinechoice3 = random.Next(1, 4);
                    if (gachamachinechoice3 == 1)
                    {
                        gachamachine3[i] = "y";
                        Console.Write(gachamachine3[i]);
                    }
                    if (gachamachinechoice3 == 2)
                    {
                        gachamachine3[i] = "x";
                        Console.Write(gachamachine3[i]);
                    }
                    if (gachamachinechoice3 == 3)
                    {
                        gachamachine3[i] = "z";
                        Console.Write(gachamachine3[i]);
                    }
                    gachamachineresult3 += gachamachine3[i];
                }
                Console.WriteLine("");

            }
            
            void HorizontalCheck()
            {
                Console.BackgroundColor = ConsoleColor.Magenta;
                if (gachamachineresult == "xxx" || gachamachineresult == "yyy" || gachamachineresult == "zzz")
                {
                    Console.WriteLine("you win");
                    saldo = saldo + bet;
                    gains = saldo + bet;
                    winnings = winnings + bet;
                    win = true;
                }
                //Console.WriteLine("");
                if (gachamachineresult2 == "xxx" || gachamachineresult2 == "yyy" || gachamachineresult2 == "zzz")
                {
                    Console.WriteLine("you win");
                    saldo = saldo + bet;
                    gains = saldo + bet;
                    winnings = winnings + bet;
                    win = true;
                }
                if (gachamachineresult3 == "xxx" || gachamachineresult3 == "yyy" || gachamachineresult3 == "zzz")
                {
                    Console.WriteLine("you win");
                    saldo = saldo + bet;
                    gains = saldo + bet;
                    winnings = winnings + bet;
                    win = true;

                }
            }
        }

        

    }
}
