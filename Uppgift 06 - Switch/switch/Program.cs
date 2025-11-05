using System.Net.Http.Headers;
using System.Numerics;
using System.Reflection.Metadata;
using System.Threading.Channels;

string gameMode = "pregame";
string playerInput = "";
while (gameMode != "close")
{
    while (gameMode == "pregame")
    {
        Console.WriteLine("Welcome to Increment Dice");
        Console.WriteLine("\n1) Start game\n2) Rules\n3) Close game");


        playerInput = Console.ReadLine();
        switch (playerInput)
        {
            case "1":
                Console.Clear();
                gameMode = "game";
                break;

            case "2":
                Console.Clear();
                gameMode = "rules";
                break;

            case "3":
                gameMode = "close";
                break;
        }
    }
    while (gameMode == "rules")
    {
        Console.WriteLine("Welcome to a game of Increment Dice!");
        playerInput = Console.ReadLine();

        Console.WriteLine("The rules are simple:");
        Console.WriteLine("\nA number will be displayed on screen. This number is the winning number.");
        playerInput = Console.ReadLine();
        Console.WriteLine("You and your opponent will take turns choosing a die to roll.");
        playerInput = Console.ReadLine();
        Console.WriteLine("After picking a die, you will choose whether you want the result of that roll to increase or decrease your total.");
        Console.WriteLine("Whoever lands on the winning number first, wins.");
        playerInput = Console.ReadLine();
        Console.WriteLine("Good luck!");
        playerInput = Console.ReadLine();
        Console.Clear();
        gameMode = "pregame";
    }

    Console.Clear();





 
    //Declaring a bunch of variables
    int P1total = 0; //Player 1's total
    int P2total = 0; //Player 2's total

    int P1chosenDie = 0; //Stores Player 1's chosen die by taking the number of sides the chosen die has
    int P2chosenDie = 0; //Same thing but for Player 2

    int P1rollResult = 0; //Stores Player 1's roll result
    int P2rollResult = 0; //Same thing but for Player 2

    string P1incrementText = ""; //Decorative string. Changes a text prompt in the future to use the word "increment" or "decrement"
    string P2incrementText = ""; //Same thing but for Player 2
    bool P1willDecrement = false; //Is true if Player 1 decides to decrement from their total instead of increment
    bool P2willDecrement = false; //Same thing but for Player 2

    Random rnd = new Random();
    int winningNumber = rnd.Next(30, 61); //Generate the winning number for this round.

    bool P1hasWon = false; //Stores if Player1 has won or not
    bool P2hasWon = false; //Same thing but for Player 2
    int roundNumber = 1; //The round number; increases after each player has made their roll
    int playerTurn = 1; //Stores the current "stage" of the round.
    //1 = Player 1's turn
    //2 = Player 2's turn
    //3 = Rolling phase and then recap of round
    if (gameMode == "game")
    {
        Console.WriteLine("The winning number is " + winningNumber); //Announce winning number
    }
    else if (gameMode == "close")
    {
        Console.WriteLine("ok bye");
    }

        while (gameMode == "game")
        {
            //PLAYER 1 TURN
            while (playerTurn == 1)
            {
                Console.WriteLine("PLAYER 1");
                Console.WriteLine("Choose a die:");
                Console.WriteLine("1) D2 (also known as a coin flip lol)");
                Console.WriteLine("2) D4");
                Console.WriteLine("3) D6");
                Console.WriteLine("4) D10");
                Console.WriteLine("5) D12");
                Console.WriteLine("6) D20");

                //PICK DIE PHASE
                playerInput = Console.ReadLine();
                switch (playerInput) //Pick die
                {
                    case "1":
                        P1chosenDie = 2;
                        break;

                    case "2":
                        P1chosenDie = 4;
                        break;

                    case "3":
                        P1chosenDie = 6;
                        break;

                    case "4":
                        P1chosenDie = 10;
                        break;

                    case "5":
                        P1chosenDie = 12;
                        break;

                    case "6":
                        P1chosenDie = 20;
                        break;

                    default:
                        P1chosenDie = 6;
                        Console.WriteLine("Invalid option. Defaulting to a D6.");
                        Console.ReadLine();
                        break;
                }

                //INCREMENT OR DECREMENT PHASE
                Console.Clear();
                Console.WriteLine("Chose: D" + P1chosenDie);
                Console.WriteLine("Increment or Decrement?");
                Console.WriteLine("1) Increment");
                Console.WriteLine("2) Decrement");

                playerInput = Console.ReadLine(); //Inc or dec
                switch (playerInput)
                {
                    case "1":
                        P1willDecrement = false;
                        P1incrementText = "increment";
                        break;

                    case "2":
                        P1willDecrement = true;
                        P1incrementText = "decrement";
                        break;

                    default:
                        P1willDecrement = false;
                        P1incrementText = "increment";
                        Console.WriteLine("Invalid option. Defaulting to incrementing.");
                        break;
                }

                Console.Clear();
                Console.WriteLine("P1 Action:");
                Console.WriteLine("Roll a D" + P1chosenDie + " and " + P1incrementText + " their total by the result.");
                Console.ReadLine();
                playerTurn += 1;
            }



            //-----PLAYER 2---------------------------------------------------------------------------------------------------------------------
            while (playerTurn == 2)
            {
                Console.WriteLine("PLAYER 2");
                Console.WriteLine("Choose a die:");
                Console.WriteLine("1) D2 (also known as a coin flip lol)");
                Console.WriteLine("2) D4");
                Console.WriteLine("3) D6");
                Console.WriteLine("4) D10");
                Console.WriteLine("5) D12");
                Console.WriteLine("6) D20");

                playerInput = Console.ReadLine();
                switch (playerInput) //Pick die
                {
                    case "1":
                        P2chosenDie = 2;
                        break;

                    case "2":
                        P2chosenDie = 4;
                        break;

                    case "3":
                        P2chosenDie = 6;
                        break;

                    case "4":
                        P2chosenDie = 10;
                        break;

                    case "5":
                        P2chosenDie = 12;
                        break;

                    case "6":
                        P2chosenDie = 20;
                        break;

                    default:
                        P2chosenDie = 6;
                        Console.WriteLine("Invalid option. Defaulting to a D6.");
                        Console.ReadLine();
                        break;
                }

                //INCREMENT OR DECREMENT PHASE

                Console.Clear();
                Console.WriteLine("Chose: D" + P2chosenDie);
                Console.WriteLine("Increment or Decrement?");
                Console.WriteLine("1) Increment");
                Console.WriteLine("2) Decrement");

                playerInput = Console.ReadLine(); //Inc or dec
                switch (playerInput)
                {

                    case "1":
                        P2willDecrement = false;
                        P2incrementText = "increment";
                        break;

                    case "2":
                        P2willDecrement = true;
                        P2incrementText = "decrement";
                        break;

                    default:
                        P2willDecrement = false;
                        P2incrementText = "increment";
                        Console.WriteLine("Invalid option. Defaulting to incrementing.");
                        break;
                }

                Console.Clear();
                Console.WriteLine("P2 Action:");
                Console.WriteLine("Roll a D" + P2chosenDie + " and " + P2incrementText + " their total by the result.");
                Console.ReadLine();

                playerTurn += 1;
            }
            Console.Clear();

            //ROLLING PHASE
            while (playerTurn == 3)
            {

                Console.WriteLine("Player 1 rolls their D" + P1chosenDie + ", and..."); //Suspense text
                Console.ReadLine();
                P1rollResult = rnd.Next(1, P1chosenDie + 1); //Roll P1's die
                Console.WriteLine("The result is " + P1rollResult + "!"); //Tell result
                if (P1willDecrement == true) //If player chose to decrement,
                {

                    P1rollResult = -P1rollResult; //Invert result
                    Console.WriteLine("But since they decided to DECREMENT, this is inverted to " + P1rollResult); //Tell inverted result

                }

                P1total = P1total + P1rollResult; //Calculate P1's new total
                Console.WriteLine("Player 1's total is now at " + P1total + "."); //Announce total
                Console.ReadLine();
                Console.Clear();

                //PLAYER 2 TURN
                Console.WriteLine("\nPlayer 2 rolls their D" + P2chosenDie + ", and..."); //Suspense text again
                Console.ReadLine();

                P2rollResult = rnd.Next(1, P2chosenDie + 1); //Roll P2's die
                Console.WriteLine("The result is " + P2rollResult + "!"); //Tell result
                if (P2willDecrement == true)
                {
                    P2rollResult = -P2rollResult; //Invert result
                    Console.WriteLine("But since they decided to DECREMENT, this is inverted to " + P2rollResult); //Tell inverted result
                }

                P2total = P2total + P2rollResult; //Calculate new total
                Console.WriteLine("Player 2's total is now at " + P2total + "."); //Announce total
                Console.ReadLine();
                Console.Clear();

                //Check for winnings
                if (P1total == winningNumber)
                {
                    P1hasWon = true;
                    Console.WriteLine("Player 1 has reached the winning number of " + winningNumber + "!");
                    Console.ReadLine();
                }

                if (P2total == winningNumber)
                {
                    P2hasWon = true;
                    switch (P1hasWon)
                    {
                        case true:
                            Console.WriteLine("But so did Player 2!");
                            break;

                        case false:
                            Console.WriteLine("Player 2 has reached the winning number of " + winningNumber + "!");
                            break;
                    }
                    Console.ReadLine();
                }

                if (P1hasWon == true | P2hasWon == true)
                {
                    if (P1hasWon == true & P2hasWon == true)
                    {
                        Console.WriteLine("It's a draw!");
                    }
                    else if (P1hasWon == true)
                    {
                        Console.WriteLine("Player 1 wins!");
                    }
                    else if (P2hasWon == true)
                    {
                        Console.WriteLine("Player 2 wins!");
                    }

                    Console.ReadLine();
                    Console.Clear();
                    gameMode = "pregame";
                    break;
                }
                //Recap round
                Console.WriteLine("Round " + roundNumber + ":");
                Console.WriteLine("Winning number: " + winningNumber);
                Console.WriteLine("Player 1 total: " + P1total);
                Console.WriteLine("Player 2 total: " + P2total);
                Console.ReadLine();
                Console.Clear();
                playerTurn = 1;
            }


        }
}