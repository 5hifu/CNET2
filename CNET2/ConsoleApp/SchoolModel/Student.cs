using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.SchoolModel
{
    internal class Student : Person
    {
        public Student(string name, DateOnly dateOfBirth, string classRoom) : base(name, dateOfBirth)
        {
            ClassRoom = classRoom;
        }

        public string ClassRoom { get; set; }

        public override string ToString()
        {
            return base.ToString() + $", ClassRoom: {ClassRoom}";
        }
    }
}
