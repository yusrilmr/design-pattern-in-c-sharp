using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    interface IUserFactory
    {
        public IUser GetUser();
    }
}
