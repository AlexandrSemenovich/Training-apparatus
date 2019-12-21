using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_apparatus.Models.Entity
{
    public class User
    { 
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Sex { get; set; }
        static int id = 0;

        public User() { }

        public User(string login, string password, string name, string surname, string sex)
        {
            Id = id++;
            Login = login;
            Password = password;
            Name = name;
            Surname = surname;
            Sex = sex;
        }
    }
}
