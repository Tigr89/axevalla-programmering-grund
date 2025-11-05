using System.Diagnostics.Tracing;

string writtenPrompt = "";

int number1 = 0;
int number2 = 0;
int writtenInt = 0;
Console.WriteLine("Okay, please type the first number to be in your equation.\n\nWrite something:");
while (writtenPrompt == "")
{
    writtenPrompt = Console.ReadLine();
    bool successfulConvert = Int32.TryParse(writtenPrompt, out writtenInt);
    if (successfulConvert == true)
    {
        number1 = writtenInt;
    }
    else
    {
        if (writtenPrompt == "")
        {
            Console.Clear();
            Console.WriteLine("That's an empty prompt. Try writing a NOT empty one, please.\n\nACTUALLY write something:");
            
        }
        else
        {
            Console.Clear();
            Console.WriteLine("That's not an acceptable prompt. Try writing a NUMBER.\n\nWrite some number:");
            writtenPrompt = "";
        }
    }
}

writtenPrompt = "";
string number2Name = "";
string chosenOperator = "";
Console.WriteLine("Alright, so.\n" + number1 + "... plus? minus? times? divided by?\n\nWrite +, -, * or /:");
while (writtenPrompt == "")
{
    writtenPrompt = Console.ReadLine();
    switch (writtenPrompt)
    {
        case "+":
        case "-":
            number2Name = "2nd term";
            break;

        case "*":
            number2Name = "2nd factor";
            break;

        case "/":
            number2Name = "divisor";
            break;

        default:
            chosenOperator = "";
            Console.Clear();
            Console.WriteLine("No, you have to write one of the four options I gave you. C'mon, now.\n\nWrite a +, -, * or /:");
            writtenPrompt = "";
            break;
    }
}
chosenOperator = writtenPrompt;
writtenPrompt = "";

Console.Clear();
Console.WriteLine("Sick.\n" + number1 + " " + chosenOperator + "...?\n\nWrite the value of the " + number2Name + ":");

while (writtenPrompt == "")
{
    writtenPrompt = Console.ReadLine();
    bool successfulConvert = Int32.TryParse(writtenPrompt, out writtenInt);
    if (successfulConvert == true)
    {
        number2 = writtenInt;
    }
    else
    {
        if (writtenPrompt == "")
        {
            Console.Clear();
            Console.WriteLine("That's an empty prompt. Try writing a NOT empty one, please.\n\nACTUALLY write something:");
        }
        else
        {
            Console.Clear();
            Console.WriteLine("That's not an acceptable prompt. Try writing a NUMBER.\n\nWrite some number:");
            writtenPrompt = "";
        }
    }
}

int finalOutcome = 0;
string finalOutcomeName = "";

float remainder = 0;
switch (chosenOperator)
{
    case "+":
        finalOutcome = number1 + number2;
        finalOutcomeName = "sum";
        break;

    case "-":
        finalOutcome = number1 - number2;
        finalOutcomeName = "difference";
        break;

    case "*":
        finalOutcome = number1 * number2;
        finalOutcomeName = "product";
        break;

    case "/":
        finalOutcome = number1 / number2;
        finalOutcomeName = "quotient";
        remainder = number1 % number2;
        break;
}

Console.Clear();
Console.WriteLine("Right, so.\n" + number1 + " " + chosenOperator + " " + number2 + "\nThe " + finalOutcomeName + " of those two would be " + finalOutcome + "!");
if (chosenOperator == "/")
{
    Console.WriteLine("...with a remainder of " + remainder + "!");
}