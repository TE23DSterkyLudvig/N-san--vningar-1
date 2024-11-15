using System.Runtime.ConstrainedExecution;

int tal;
string talbok = "";                                                        //talbokstav


for (int i = 0; i < 5; i++)
{
  //System.Console.WriteLine("Ange ett tal"); 
  //talbok = Console.ReadLine();
  while( true){
          Console.WriteLine("Ange ett tal"); 
        talbok = Console.ReadLine();
        
        if (int.TryParse(talbok, out tal)) 
        {
            break; 
        }
        else
        {
            Console.WriteLine("Skriv ett nummer.");
        }
  }
  int.TryParse(talbok, out tal);
  if (tal > 5){
    System.Console.WriteLine("Högre än 5");
  }
  else{
    System.Console.WriteLine("mindre eller lika med 5.");
  }
}
Console.ReadLine();