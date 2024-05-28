using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.SchoolModel
{
    internal class Person
    {
        public Person(string name, DateOnly dateOfBirth)
        {
            Name = name;
            DateOfBirth = dateOfBirth;
        }

        public string Name { get; set; }

        public DateOnly DateOfBirth { get; set; }

        public override string ToString() 
            => $"Name: {Name}, DateOfBirth:{DateOfBirth.ToString("dd.MM.yyyy")}"; 
        
    }
}
