

string namn = "";

System.Console.WriteLine("Skriv in ditt användarnamn");
namn = Console.ReadLine();
if(namn.ToLower() == "peter"){
System.Console.WriteLine("välkommen till Sverige");}

while(namn.ToLower() != "peter"){
    System.Console.WriteLine("Fel användarnamn, testa igen!");
    namn = Console.ReadLine();
    if(namn.ToLower() == "peter"){
System.Console.WriteLine("välkommen till Sverige");}
}

Console.ReadLine();