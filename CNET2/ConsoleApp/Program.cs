using ConsoleApp;
using ConsoleApp.Logger;
using PersonData;
using PersonModel;

ISimpleLogger logger = new SimpleFileLogger("log.txt");

var data = await PersonApiCall.GetPeople(logger);

Console.WriteLine($"počet osob: {data.Count()}");