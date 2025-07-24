using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{

    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int? Age { get; set; }

        public override string ToString()
        {
            return Age > 0 ? $"{Name}({Id},{Email},{Age})" : $"{Name}({Id},{Email})";
        }



        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Person person = (Person)obj;
            return Id == person.Id;
        }
        public override int GetHashCode()
        {
            return Id;
        }


    }
}