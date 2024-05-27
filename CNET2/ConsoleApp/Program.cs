using ConsoleApp;

List<string> jmena_list = ["Lukáš", "Karel", "Tomáš", 
            "Martin", "Radim", "Jakub", "Sofián"];

jmena_list.Add("Petra");

Console.WriteLine("Pocet lidi v seznamu: " + jmena_list.Count);

foreach (var jmeno in jmena_list)
{
    Console.WriteLine(jmeno + " pocet pismen: " + jmeno.Length);
}


Dictionary<int, string> dnyVTydnu = new Dictionary<int, string>()
{
    {1, "Pondělí"},
    {2, "Úterý"},
    {3, "Středa"},
    {4, "Čtvrtek"},
    {5, "Pátek"},
    {6, "Sobota"},
    {7, "Neděle"},
};

var streda = dnyVTydnu[3];






    


//for(int i = 0; i < jmena.Length; i++)
//{
//    var jmeno = jmena[i];
//    Console.WriteLine(jmeno);
//}





// Lukáš, Karel, Tomáš, Martin, Radim, Jakub, Sofián
// zeptat se na jméno a pozdravit
// nebo říct že neznám

//Console.WriteLine("Ahoj, zadej své jméno:");

//string jmeno = Console.ReadLine();

//switch (jmeno)
//{
//    case "Lukáš":
//        Console.WriteLine("Ahoj Lukáši");
//        break;
//    case "Karel":
//        Console.WriteLine("Ahoj Karle");
//        break;
//    case "Tomáš":
//        Console.WriteLine("Ahoj Tomáši");
//        break;
//    case "Martin":
//        Console.WriteLine("Ahoj Martine");
//        break;
//    case "Radim":
//        Console.WriteLine("Ahoj Radime");
//        break;
//    case "Jakub":
//        Console.WriteLine("Ahoj Jakube");
//        break;
//    case "Sofián":
//        Console.WriteLine("Ahoj Sofiáne");
//        break;
//    default:
//        Console.WriteLine("Takové jméno neznám.");
//        break;
//}


