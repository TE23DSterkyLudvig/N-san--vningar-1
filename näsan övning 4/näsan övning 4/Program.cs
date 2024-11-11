

string lösenord = "";

System.Console.WriteLine("Du ska logga in på din dator och du måste ange ett lösenord.");
System.Console.WriteLine("Vad är lösenordet?");
lösenord = Console.ReadLine();
if(lösenord == "12345"){
    System.Console.WriteLine("Välkommen");
}
while(lösenord != "12345"){
    System.Console.WriteLine("Skriv in lösenord igen!");
    lösenord = Console.ReadLine();
    if(lösenord == "12345"){
        System.Console.WriteLine("Välkommen!");
    }
}
Console.ReadLine();

