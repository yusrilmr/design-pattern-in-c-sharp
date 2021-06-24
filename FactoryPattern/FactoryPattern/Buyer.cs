using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class Buyer : IUser
    {
        public string Name { get; }
        public int Age { get; }
        public AccessLevel AccessLevel { get; }
        public Buyer(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            this.AccessLevel = AccessLevel.Buyer;
        }

        public AccessLevel GetAccessLevel()
        {
            return this.AccessLevel;
        }
    }
}
