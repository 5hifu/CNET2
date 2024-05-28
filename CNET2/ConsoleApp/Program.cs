using PersonModel;


var data = DatasetAccess.LoadData(@"C:\Users\Student\source\repos\kubicek-skoleni\CNET2\data2024.json");

var pocet_osob = data.Count();

Console.WriteLine($"počet osob: {pocet_osob}");