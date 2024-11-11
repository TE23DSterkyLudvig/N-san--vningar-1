int tal;
string talbok = "";                                                        //talbokstav


for (int i = 0; i < 5; i++)
{
  System.Console.WriteLine("Ange ett tal");  
  talbok = Console.ReadLine();
  int.TryParse(talbok, out tal);
  if (tal > 5){
    System.Console.WriteLine("Högre än 5");
  }
  else{
    System.Console.WriteLine("mindre eller lika med 5.");
  }
}
Console.ReadLine();