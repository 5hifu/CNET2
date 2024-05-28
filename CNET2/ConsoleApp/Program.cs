using PersonData;
using PersonModel;
using System.Net.Http.Json;

var url = "https://localhost:7031";

var client = new HttpClient();
//int id = 228;
//Person? p = await client.GetFromJsonAsync<Person>($"{url}/person/{id}");
//Console.WriteLine(p);

Console.WriteLine("Hledej podle emailu:");
var email = Console.ReadLine();
var res = await client.GetFromJsonAsync<List<Person>>($"{url}/person/searchemail/{email}");

if (res == null || res.Count == 0)
{
    Console.WriteLine("nenašel žádnou osobu");
}
else
{
    foreach (var item in res)
    {
        Console.WriteLine(item);
    }
}

Console.ReadLine();





