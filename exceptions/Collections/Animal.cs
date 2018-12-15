using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    class Animal
    {
        public string Name { get; set; }
        public Animal(string name, Gender gender)//constructor
        {
            this.Name = name;
            this.Gender = gender;
        }

        public Gender Gender { get; set; }
    }

    public enum Gender
    {
        Male,
        Female
    }
}
