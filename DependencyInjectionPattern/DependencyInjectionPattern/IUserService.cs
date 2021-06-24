using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionPattern
{
    interface IUserService
    {
        public void ShowName();
        public void ShowAge();
        public void ShowAccessLevel();
    }
}
