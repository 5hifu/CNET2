using ConsoleApp;

List<string> jmena_list = ["Lukáš", "Karel", "Tomáš", 
            "Martin", "Radim", "Jakub", "Sofián"];

Dictionary<string, string> jmena_osloveni = new Dictionary<string, string>()
{
    { "Lukáš", "Lukáši" },
    { "Karel", "Karle" },
    { "Tomáš", "Tomáš" },
    { "Martin", "Martine" },
    { "Radim", "Radime" },
    { "Jakub", "Jakube" },
    { "Sofián", "Sofiáne" },
};

// zeptat se na jméno a pozdravit
// nebo říct že neznám

Console.WriteLine("Ahoj, zadej své jméno:");

string jmeno = Console.ReadLine();

if (!jmena_osloveni.ContainsKey(jmeno))
{
    Console.WriteLine("Takové jméno neznám.");
    return;
}

var osloveni = jmena_osloveni[jmeno];

Console.WriteLine($"Ahoj {osloveni}");




