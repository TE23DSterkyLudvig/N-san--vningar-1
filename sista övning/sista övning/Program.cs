int rätttal;
string gissning = "";
int gissningnum;


while(true){
    rätttal = Random.Shared.Next(4,20);
    System.Console.WriteLine("Du ska gissa ett tal som är mellan 20 och 4. Börja gissa!");
    gissning = Console.ReadLine();
    if(int.TryParse(gissning, out gissningnum)){
        int.TryParse(gissning, out gissningnum);
       // while(gissningnum > 20 && gissningnum < 4){
         //   System.Console.WriteLine("Skriv ett tal mellan 20 och 4!");
         //   gissning = Console.ReadLine();
         //   int.TryParse(gissning, out gissningnum);
        System.Console.WriteLine($"Du gissade på {gissningnum}!");
        break;
    }
    else{
        System.Console.WriteLine("Skriv en siffra!");
        Thread.Sleep(800);
    }
}
if(gissningnum == rätttal){
    System.Console.WriteLine("Grattis du gissade rätt!");
    System.Console.WriteLine($"Talet är {rätttal}");
}
else if(gissningnum > rätttal)
{
Console.WriteLine("Du gissade för högt!");
System.Console.WriteLine($"Talet är {rätttal}!");
}
else if(gissningnum < rätttal){
System.Console.WriteLine("Du gissade för lågt!");
System.Console.WriteLine($"Talet är {rätttal}!");
}
Console.ReadLine();
