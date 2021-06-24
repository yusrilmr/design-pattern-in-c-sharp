using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class AdminFactory : IUserFactory
    {
        private string _name;
        private int _age;
        public AdminFactory(string name, int age)
        {
            this._name = name;
            this._age = age;
        }
        public IUser GetUser()
        {
            return new Admin(this._name, this._age);
        }
    }
}
