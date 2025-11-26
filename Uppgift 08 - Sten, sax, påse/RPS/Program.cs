// See https://aka.ms/new-console-template for more information
bool playerWonRound = false;
bool validBet = false;
bool drawHappened = false;
string playerChoice = "";
string cpuChoice = "";

string winningPlayer = "no one";
int playerScore = 100;
int cpuScore = 100;

string playerInput = "";
int betAmount = 0;

Random random = new Random();
int RNG = 0;
while (winningPlayer == "no one")
{
    bool canBeParsed = false;
    validBet = false;
    drawHappened = false;
    playerWonRound = false;

    playerChoice = "";
    cpuChoice = "";

    betAmount = 0;
    Console.WriteLine("Player Money: " + playerScore);
    Console.WriteLine("CPU Money: " + cpuScore);

    while (validBet == false)
    {
        canBeParsed = false;
        while (canBeParsed == false)
        {
            Console.WriteLine("How much to bet?");
            playerInput = Console.ReadLine();
            Console.Clear();
            canBeParsed = int.TryParse(playerInput, out betAmount);
            if (canBeParsed == true)
            {
                betAmount = Convert.ToInt32(playerInput);
            }
            else Console.WriteLine("Only numbers, please!");
        }


        if (betAmount > cpuScore)
        {
            Console.WriteLine("CPU doesn't have that much!");
            validBet = false;
            Console.ReadLine();
            Console.Clear();
        }
        else if (betAmount > playerScore)
        {
            Console.WriteLine("Player doesn't have that much!");
            validBet = false;
            Console.ReadLine();
            Console.Clear();
        }
        else validBet = true;
    }

    Console.Clear();
    Console.WriteLine("Rock, Paper or Scissors?");
    Console.WriteLine("1) Rock");
    Console.WriteLine("2) Paper");
    Console.WriteLine("3) Scissors");
    playerInput = Console.ReadLine();

    switch (playerInput)
    {
        default:
        case "1":
            playerChoice = "rock";
            break;

        case "2":
            playerChoice = "paper";
            break;

        case "3":
            playerChoice = "scissors";
            break;
    }
    Console.Clear();
    Console.WriteLine("Player picked " + playerChoice + "!");
    Console.ReadLine();

    RNG = random.Next(1, 4);
    switch (RNG)
    {
        case 1:
            cpuChoice = "rock";
            break;

        case 2:
            cpuChoice = "paper";
            break;

        case 3:
            cpuChoice = "scissors";
            break;
    }

    Console.Clear();
    Console.WriteLine("Player picked " + playerChoice + "!");
    Console.WriteLine("CPU picked " + cpuChoice + "!");

    if (playerChoice == cpuChoice)
    {
        drawHappened = true;
    }

    if (drawHappened == false)
    {
        if (playerChoice == "rock")
        {
            if (cpuChoice == "scissors")
            {
                playerWonRound = true;
            }
            else playerWonRound = false;
        }
        if (playerChoice == "paper")
        {
            if (cpuChoice == "rock")
            {
                playerWonRound = true;
            }
            else playerWonRound = false;
        }
        if (playerChoice == "scissors")
        {

            if (cpuChoice == "paper")
            {
                playerWonRound = true;
            }
            else playerWonRound = false;
        }
    }
    Console.ReadLine();

    if (drawHappened == true)
    {
        Console.WriteLine("It's a draw!");
    }
    else if (playerWonRound == true)
    {
        Console.WriteLine("Player wins this round!");
        playerScore += betAmount;
        cpuScore -= betAmount;
    }
    else
    {
        Console.WriteLine("CPU wins this round!");
        playerScore -= betAmount;
        cpuScore += betAmount;
    }

    if (playerScore <= 0)
    {
        winningPlayer = "cpu";
    }
    else if (cpuScore <= 0)
    {
        winningPlayer = "player";
    }
    else winningPlayer = "no one";
}

switch (winningPlayer)
{
    case "player":
        Console.WriteLine("Player wins the game!");
        break;

    case "cpu":
        Console.WriteLine("CPU wins the game!");
        break;
}
Console.ReadLine();