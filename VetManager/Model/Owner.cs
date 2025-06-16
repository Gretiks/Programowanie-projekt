using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetManager.Model
{
    internal class Owner
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string telephone_number { get; set; }

        public Owner(int id, string name, string surname, string telephone_number)
        {
            this.Id = id;
            this.Name = name;
            this.Surname = surname;
            this.telephone_number = telephone_number;
        }
    }
}