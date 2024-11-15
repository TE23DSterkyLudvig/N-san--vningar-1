string text = "";
int textnum;


while(true){
    System.Console.WriteLine("Ange ett nummer!");
text = Console.ReadLine();
    if(int.TryParse(text,out textnum)){
        break;
    }
    else{
        System.Console.WriteLine("Skriv ett nummer!");
        Thread.Sleep(800);
    }
}
while(int.TryParse(text,out textnum)){
    System.Console.WriteLine("Minnesota");
    Thread.Sleep(4000);
}
