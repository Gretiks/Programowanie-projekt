using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetManager.Model
{
    internal class Visit
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public Animal Animal { get; set; }

        public Visit(int id, DateTime date, string type, string description, Animal animal)
        {
            this.Id = id;
            this.Date = date;
            this.Type = type;
            this.Description = description;
            this.Animal = animal;
        }

    }
}