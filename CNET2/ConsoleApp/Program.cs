using PersonModel;

var data = DatasetAccess.LoadData(@"C:\Users\Student\source\repos\kubicek-skoleni\CNET2\data2024.json");

//var pocet_osob = data.Count();

//Console.WriteLine($"počet osob: {pocet_osob}");

//var person = data.First();
//Console.WriteLine(person.Email);

//var take1 = data.Take(1).ToArray();
//foreach (var p in take1)
//{
//    Console.WriteLine(p.Email);
//}

//var p2 = data.Where(person => person.Email.Contains("gmail.com"))
//            .FirstOrDefault();

//if (p2 != null)
//{
//    Console.WriteLine(p2.Email);
//}
//else
//{
//    Console.WriteLine("p2 is null");
//}

//data.Where(x => x.Id == 5).SingleOrDefault();

var g = data.GroupBy(x => x.LastName);

foreach(var skupina in g)
{
    var lastname = skupina.Key;
    var pocet_lidi_ve_skupine = skupina.Count();

    Console.WriteLine($"{lastname}: {pocet_lidi_ve_skupine}");
}