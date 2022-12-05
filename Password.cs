using System;
using System.Collections.Generic;

namespace PasswordGenerator
{
    internal class Password
    {
        string name;
        string password;

        public string getName() => this.name;
        public string getPassword() => this.password;

        public Password(string input)
        {
            string[] s = input.Split('|');
            this.name = s[0];
            this.password = s[1];
        }
    }
}
