// See https://aka.ms/new-console-template for more information


string[] s = { "stena", "sax", "påse" };

for (int i = 0; i < s.Length; i++)
{
    Console.WriteLine(s[i]);
}






var rand = new Random();
Console.WriteLine("hej nu spelar vi sten, sax, påse" );
int enemy = rand.Next(1,4);
string y = Console.ReadLine();
if (y == "sten"){
    if (enemy == 1)
    {
        Console.WriteLine("oavgjort");
    }
    if (enemy == 2)
    {
        Console.WriteLine("victory");
    }
    if (enemy == 3)
    {
        Console.WriteLine("defeat");
    }   
}
if (y == "sax") 
{
    if (enemy == 2)
    {
        Console.WriteLine("oavgjort");
    }
    if (enemy == 3)
    {
        Console.WriteLine("victory");
    }
    if (enemy == 1)
    {
        Console.WriteLine("defeat");
    }
}
if (y == "påse")
{
    if (enemy == 3)
    {
        Console.WriteLine("oavgjort");
    }
    if (enemy == 1)
    {
        Console.WriteLine("victory");
    }
    if (enemy == 2)
    {
        Console.WriteLine("defeat");
    }
}

