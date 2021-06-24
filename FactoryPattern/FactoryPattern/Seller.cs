using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class Seller : IUser
    {
        public string Name { get; }
        public int Age { get; }
        public AccessLevel AccessLevel { get; }
        public Seller(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            this.AccessLevel = AccessLevel.Seller;
        }

        public AccessLevel GetAccessLevel()
        {
            return this.AccessLevel;
        }
    }
}
