using System;
using System.Collections.Generic;
using System.Text;

namespace Messenger.Models
{
    public class Login
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public Login() { }
        public Login(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
