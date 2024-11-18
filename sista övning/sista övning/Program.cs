int rätttal;
string gissning = "";
int gissningnum;


while (true)
{
    rätttal = Random.Shared.Next(4, 20);
    System.Console.WriteLine("Du ska gissa ett tal som är mellan 20 och 4. Börja gissa!");
    gissning = Console.ReadLine();
    // int.TryParse(gissning, out gissningnum);
    if (int.TryParse(gissning, out gissningnum) == false)
    {
        System.Console.WriteLine("Skriv en siffra!");
        Thread.Sleep(800);
    }
    else if (gissningnum < 4 || gissningnum > 20)
    {
        System.Console.WriteLine("Skriv en siffra mellan 20 och 4");
        gissning = Console.ReadLine();
    }
    else
    {
        System.Console.WriteLine($"Du gissade på {gissningnum}!");
        break;
    }
}
if (gissningnum == rätttal)
{
    System.Console.WriteLine("Grattis du gissade rätt!");
    System.Console.WriteLine($"Talet är {rätttal}");
}
else if (gissningnum > rätttal)
{
    Console.WriteLine("Du gissade för högt!");
    System.Console.WriteLine($"Talet är {rätttal}!");
}
else if (gissningnum < rätttal)
{
    System.Console.WriteLine("Du gissade för lågt!");
    System.Console.WriteLine($"Talet är {rätttal}!");
}
Console.ReadLine();
