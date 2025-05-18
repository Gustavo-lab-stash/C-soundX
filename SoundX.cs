string welc= "Welcome to SoundX";
//List<string> artistslist=new List<string>();
Dictionary<string,List<int>> artistsanotes= new Dictionary<string,List<int>>();

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
    case 3: artscore();
        break;
    case 4:average();
        break;
    case 0:Console.WriteLine("you chose: "+optnum);
        Console.Write("Bye!!!");
        break;

    default:Console.WriteLine ("Invalid Option");
    break;
   }

}
void register(){
    //option 1
    Console.Clear();
    Console.WriteLine("Option 1: Register artists*");
    Console.Write("Type the name of the artist: ");
    string name=Console.ReadLine()!;
    artistsanotes.Add(name,new List<int>());
    Console.WriteLine($"The artist {name} has been registered with success");
    Thread.Sleep(3000);
    Console.Clear();
    welcome();
    menu();

}
void show(){
    Console.Clear();
    Console.WriteLine("*Option 2:Show registered artists*");
    Thread.Sleep(2000);
    Console.WriteLine("OK,Let's see the artist you registered");
    foreach(string art in artistsanotes.Keys){
        Console.WriteLine($"Artist: {art}");
    }
    Console.WriteLine("Press any key to continue.");
    Console.ReadKey();
    Console.Clear();
    welcome();
    menu();    
}
void artscore(){
    //choose a band to give a note 
    //if the band exist in the dictionary,give a note to it
    //iff the band doesn't exist,go back to the menu
    Console.Clear();
    Console.WriteLine("Score a artist");
    Console.Write("Type the name of the artist you want to score: ");
    string name=Console.ReadLine()!;
    if(artistsanotes.ContainsKey(name)){
        Console.Write($"What note you give to {name}?");
        int note=int.Parse(Console.ReadLine()!);
        artistsanotes[name].Add(note);
        Console.WriteLine($"The note {note} has been registered to the artist {name}");
        Thread.Sleep(2000);
        Console.Clear();
        menu();

    }
    else{
        Console.WriteLine($"The artist {name} was not found!");
        Console.WriteLine("Type any key to go back to menu.");
        Console.ReadKey();
        Console.Clear();
        welcome();
        menu();

    }

}
void average(){
    Console.Clear();
    Console.WriteLine("Option 4: Average score");
    Console.WriteLine("Type the name of the artist");
    string name=Console.ReadLine()!;
    if(artistsanotes.ContainsKey(name)){
        List<int> averagenote= artistsanotes[name];
        Console.WriteLine($"the average of the artist {name} is {averagenote.Average()}");
        Console.WriteLine("Press any key to go back to menu");
        Console.ReadKey();
        Console.Clear();
        menu();

    }
else{
    Console.WriteLine("This artist is not registered.");
    Console.Clear();
    Console.ReadKey();
    welcome();
    menu();
}
}

welcome();
menu();


