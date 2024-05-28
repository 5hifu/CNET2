using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PersonModel
{
    internal class DatasetAccess
    {
        public static List<Person> LoadData(string filepath)
        {
            if (!File.Exists(filepath))
            { 
                throw new FileNotFoundException("Nenašel jsem dataset");
            }

            try
            {
                var filecontent = File.ReadAllText(filepath);
                var people = JsonSerializer.Deserialize<List<Person>>(filecontent);
                return people;
            }
            catch (Exception ex) 
            {
                // co s tím?
                // Logger.Log(ex.Message)
                Console.WriteLine("ERROR: " + ex.Message);
                //return null;
                throw ex;
            }

        }
    }
}
