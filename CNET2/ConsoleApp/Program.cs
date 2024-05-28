using PersonModel;

var data = DatasetAccess.LoadData(@"C:\Users\Student\source\repos\kubicek-skoleni\CNET2\data2024.json");

var pocet_osob = data.Count();

Console.WriteLine($"počet osob: {pocet_osob}");

var person = data.First();
Console.WriteLine(person.Email);

var take1 = data.Take(1);
foreach(var p in take1)
{
    Console.WriteLine(p.Email);
}