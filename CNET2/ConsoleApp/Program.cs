using PersonModel;

var data = DatasetAccess.LoadData(@"C:\Users\Student\source\repos\kubicek-skoleni\CNET2\data2024.json");



// nejmladší osoba

//var nejmladsi = data.OrderByDescending(x => x.DateOfBirth).First();

//Console.WriteLine(nejmladsi);

// města od nepočetnějších

var mesta_ordered = data.GroupBy(person => person.Address?.City)
                        .OrderByDescending(mesto_lide => mesto_lide.Count())
                        .Take(10)
                        .ToList();

foreach(var mesto in mesta_ordered)
{
    Console.WriteLine($"{mesto.Key}: {mesto.Count()}");
}