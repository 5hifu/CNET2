using ConsoleApp.Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class PersonApiCall
    {
        public async static Task<List<Person>> GetPeople(ISimpleLogger logger)
        {
            try
            {
                var url = "https://localhost:7031";
                var client = new HttpClient();
                var people = await client.GetFromJsonAsync<List<Person>>($"{url}/people/all");
                return people;
            }
            catch (Exception ex)
            {
                logger.Log("chyba při volání Person API");
                logger.Log(ex);
                return new List<Person>();
            }
        }
    }
}
