using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class SellerFactory : IUserFactory
    {
        private string _name;
        private int _age;
        public SellerFactory(string name, int age)
        {
            this._name = name;
            this._age = age;
        }
        public IUser GetUser()
        {
            return new Seller(this._name, this._age);
        }
    }
}
