string welc= "Welcome to SoundX";
List<string> artistslist=new List<string>();

void welcome()
{   Console.WriteLine(@"
█▀ █▀█ █░█ █▄░█ █▀▄ ▀▄▀
▄█ █▄█ █▄█ █░▀█ █▄▀ █░█");
    Console.WriteLine(welc);
}
void menu(){
    Console.WriteLine("1: To Register a  artist");
    Console.WriteLine("2: Show all the registered artists");
    Console.WriteLine("3: To score a artist");
    Console.WriteLine("4: Show te average score of the artist");
    Console.WriteLine("0: Exit the program");
    
    Console.Write("Choose an option:");
    string chose= Console.ReadLine()!;
    int optnum=int.Parse(chose);
   
   switch(optnum){
    case 1: register();
        break;
    case 2: show();
        break;
    case 3:Console.WriteLine("You chose: "+optnum);
        break;
    case 4:Console.WriteLine("You chose: "+optnum);
        break;
    case 0:Console.WriteLine("you chose: "+optnum);
        Console.Write("Bye!!!");
        break;

    default:Console.WriteLine ("Invalid Option");
    break;
   }

}
void register(){
    Console.Clear();
    Console.WriteLine("Option 1: *Artist registering*");
    Console.Write("Type the name of the artist: ");
    string name=Console.ReadLine()!;
    artistslist.Add(name);
    Console.WriteLine($"The artist {name} has been registered with success");
    Thread.Sleep(3000);
    Console.Clear();
    welcome();
    menu();

}
void show(){
    Console.Clear();
    Console.WriteLine("OK,Let's see the artist you registered");
    foreach(string art in artistslist){
        Console.WriteLine($"Artist: {art}");
    }
    Console.WriteLine("Press any key to continue.");
    Console.ReadKey();
    Console.Clear();
    welcome();
    menu();    
}



welcome();
menu();

//for (int i =0;i<artists.Count; i++){
    //    Console.WriteLine($"Artists:  {artists[i]}");
    //}