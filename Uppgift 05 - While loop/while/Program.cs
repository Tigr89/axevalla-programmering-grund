// See https://aka.ms/new-console-template for more information
using System.Formats.Asn1;
using System.Net.Security;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

int dollars = 350;
int eggs = 0;
int onions = 0;
int five_dollars = 0;
int really_cheap_steel = 0;
int pipe_bombs = 0;
int f5_keycaps = 0;
int landmines = 0;

int egg_cost = 10;
int onion_cost = 35;
int five_dollar_cost = 10;
int steel_cost = 0;
int pipe_bomb_cost = 150;
int f5_keycap_cost = 2;
int landmine_cost = 25;

string noun = "";

bool done_shopping = false;
while (dollars > 0)
{
    Console.WriteLine("You have " + dollars);
    Console.WriteLine("Buy somethin' will ya?\n\n1) Egg - " + egg_cost);
    Console.WriteLine("2) Onion - " + onion_cost);
    Console.WriteLine("3) 5 dollars for the price of " + five_dollar_cost + " - " + five_dollar_cost);
    Console.WriteLine("4) REALLY cheap steel(2g) - " + steel_cost);
    Console.WriteLine("5) Pipe bomb for your absurdly annoying neighbor - " + pipe_bomb_cost);
    Console.WriteLine("6) An F5 Keycap - " + f5_keycap_cost);
    Console.WriteLine("7) Landmine built by yours truly (Eco friendly!) - " + landmine_cost);
    string item = Console.ReadLine();
    string item_lowercase = item.ToLower();

    int name_length = item.Length;
    string substring_to_check = "";
    for (int i = 0; i < name_length - 1; i++)
    {
        switch (i)
        {
            case 0:
                substring_to_check = "inv";
                break;

            case 1:
                substring_to_check = "egg";
                break;

            case 2:
                substring_to_check = "onion";
                break;

            case 3:
                substring_to_check = "dollar";
                break;

            case 4:
                substring_to_check = "steel";
                break;

            case 5:
                substring_to_check = "pipe bomb";
                break;

            case 6:
                substring_to_check = "f5";
                break;

            case 7:
                substring_to_check = "landmine";
                break;

        }
        bool found_substring = item.Substring(0, name_length).Contains(substring_to_check);
        if (found_substring == true)
        {
            item_lowercase = substring_to_check;
            break;
        }
    }
    Console.Clear();
    switch (item_lowercase)
    {
        case "inv":
            Console.Clear();
            Console.WriteLine("This is your current arsenal of stuff:");
            if (eggs > 0) //Check if has egg
            {
                if (eggs == 1) //Check if use singular
                {
                    noun = " Egg";
                }
                else noun = " Eggs";
                Console.WriteLine(eggs + noun);
            }

            if (onions > 0)
            {
                if (onions == 1)
                {
                    noun = " Onion";
                }
                else noun = " Onions";
                Console.WriteLine(onions + noun);
            }

            five_dollars = dollars / 5;
            if (five_dollars > 0)
            {
                Console.WriteLine(five_dollars + " 5 Dollars");
            }

            if (really_cheap_steel > 0)
            {
                Console.WriteLine(really_cheap_steel + " grams of REALLY cheap steel");
            }

            if (pipe_bombs > 0)
            {
                if (pipe_bombs == 1)
                {
                    noun = " Pipe Bomb";
                }
                else noun = " Pipe Bombs";
                
                Console.WriteLine(pipe_bombs + noun);
            }

            if (f5_keycaps > 0)
            {
                if (f5_keycaps == 1)
                {
                    noun = " F5 Keycap";
                }
                else noun = " F5 Keycaps";
                Console.WriteLine(f5_keycaps + noun);
            }

            if (landmines > 0)
            {
                if (landmines == 1)
                {
                    noun = " Homemade Landmine";
                }
                else noun = " Homemade Landmines";
                Console.WriteLine(landmines + noun);
            }
            Console.WriteLine("\n\nFoodstuff count: " + (eggs + onions));
            Console.WriteLine("Improvised Explosive Device count: " + (pipe_bombs + landmines));

            Console.WriteLine("Are you happy with this? (y/n)");
            string confirm_purchase = Console.ReadLine();

            if (confirm_purchase == "y")
            {
                done_shopping = true;
            }
            break;

        case "1":
        case "egg":
            dollars -= 10;
            eggs += 1;
            break;

        case "2":
        case "onion":
            dollars -= 35;
            onions += 1;
            break;

        case "3":
        case "dollar":
            dollars -= 5;
            five_dollars += 1;
            break;

        case "4":
        case "steel":
            dollars -= 0;
            really_cheap_steel += 2;
            break;

        case "5":
        case "pipe bomb":
            dollars -= 150;
            pipe_bombs += 1;
            break;


        case "6":
        case "f5":
            dollars -= 2;
            f5_keycaps += 1;
            break;

        case "7":
        case "landmine":
            dollars -= 25;
            landmines += 1;
            break;

        default:
            Console.WriteLine("That's not a thing you can write.");
            break;
    }
    if (done_shopping == true)
        break;

}
Console.Clear();
if (done_shopping == false)
{
    Console.WriteLine("You've spent your money. You cannot buy anything else.");
    if (dollars < 0)
    {
        Console.WriteLine("Your balance is also in the negatives. Idiot lol.");
    }
}
else Console.WriteLine("Congratulations! You've completed your purchase!");
Console.WriteLine("This is what you bougt:");
if (eggs > 0)
{
    if (eggs == 1)
    {
        noun = " Egg";
    }
    else noun = " Eggs";
    Console.WriteLine(eggs + noun);
}

if (onions > 0)
{
    if (onions == 1)
    {
        noun = " Onion";
    }
    else noun = " Onions";
    Console.WriteLine(onions + noun);
}

five_dollars = dollars / 5;
if (five_dollars > 0)
{
    Console.WriteLine(five_dollars + " 5 Dollars");
}

if (really_cheap_steel > 0)
{
    Console.WriteLine(really_cheap_steel + " grams of REALLY cheap steel");
}

if (pipe_bombs > 0)
{
    if (pipe_bombs == 1)
    {
        noun = " Pipe Bomb";
    }
    else noun = " Pipe Bombs";

    Console.WriteLine(pipe_bombs + noun);
}

if (f5_keycaps > 0)
{
    if (f5_keycaps == 1)
    {
        noun = " F5 Keycap";
    }
    else noun = " F5 Keycaps";
    Console.WriteLine(f5_keycaps + noun);
}

if (landmines > 0)
{
    if (landmines == 1)
    {
        noun = " Homemade Landmine";
    }
    else noun = " Homemade Landmines";
    Console.WriteLine(landmines + noun);
}
Console.WriteLine("\n\nFoodstuff count: " + (eggs + onions));
Console.WriteLine("Improvised Explosive Device count: " + (pipe_bombs + landmines));