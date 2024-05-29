using ConsoleApp;
using ConsoleApp.Logger;
using PersonData;
using PersonModel;

ISimpleLogger logger = new SimpleConsoleLogger();

var data = await PersonApiCall.GetPeople(logger);

Console.WriteLine($"počet osob: {data.Count()}");

Console.ReadLine();