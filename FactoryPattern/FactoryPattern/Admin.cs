using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class Admin : IUser
    {
        public string Name { get; }
        public int Age { get; }
        public AccessLevel AccessLevel { get; }
        public Admin(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            this.AccessLevel = AccessLevel.Admin;
        }

        public AccessLevel GetAccessLevel()
        {
            return this.AccessLevel;
        }
    }
}
