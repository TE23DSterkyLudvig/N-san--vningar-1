

string namn = "";
string lösenord = "";

System.Console.WriteLine("Skriv in ditt användarnamn");
namn = Console.ReadLine();
if(namn.ToLower() == "kalleanka"){
System.Console.WriteLine("Rätt användarnamn, Vad är lösenordet?");
lösenord = Console.ReadLine();
if(lösenord.ToLower() == "12345"){
    System.Console.WriteLine("välkommen till Sverige");
    }
        while(lösenord!= "12345" ){
        System.Console.WriteLine("skriv in igen");
        lösenord = Console.ReadLine();}
        if(lösenord == "12345"){
            System.Console.WriteLine("Välkommen");
        }
    }

while(namn.ToLower() != "kalleanka"){
    System.Console.WriteLine("Fel användarnamn, testa igen!");
    namn = Console.ReadLine();
}
    




Console.ReadLine();