using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_Application
{
    internal class User
    {
        public string id;
        public string name;
        public string email;
        public string number;
        public string age;
        public string cpf;

        public User(string id, string name, string email, string number, string age, string cpf)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.number = number;
            this.age = age;
            this.cpf = cpf;
        }
    }
}
