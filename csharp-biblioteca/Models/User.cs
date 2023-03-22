using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca.Models
{
    internal class User
    {
        public string Lastname { get; set; } = "";
        public string Name { get; set; } = "";
        public string Email { get; set; } = "";
        public string Password { get; set; } = "";
        public string Phonenumber { get; set; } = "";

        public User(string lastname, string name, string email, string password, string phonenumber)
        {
            Lastname = lastname;
            Name = name;
            Email = email;
            Password = password;
            Phonenumber = phonenumber;
        }
    }
}
