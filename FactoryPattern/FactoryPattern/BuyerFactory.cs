using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class BuyerFactory : IUserFactory
    {
        private string _name;
        private int _age;
        public BuyerFactory(string name, int age)
        {
            this._name = name;
            this._age = age;
        }
        public IUser GetUser()
        {
            return new Buyer(this._name, this._age);
        }
    }
}
