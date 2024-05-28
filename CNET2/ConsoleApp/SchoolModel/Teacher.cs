using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.SchoolModel
{
    internal class Teacher : Person
    {
        public Teacher(string name, DateOnly dob, List<string> subjects) : base(name, dob)
        {
            Subjects = subjects;
        }
        public List<string> Subjects { get; set; }

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + string.Join(", ", Subjects);
        }
    }
}
