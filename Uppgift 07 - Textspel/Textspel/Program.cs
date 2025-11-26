// See https://aka.ms/new-console-template for more informatioN

using Microsoft.VisualBasic;
using System;
using System.Numerics;
using System.Runtime.CompilerServices;

Random rnd = new Random();
int playerHP = 1;
int playerBaseDMG = 0;
int playerDMG = 0;
int playerMaxHP = 1;

int enemyHP = 0;
int enemyDMG = 0;


string playerName = "";
string playerProfession = "";
string warriorWeapon = "";
string berserkerStyle = "";
string wizardSpecialization = "";

int attacksDone = 0;
int hitsTaken = 0;

float playerDMGDealtMult = 1.0f;
float playerDMGTakenMult = 1.0f;

bool monsterFleeing = false;

int berserkerConfidence = 0;
int berserkerAdrenaline = 0;
bool berserkerDeathBlow = false;
bool berserkerAdrenalineRush = false;
bool berserkerAdrenalineRushWin = false;
bool berserkerFeintRushdown = false;
int berserkerIntimidation = 0;
int berserkerIntimidationRequired = 0;
int berserkerIntimidationEffectiveness = 0;

string gameMode = "mainmenu"; //Where the game currently is; e.g. main menu, actual game, rules, etc.
string playerInput = ""; //The place to store what the player writes
while (gameMode != "quit") //This is to make everything loop, always, until the game is specifically meant to end.
{
    while (gameMode == "mainmenu") //While game is in "main menu" mode:
    {
        Console.WriteLine("Welcome to Game: the Game!"); //Write main menu stuff
        Console.WriteLine("1) Start");
        Console.WriteLine("2) Rules");
        Console.WriteLine("3) Quit");


        playerInput = Console.ReadLine();
        switch (playerInput)
        {
            case "1":
                gameMode = "start"; //Go to game initialization
                break;

            case "2":
                gameMode = "rules"; //Go to rules
                break;

            case "3":
                gameMode = "quit"; //Quit
                break;
        }
    }
    Console.Clear();
    while (gameMode == "rules")
    {
        Console.Clear();
        Console.WriteLine("Rules of Game: the Game");
        Console.WriteLine("idk ill write them when im done with the game");
        Console.ReadLine();
        gameMode = "mainmenu";
    }

    while (gameMode == "start")
    {
        //Initialize variables

        //Decide who you are:
        {
            //Decide name
            Console.WriteLine("Your name is...");
            Console.WriteLine("[Enter your character's name]");
            playerName = Console.ReadLine();



            //Decide profession
            Console.Clear();
            Console.WriteLine("Your name is " + playerName + ".\nYou are a...");
            Console.WriteLine("[Enter your character's profession]");
            Console.WriteLine("1) Warrior (not implemented lmao)");
            Console.WriteLine("2) Berserker");
            Console.WriteLine("3) Wizard (not implemented lmao)");
            playerInput = Console.ReadLine();
            switch (playerInput)
            {
                case "1":
                    playerHP = 69420;
                    playerBaseDMG = 30;
                    playerMaxHP = playerHP;
                    playerProfession = "warrior";
                    break;

                case "2":
                    playerHP = 100;
                    playerBaseDMG = 20;
                    playerMaxHP = playerHP;
                    playerProfession = "berserker";
                    break;

                case "3":
                    playerHP = 69420;
                    playerBaseDMG = 15;
                    playerMaxHP = playerHP;
                    playerProfession = "wizard";
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Invalid number. Defaulting to 1.");
                    Console.ReadLine();
                    break;
            }



            //Choose specialization
            Console.Clear();
            Console.WriteLine("Your name is " + playerName + ".\nYou are a " + playerProfession + ".");
            switch (playerProfession)
            {
                case "warrior":
                    Console.WriteLine("Warriors usually specialize in a specific type of weapon.");
                    Console.WriteLine("You have chosen to wield a...");
                    Console.WriteLine("[Choose a weapon to wield]");
                    Console.WriteLine("1) Sword - [Well-balanced and reliable]");
                    Console.WriteLine("2) Axe - [Destructive but less likely to land]");
                    Console.WriteLine("3) Hammer - [Catastrophic but extremely unwieldy]");
                    playerInput = Console.ReadLine();
                    switch (playerInput)
                    {
                        default:
                        case "1":
                            warriorWeapon = "sword";
                            break;

                        case "2":
                            warriorWeapon = "axe";
                            break;

                        case "3":
                            warriorWeapon = "hammer";
                            break;
                    }
                    break;

                case "berserker":
                    Console.WriteLine("Berserkers are known for their unbridled violence. However, there is a lot more nuance to their bloodlust.");
                    Console.WriteLine("You are...");
                    Console.WriteLine("[Choose a personal fighting style]");
                    Console.WriteLine("1) Loud - [Display power with shouts and boastful moves]");
                    Console.WriteLine("2) Reckless - [Display power with fearless abandon]");
                    Console.WriteLine("3) Brutal - [Display power with extreme, unnecessary injury]");
                    playerInput = Console.ReadLine();
                    switch (playerInput)
                    {
                        default:
                        case "1":
                            berserkerStyle = "loud";
                            break;

                        case "2":
                            berserkerStyle = "reckless";
                            break;

                        case "3":
                            berserkerStyle = "brutal";
                            break;
                    }
                    break;

                case "wizard":
                    Console.WriteLine("Skilled wizards choose a specialization and pursue knowledge and prowess in their specific focus.");
                    Console.WriteLine("You study...");
                    Console.WriteLine("[Choose your hyperfocus]");
                    Console.WriteLine("1) Arcanism - [Conjuring projectiles to deal direct damage]");
                    Console.WriteLine("2) Thaumaturgy - [Creation of utilities or beneficial effects]");
                    Console.WriteLine("3) Sorcery - [Manipulation of the elements to cause mayhem]");

                    playerInput = Console.ReadLine();
                    switch (playerInput)
                    {
                        default:
                        case "1":
                            wizardSpecialization = "arcanism";
                            break;

                        case "2":
                            wizardSpecialization = "thaumaturgy";
                            break;

                        case "3":
                            wizardSpecialization = "sorcery";
                            break;
                    }
                    break;
            }


            //Print complete character
            Console.Clear();
            switch (playerProfession)
            {
                case "warrior":
                    switch (warriorWeapon)
                    {
                        case "sword":
                        case "hammer":
                            Console.WriteLine("You are " + playerName + ", a " + warriorWeapon + "-wielding warrior.");
                            break;

                        case "axe":
                            Console.WriteLine("You are " + playerName + ", an axe-wielding warrior.");
                            break;

                    }
                    break;

                case "berserker":
                    switch (berserkerStyle)
                    {
                        case "loud":
                            Console.WriteLine("You are " + playerName + ", a loud and boisterous berserker.");
                            break;

                        case "reckless":
                            Console.WriteLine("You are " + playerName + ", a deathly reckless berserker.");
                            break;

                        case "brutal":
                            Console.WriteLine("You are " + playerName + ", a horrifyingly brutal berserker.");
                            break;
                    }
                    break;

                case "wizard":
                    Console.WriteLine("You are " + playerName + ", a wizard studying the art of " + wizardSpecialization + ".");
                    break;
            }

        }
        {
            int locationNameStructure = rnd.Next(1, 4);
            //Generate a random story introduction
            //Choose how to structure the initial loation name.
            //1 = Noun Noun (Gravestone Isle)
            //2 = Adjective Noun (Scarred Ruins)
            //3 = Noun of Nouns (Forest of Idiots)

            //Different word types
            string locationPlace = "";
            string locationThing = "";
            string locationAdjective = "";
            string locationDescription = "";
            string locationIntensity = "";

            int RNG = 0;
            bool willHaveDescription = false; //Determines if the intro will use the string stored in locationDescription
            bool willHaveIntensity = false; //Determines if the intro will use the string stored in locationIntensity (can only be true if willHaveDescriptions = true)
            {
                //List of every possible word
                string[] places = { "Palace", "Crypt", "Tundra", "Aqueduct", "Forest", "Desert", "Caves", "Cavern", "Cliffs", "Edge", "Hills", "Mountains", "Mountain Chain", "Trail", "City", "Ruins", "Fissure", "Skies", "Pathways", "Riverbank", "Beach", "Village", "Maze", "Labyrinth", "Battlegrounds", "Kingdom", "Mausoleum" };
                string[] things = { "Luminance", "Knowledge", "Platinum", "Scar", "Aardvark", "Blade", "Brimstone", "Gold", "Tracker", "Crime", "Fae", "Tuna", "Opal", "Sulfur", "Tendril", "Dragon", "Demon", "Gerbil", "Servant", "Bird", "Star" };
                string[] adjectives = { "Brilliant", "Mindless", "Newborn", "Indestructible", "Abandoned", "Hopeful", "Ruinous", "Stained", "Blazing", "Horrifying", "Royal", "Toxic", "Torn", "Demonic", "Legendary", "Ruthless", "Mythical", "Masterful", "Inept", "Unreal", "Menacing", "Ravenous", "Draconic", "Endothermic" };
                string[] descriptions = { "fabled ", "unknown ", "wealthy ", "unstable ", "dangerous ", "renowned ", "deadly " };
                string[] intensities = { "not at all ", "barely ", "lightly ", "somewhat ", "very ", "extremely ", "absurdly " };

                //Roll a word for each one
                locationPlace = places[rnd.Next(0, places.Length)];
                locationThing = things[rnd.Next(0, things.Length)];
                locationAdjective = adjectives[rnd.Next(0, adjectives.Length)];
                locationDescription = descriptions[rnd.Next(0, descriptions.Length)];
                locationIntensity = intensities[rnd.Next(0, intensities.Length)];

                RNG = rnd.Next(0, 2); //Roll a 1 or 0, then convert them to true or false, respectively.
                willHaveDescription = Convert.ToBoolean(RNG);
                //willHaveDescription could just be an int to begin with, which would skip having to convert.
                //But I am converting here for clarity.

                //Correct plurality for locationNameStructure = 3, aka "Blank of Blanks"
                if (locationNameStructure == 3)
                {
                    switch (locationThing)
                    {
                        case "Gold":
                        case "Brimstone":
                        case "Platinum":
                        case "Knowledge":
                        case "Luminance":
                            //Don't make it plural
                            break;

                        default:
                            //Do make it plural
                            locationThing = locationThing + "s";
                            break;
                    }
                }

                if (willHaveDescription == true)
                {
                    RNG = rnd.Next(0, 2);
                    willHaveIntensity = Convert.ToBoolean(RNG);

                    if (willHaveIntensity == false) //If it WON'T have an intensity...
                    {
                        locationIntensity = ""; //Set locationIntensity to be empty, so it doesn't write anything
                    }
                }
                else //If it WON'T have a description...
                {
                    locationDescription = ""; //Set locationDescription and locationIntensity to be empty, so they don't write anything
                    locationIntensity = "";
                }
            }


            //Print the declaration of where you find yourself
            switch (locationNameStructure)
            {
                case 1:
                    Console.WriteLine("You are exploring the " + locationIntensity + locationDescription + locationThing + " " + locationPlace + ".");
                    break;

                case 2:
                    Console.WriteLine("You are exploring the " + locationAdjective + " " + locationPlace + ".");
                    break;

                case 3:
                    Console.WriteLine("You are exploring the " + locationPlace + " of " + locationThing + ".");
                    break;
            }
            


            //Print the description of what the place is like
            string startPhrase = ""; //The first few words. Ex: "The air crackles with", "A repulsive odor permeates the"

            //Build the startPhrase

            //Decide if the generated location name implies you being inside or outdoors
            //0 = Is inside
            //1 = Is outside
            int locationIsInsideOrOutside = 0;
            switch(locationPlace)
            {
                case "Forest":
                case "Tundra":
                case "Desert":
                case "Cliffs":
                case "Edge":
                case "Hill":
                case "Mountains":
                case "Mountain Chain":
                case "Trail":
                case "Skies":
                case "Pathways":
                case "Beach":
                case "Riverbank":
                    locationIsInsideOrOutside = 1;
                    break;

                default:
                    locationIsInsideOrOutside = 0;
                    break;
            }

            //Decide if the generated location is good, evil or neutral
            //0 = Evil
            //1 = Good
            //2 = Neutral
            int locationAllegiance = 0;
            string locationWordToCheck = ""; //If the locationNameStructure = 1 or 3, use locationThing to check for allegience
                                             //If = 2, use locationAdjectives instead
            switch (locationNameStructure)
            {
                case 1:
                case 3:
                    locationWordToCheck = locationThing;
                    break;
                case 2:
                    locationWordToCheck = locationAdjective;
                    break;

            }

            //ACTUALLY decide locationAllegiance
            switch (locationWordToCheck)
            {
                //Evil words
                case "Brimstone":
                case "Crime":
                case "Sulfur":
                case "Tendril":
                case "Demon":
                case "Dragon":
                case "Scar":
                case "Ruinous":
                case "Horrifying":
                case "Torn":
                case "Stained":
                case "Demonic":
                case "Menacing":
                case "Ravenous":
                case "Blazing":
                    locationAllegiance = 0;
                    break;

                //Good words
                case "Platinum":
                case "Gold":
                case "Fae":
                case "Opal":
                case "Star":
                case "Hopeful":
                case "Mythical":
                case "Indestructible":
                case "Benevolent":
                case "Brilliant":
                case "Luminance":
                case "Brave":
                    locationAllegiance = 1;
                    break;

                default:
                    locationAllegiance = 2;
                    break;
            }


            string startPhraseEnvironment = "";
            string startPhraseVerb = "";
            string startPhraseNoun = "";
            //Objects that fit with being outside/inside. If outside, then you'll see "The trees" etc. If inside, you'll see "The walls" etc.
            string[] startPhraseOutsideEnvironments = { "air", "ground", "trees", "wind" };
            string[] startPhraseInsideEnvironments = { "air", "walls", "floor", "lights", "furniture" };
            //Pick startPhraseNoun
            switch (locationIsInsideOrOutside)
            {
                case 0: //If inside
                    startPhraseEnvironment = startPhraseInsideEnvironments[rnd.Next(0, startPhraseInsideEnvironments.Length)];
                    break;

                case 1: //If outside
                    startPhraseEnvironment = startPhraseOutsideEnvironments[rnd.Next(startPhraseOutsideEnvironments.Length)];
                    break;
            }
            int startPhraseEnvironmentPlurality = 0; //The plurality of the chosen environment. The startPhraseVerb will reflect the plurality to respect grammar
            //0 = Plural
            //1 = Singular
            switch (startPhraseEnvironment)
            {
                case "air":
                case "ground":
                case "wind":
                case "floor":
                case "furniture":
                    startPhraseEnvironmentPlurality = 1;
                    break;

                case "trees":
                case "walls":
                case "lights":
                    startPhraseEnvironmentPlurality = 0;
                    break;
            }

            string[] startPhraseVerbSingular = { "reminds you of", "crackles with", "whispers of", "glows dimly with", "vibrates with", "fills you with", "emits a scent of" };
            string[] startPhraseVerbPlural = { "remind you of", "crackle with", "whisper of", "glow dimly with", "vibrate with", "fill you with", "emit a scent of" };
            //Pick verb
            if (startPhraseEnvironmentPlurality == 0)
            {
                startPhraseVerb = startPhraseVerbPlural[rnd.Next(0, startPhraseVerbPlural.Length)];
            }
            else startPhraseVerb = startPhraseVerbSingular[rnd.Next(0, startPhraseVerbSingular.Length)];

            string[] startPhraseEvilNouns = { "hatred", "hellfire", "death", "evil", "soullessness", "fear" };
            string[] startPhraseGoodNouns = { "joyousness", "inner peace", "life", "healing", "bravery" };
            string[] startPhraseNeutralNouns = { "mystery", "treasure", "arcane phenomena", "nothing", "tea", "nothing exceptionally special" };
            switch (locationAllegiance)
            {
                case 0:
                    startPhraseNoun = startPhraseEvilNouns[rnd.Next(0, startPhraseEvilNouns.Length)];
                    break;
                case 1:
                    startPhraseNoun = startPhraseGoodNouns[rnd.Next(0, startPhraseGoodNouns.Length)];
                    break;
                case 2:
                    startPhraseNoun = startPhraseNeutralNouns[rnd.Next(0, startPhraseNeutralNouns.Length)];
                    break;
            }    

            //Print startPhrase
            startPhrase = "The " + startPhraseEnvironment + " " + startPhraseVerb + " " + startPhraseNoun + ".";
            Console.WriteLine(startPhrase);
            Console.ReadLine();
            gameMode = "game";
        }
    }
    

    while (gameMode == "game")
    {
        Console.Clear();
        Console.WriteLine("As you walk through the area, you are attacked by a horrible monster!");
        Console.ReadLine();
        //I had the idea to randomly create a monster by using the location name to decide; i.e. "Caverns of Hellfire" might host demonic arachnids.
        //But that would take so much time, and I think I've proven myself capable of doing that if I had infinite time.

        //Change the "Battle engage" text depending on playerProfession and specialization.
        switch (playerProfession)
        { 
            case "warrior":
                Console.WriteLine("You ready your " + warriorWeapon + "...");
                break;

            case "berserker":
                switch (berserkerStyle)
                {
                    case "loud":
                        Console.WriteLine("With an echoing roar, you slam the blade of your halberd directly into the ground.");
                        break;

                    case "reckless":
                        Console.WriteLine("Sensing danger, you gleefully rush towards the opportunity to feel the adrenaline rush you've come to crave.");
                        break;

                    case "brutal":
                        Console.WriteLine("With a faint chuckle, you wipe your halberd clean from the gore of your last victim.");
                        break;
                }
                break;

            case "wizard":
                switch (wizardSpecialization)
                {
                    case "arcanism":
                        Console.WriteLine("You prepare a glimmering bolt with a practiced somatic movement.");
                        break;

                    case "thaumaturgy":
                        Console.WriteLine("You channel yourself with magical bravery, as you would not have the courage to engage in combat without it.");
                        Console.WriteLine("(That's what you get for being a support-class in a solo scenario)");
                        break;

                    case "sorcery":
                        Console.WriteLine("You cause a slight downpour, as well as some howling winds for dramatic effect.");
                        break;
                }
                break;
        }








        //BATTLE
        Console.ReadLine();
        Console.WriteLine("The unidentified monster attacks!\n");
        bool battleIsHappening = true;
        enemyHP = 200;
        berserkerIntimidationRequired = 10;
        string playerAction = "";
        while (battleIsHappening == true)
        {
            Console.WriteLine(playerName + "'s HP: " + playerHP);
            Console.WriteLine("Enemy HP: " + enemyHP);
            if (playerProfession == "berserker")
            {
                switch (berserkerStyle)
                {
                    case "loud":
                        Console.WriteLine(playerName + "'s Confidence: " + berserkerConfidence);
                        break;

                    case "reckless":
                        Console.WriteLine(playerName + "'s Adrenaline Levels: " + berserkerAdrenaline);
                        break;

                    case "brutal":
                        Console.WriteLine(playerName + "'s Intimidation Levels: " + berserkerIntimidation);
                        Console.WriteLine("Intimidation required: " + berserkerIntimidationRequired);
                        break;
                }
            }
            //Warrior Battle
            if (playerProfession == "warrior")
            {
                Console.WriteLine("Choose an action:\n1) Attack - [Ends turn]\n2) Pass and Heal - [Ends turn]");
                playerInput = Console.ReadLine();
                switch (playerInput)
                {
                    case "1":
                        playerAction = "attack";
                        break;

                    case "2":
                        playerAction = "pass";
                        break;
                }
            }

            //Berserker Battle
            if (playerProfession == "berserker")
            {
                Console.WriteLine("Choose an action:\n1) Attack - [Ends turn]\n2) Special\n3) Pass and Heal - [Ends turn]");
                playerInput = Console.ReadLine();
                switch (playerInput)
                {
                    default:
                    case "1":
                        playerAction = "attack";
                        playerDMG = playerBaseDMG;
                        break;

                    case "2":
                        playerAction = "special";
                        Console.WriteLine("Choose an ability:");

                            switch (berserkerStyle)
                            {
                                case "loud":
                                    Console.WriteLine("1) Barbaric YAWP! - Gain 1 confidence, but deal less damage until all confidence is lost");
                                    Console.WriteLine("2) Show Off - idk");
                                    Console.WriteLine("3) Stylish Hack - Attack and remove all confidence. Multiply the damage dealt by the confidence you spent");
                                    break;

                                case "reckless":
                                    Console.WriteLine("1) Mad Dash - Gain adrenaline equal to the number of attacks you've made.");
                                    Console.WriteLine("2) More! MORE! - Gain adrenaline equal to the number of hits you've taken.");
                                    Console.WriteLine("3) Adrenaline Rush - Attack after the enemy instead of before. Taking a lethal blow increases damage from this attack, scaling with adrenaline. If this kills the enemy, you survive the lethal blow.");
                                    break;

                                case "brutal":
                                    Console.WriteLine("1) Show Collection - Display your previous victims to the enemy, intimidating them.");
                                    Console.WriteLine("2) Destroy Environment - Break something nearby, increasing the effectiveness of your intimidation attempts.");
                                    Console.WriteLine("3) Feint Rushdown - Rush towards the enemy, causing the enemy to run away if it is intimidated enough.");
                                    break;
                            }
                        break;
                }

                if (playerAction == "special")
                {
                    playerInput = Console.ReadLine();
                    switch (playerInput)
                    {
                        default:
                        case "1":
                            switch (berserkerStyle)
                            {
                                case "loud":
                                    berserkerConfidence += 1;
                                    playerDMGDealtMult /= 2;
                                    break;

                                case "reckless":
                                    berserkerAdrenaline += attacksDone;
                                    break;

                                case "brutal":
                                    berserkerIntimidation += 1 + berserkerIntimidationEffectiveness;
                                    break;
                            }
                            break;

                        case "2":
                            switch (berserkerStyle)
                            {
                                case "loud":
                                    berserkerConfidence += 2;
                                    playerDMGTakenMult += 0.5f;
                                    break;

                                case "reckless":
                                    berserkerAdrenaline += hitsTaken;
                                    break;

                                case "brutal":
                                    berserkerIntimidationEffectiveness += 1;
                                    break;
                            }
                            break;

                        case "3":
                            switch (berserkerStyle)
                            {
                                case "loud":
                                    playerAction = "attack";
                                    playerDMG = playerBaseDMG * berserkerConfidence;
                                    berserkerConfidence = 0;
                                    break;

                                case "reckless":
                                    berserkerAdrenalineRush = true;
                                    break;

                                case "brutal":
                                    berserkerFeintRushdown = true;
                                    break;
                            }
                            break;
                    }
                }
            } 

            //Wizard Battle
            if (playerProfession == "wizard")
            {
                Console.WriteLine("Choose an action:\n1) Attack\n2) Special");
            }

            Console.Clear();
            //Attack Phase
            if (berserkerAdrenalineRush == true) //If BerserkerAdrenalineRush is active, enemy attacks first
            {
                Console.WriteLine("The monster attacks!"); //Change this to ...WriteLine("The " + monsterName + " attacks"); if you have different enemy types which I don't
                enemyDMG = rnd.Next(5, 10); //Make these variables if you have different enemy types which I don't

                playerHP -= enemyDMG;
                hitsTaken += 1;
                Console.ReadLine();
                Console.WriteLine("The monster dealt " + enemyDMG + " damage!");
                Console.WriteLine("You are at " + playerHP + " HP.");
                Console.ReadLine();
                if (playerHP <= 0) //If damage is lethal,
                {
                    //Activate Adrenaline Rush
                    Console.WriteLine("The thrill of Death's Door empowers you!");
                    playerHP = 0;
                    berserkerDeathBlow = true;
                    Console.ReadLine();
                }
                if (berserkerDeathBlow == true) //If player died,
                {
                    Console.Clear();
                    Console.WriteLine("You focus all your might into a devastating, adrenaline-filled hack!");
                    Console.ReadLine();
                    playerDMG = (playerDMG * 3) + (10 * berserkerAdrenaline); //Deal massive damage...
                    Console.WriteLine("You dealt " + playerDMG + " damage!");
                    enemyHP -= playerDMG;
                    Console.ReadLine();
                    if (enemyHP <= 0) //...and if enemy dies...
                    {
                        Console.WriteLine("The monster is annihilated, and your adrenaline keeps you from being claimed by Death!");
                        enemyHP = 0;
                        berserkerAdrenalineRushWin = true; //...you don't die
                        Console.WriteLine("Adrenal");
                    }
                    else
                    {
                        Console.WriteLine("The monster survives with " + enemyHP + " HP...");
                        Console.WriteLine("As the adrenaline rush fades, you do along with it.");
                    }
                    
                }
            }
            else //Otherwise, player attacks first
            {
                if (berserkerFeintRushdown == true)
                {
                    Console.WriteLine("You rush forward, roaring, halberd held high...");
                    if (berserkerIntimidation >= berserkerIntimidationRequired)
                    {
                        Console.WriteLine("...and the monster flees, too afraid to confront you any longer!");
                        monsterFleeing = true;
                    }
                    else
                    {
                        Console.WriteLine("...but the monster was not intimidated enough to start fleeing.");
                        monsterFleeing = false;
                    }
                }
                else if (playerAction == "attack")
                {
                    Console.WriteLine("You prepare a wicked hack...");
                    Console.ReadLine();
                    attacksDone += 1;
                    enemyHP -= playerDMG;
                    Console.WriteLine("You dealt " + playerDMG + " damage.");
                    if (enemyHP <= 0)
                    {
                        enemyHP = 0;
                        Console.WriteLine("The monster crumbles!");
                    }
                    else Console.WriteLine("The enemy is left at " + enemyHP + " HP.");
                }

                if ((enemyHP > 0) && (monsterFleeing == false))
                {
                    Console.WriteLine("The enemy attacks...");
                    Console.ReadLine();
                    enemyDMG = rnd.Next(5, 10);
                    playerHP -= enemyDMG;
                    hitsTaken += 1;
                    Console.WriteLine("...and deals " + enemyDMG + " damage!");
                    Console.ReadLine();
                    if (playerHP <= 0)
                    {
                        playerHP = 0;
                        Console.Clear();

                    }
                }

                if ((monsterFleeing == false) && (berserkerAdrenalineRushWin == false) && (playerHP == 0))
                {
                    Console.WriteLine("You crumble to the floor and fade away...");
                    Console.WriteLine("You lost.");
                    Console.ReadLine();
                    gameMode = "mainmenu";
                    battleIsHappening = false;
                    Console.Clear();
                }
                if ((monsterFleeing == true) || (berserkerAdrenalineRushWin == true) || (enemyHP == 0))
                {
                    Console.WriteLine("GG");
                        Console.ReadLine();
                    gameMode = "mainmenu";
                    battleIsHappening = false;
                    Console.Clear();
                }
                playerDMG = playerBaseDMG;
            }
        }
    }
}