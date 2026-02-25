using Class;

bool isCreatingPeople = true;
bool isChoosingEndOption = false;
bool ageIsValid = false;
string playerInput = "";
string givenName = "";
int givenAge = 0;
List<Person> persons = new List<Person>();

void ShowInfo()
{
    for (int i = 0; i < persons.Count; i++)
    {
        Person person = persons[i];
        Console.WriteLine("Person #" + (i + 1));
        Console.WriteLine("Name: " + person.name);
        Console.WriteLine("Age: " + person.age);
        Console.WriteLine("");
    }
}

while (isCreatingPeople == true)
{
    Console.WriteLine("give name");
    playerInput = Console.ReadLine();
    givenName = playerInput;

    ageIsValid = false;
    Console.WriteLine("give age");
    while (ageIsValid == false)
    {
        playerInput = Console.ReadLine();
        ageIsValid = Int32.TryParse(playerInput, out givenAge);
        if (ageIsValid == false)
        {
            Console.WriteLine("not a valid age. try writing a whole number");
        }
    }

    Person newPerson = new Person(givenName, givenAge);
    persons.Add(newPerson);




    isChoosingEndOption = true;
    while (isChoosingEndOption == true)
    {
        Console.WriteLine("ok now choose\n1) add new person\n2) look at people\n3) stop");
        playerInput = Console.ReadLine();
        switch (playerInput)
        {
            case "1":
                isChoosingEndOption = false;
                break;

            case "2":
                ShowInfo();
                playerInput = "";

                break;

            case "3":
                isCreatingPeople = false;
                isChoosingEndOption = false;
                break;
        }
    }
}