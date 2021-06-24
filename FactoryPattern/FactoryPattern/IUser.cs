using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    interface IUser
    {
        public string Name { get; }
        public int Age { get; }
        public AccessLevel AccessLevel { get; }
        public AccessLevel GetAccessLevel();
    }
}
