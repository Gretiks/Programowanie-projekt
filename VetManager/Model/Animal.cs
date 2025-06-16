using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetManager.Model
{
    internal class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public char Gender { get; set; }
        public int Age { get; set; }
        public Owner Owner { get; set; }

        public Animal(int id, string Name, string species, char gender, int age, Owner owner) 
        {
            this.Id = id;
            this.Name = Name;
            this.Species = species;
            this.Gender = gender;
            this.Age = age;
            this.Owner = owner;
        }
    }
}
