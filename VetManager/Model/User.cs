using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace VetManager.Model
{
    internal class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string AccountType { get; set; }

        public User(string firstName, string lastName, int id, string email, string password, string accountType)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Id = id;
            this.Email = email;
            this.Password = password;
            this.AccountType = accountType;
        }
    }
}
